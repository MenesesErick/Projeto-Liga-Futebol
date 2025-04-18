using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class SimulacaoController : Controller
    {
        private readonly LigaContext db = new LigaContext();

        // Essa action não é mais usada, mas pode ser mantida se quiser uma tela exclusiva depois
        public ActionResult Index()
        {
            return View();
        }

        // Executa a simulação: atribui placares e gols detalhados aleatórios a todas as partidas
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Run()
        {
            // Carrega todas as partidas
            var partidas = db.Partidas.ToList();

            // Limpa gols antigos
            db.Gols.RemoveRange(db.Gols);
            db.SaveChanges();

            var rand = new Random();

            foreach (var p in partidas)
            {
                // Geração de quantidade de gols (0 a 5)
                int golsCasa = rand.Next(0, 6);
                int golsVisitante = rand.Next(0, 6);

                // Busca jogadores de cada time
                var jogadoresCasa = db.Jogadores
                                      .Where(j => j.TimeId == p.TimeCasaId)
                                      .ToList();
                var jogadoresVisitante = db.Jogadores
                                            .Where(j => j.TimeId == p.TimeVisitanteId)
                                            .ToList();

                // Registra gols detalhados para time da casa
                for (int i = 0; i < golsCasa; i++)
                {
                    if (!jogadoresCasa.Any()) break;
                    var jogador = jogadoresCasa[rand.Next(jogadoresCasa.Count)];
                    int minuto = rand.Next(1, 91); // minuto entre 1 e 90
                    db.Gols.Add(new Gol
                    {
                        PartidaId = p.Id,
                        JogadorId = jogador.Id,
                        Minuto = minuto,
                        Quantidade = 1
                    });
                }

                // Registra gols detalhados para time visitante
                for (int i = 0; i < golsVisitante; i++)
                {
                    if (!jogadoresVisitante.Any()) break;
                    var jogador = jogadoresVisitante[rand.Next(jogadoresVisitante.Count)];
                    int minuto = rand.Next(1, 91);
                    db.Gols.Add(new Gol
                    {
                        PartidaId = p.Id,
                        JogadorId = jogador.Id,
                        Minuto = minuto,
                        Quantidade = 1
                    });
                }

                // Atualiza contadores na partida
                p.GolsCasa = golsCasa;
                p.GolsVisitante = golsVisitante;
                db.Entry(p).State = EntityState.Modified;
            }

            db.SaveChanges();

            TempData["Success"] = "Simulação concluída com sucesso com gols detalhados!";
            return RedirectToAction("Index", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
