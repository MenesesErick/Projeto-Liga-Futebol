using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class ArtilhariaController : Controller
    {
        private readonly LigaContext db = new LigaContext();

        // ViewModel simples para passar os dados à View
        public class ArtilheiroViewModel
        {
            public int JogadorId { get; set; }
            public string Nome { get; set; }
            public int NumeroCamisa { get; set; }
            public string TimeNome { get; set; }
            public int TotalGols { get; set; }
        }

        // GET: /Artilharia/
        public ActionResult Index()
        {
            // Carrega gols com jogador e time, agrupa por jogador e soma Quantidade
            var artilheiros = db.Gols
                .Include(g => g.Jogador)
                .Include(g => g.Jogador.Time)
                .GroupBy(g => new
                {
                    g.JogadorId,
                    g.Jogador.Nome,
                    g.Jogador.NumeroCamisa,
                    TimeNome = g.Jogador.Time.Nome
                })
                .Select(gr => new ArtilheiroViewModel
                {
                    JogadorId = gr.Key.JogadorId,
                    Nome = gr.Key.Nome,
                    NumeroCamisa = gr.Key.NumeroCamisa,
                    TimeNome = gr.Key.TimeNome,
                    TotalGols = gr.Sum(g => g.Quantidade)
                })
                .OrderByDescending(a => a.TotalGols)
                .ThenBy(a => a.Nome)
                .ToList();

            return View(artilheiros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
