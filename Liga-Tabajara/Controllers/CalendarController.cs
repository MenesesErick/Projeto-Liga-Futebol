using Liga_Tabajara.Data;
using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Linq;

public class CalendarController : Controller
{
    private readonly LigaContext db = new LigaContext();

    public ActionResult Index()
    {
        var partidas = db.Partidas
            .Include("TimeCasa")
            .Include("TimeVisitante")
            .OrderBy(p => p.DataHora)
            .ToList();

        return View(partidas);
    }

    [HttpPost]
    public ActionResult Generate()
    {
        // 1) Carrega os 20 times aptos
        var teams = db.Times
                      .Where(t => t.Status)
                      .OrderBy(t => t.Id)
                      .ToList();
        if (teams.Count != 20)
        {
            TempData["Error"] = "É necessário exatamente 20 times aptos para gerar o calendário.";
            return RedirectToAction("Index", "Home");
        }

        // 2) Geração das rodadas
        var firstHalf = GenerateRoundRobin(teams);
        var secondHalf = firstHalf.Select(r => r.Select(f => (home: f.away, away: f.home)).ToList()).ToList();

        // 3) Remove partidas antigas
        db.Partidas.RemoveRange(db.Partidas);
        db.SaveChanges();

        // 4) Persiste partidas
        int rodada = 1;
        foreach (var round in firstHalf.Concat(secondHalf))
        {
            var dateForRound = NextRoundDate(rodada);
            foreach (var (home, away) in round)
            {
                db.Partidas.Add(new Partida
                {
                    TimeCasaId = home.Id,
                    TimeVisitanteId = away.Id,
                    DataHora = dateForRound
                });
            }
            rodada++;
        }
        db.SaveChanges();

        TempData["Success"] = "Calendário gerado com sucesso!";
        return RedirectToAction("Index", "Home");
    }

    // ====================================================================================
    // Métodos auxiliares abaixo (copiados para dentro do mesmo controller)
    // ====================================================================================
    private List<List<(Time home, Time away)>> GenerateRoundRobin(List<Time> teams)
    {
        int n = teams.Count;
        var rounds = new List<List<(Time, Time)>>();
        var rotation = teams.Skip(1).ToList();

        for (int r = 0; r < n - 1; r++)
        {
            var pairings = new List<(Time, Time)>();
            // primeiro par fixo
            if (r % 2 == 0)
                pairings.Add((teams[0], rotation[0]));
            else
                pairings.Add((rotation[0], teams[0]));

            // demais pares
            for (int i = 1; i < n / 2; i++)
            {
                pairings.Add((rotation[i], rotation[rotation.Count - i]));
            }

            rounds.Add(pairings);

            // rotaciona
            var last = rotation.Last();
            rotation.RemoveAt(rotation.Count - 1);
            rotation.Insert(0, last);
        }

        return rounds;
    }

    private DateTime NextRoundDate(int rodada)
    {
        // Exemplo: domingos sucessivos às 15h
        var start = DateTime.Today.AddDays(1);
        var firstSunday = start.AddDays(((int)DayOfWeek.Sunday - (int)start.DayOfWeek + 7) % 7);
        return firstSunday.AddDays(7 * (rodada - 1)).AddHours(15);
    }
}