using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class HomeController : Controller
    {
        private readonly LigaContext db = new LigaContext();

        // Classe interna que representa uma linha da tabela de classificação
        public class ClassificacaoEntry
        {
            public int TimeId { get; set; }
            public string Nome { get; set; }
            public int Jogos { get; set; }
            public int Vitorias { get; set; }
            public int Empates { get; set; }
            public int Derrotas { get; set; }
            public int GolsPro { get; set; }
            public int GolsContra { get; set; }
            public int SaldoGols { get; set; }
            public int Pontos { get; set; }
        }

        public ActionResult Index()
        {
            // --- 1) Atualizar status de aptidão dos times ---
            var times = db.Times.ToList();
            foreach (var time in times)
            {
                int qtdJog = db.Jogadores.Count(j => j.TimeId == time.Id);
                int qtdCom = db.ComissaoTecnica
                               .Where(c => c.TimeId == time.Id)
                               .Select(c => c.Cargo)
                               .Distinct()
                               .Count();
                time.Status = (qtdJog >= 30) && (qtdCom >= 5);
            }
            db.SaveChanges();

            // --- 2) Carregar apenas partidas já disputadas ---
            var partidas = db.Partidas
                             .Where(p => p.GolsCasa.HasValue
                                      && p.GolsVisitante.HasValue)
                             .ToList();

            // --- 3) Montar a tabela de classificação ---
            var tabela = new List<ClassificacaoEntry>();
            foreach (var time in times)
            {
                var cmpCasa = partidas.Where(p => p.TimeCasaId == time.Id);
                var cmpFora = partidas.Where(p => p.TimeVisitanteId == time.Id);

                int vitorias = cmpCasa.Count(p => p.GolsCasa > p.GolsVisitante)
                             + cmpFora.Count(p => p.GolsVisitante > p.GolsCasa);

                int empates = cmpCasa.Count(p => p.GolsCasa == p.GolsVisitante)
                             + cmpFora.Count(p => p.GolsCasa == p.GolsVisitante);

                int derrotas = cmpCasa.Count(p => p.GolsCasa < p.GolsVisitante)
                              + cmpFora.Count(p => p.GolsVisitante < p.GolsCasa);

                int golsPro = cmpCasa.Sum(p => p.GolsCasa.Value)
                                + cmpFora.Sum(p => p.GolsVisitante.Value);
                int golsContra = cmpCasa.Sum(p => p.GolsVisitante.Value)
                                + cmpFora.Sum(p => p.GolsCasa.Value);

                int saldo = golsPro - golsContra;
                int pontos = (vitorias * 3) + (empates * 1);

                tabela.Add(new ClassificacaoEntry
                {
                    TimeId = time.Id,
                    Nome = time.Nome,
                    Jogos = cmpCasa.Count() + cmpFora.Count(),
                    Vitorias = vitorias,
                    Empates = empates,
                    Derrotas = derrotas,
                    GolsPro = golsPro,
                    GolsContra = golsContra,
                    SaldoGols = saldo,
                    Pontos = pontos
                });
            }

            // --- 4) Ordenar por pontos, saldo de gols e vitórias ---
            var classificacao = tabela
                .OrderByDescending(c => c.Pontos)
                .ThenByDescending(c => c.SaldoGols)
                .ThenByDescending(c => c.Vitorias)
                .ToList();

            // --- 5) Retornar classificação como Model para a View ---
            return View(classificacao);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
