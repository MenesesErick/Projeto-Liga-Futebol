using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class PartidasController : Controller
    {
        private readonly LigaContext db = new LigaContext();

        // GET: Partidas
        public ActionResult Index(DateTime? data, int? timeId, string estadio, string jogo)
        {
            var partidas = db.Partidas
                .Include(p => p.TimeCasa)
                .Include(p => p.TimeVisitante)
                .AsQueryable();

            if (data.HasValue)
            {
                var dia = data.Value.Date;
                partidas = partidas.Where(p => DbFunctions.TruncateTime(p.DataHora) == dia);
            }

            if (timeId.HasValue)
            {
                partidas = partidas.Where(p => p.TimeCasaId == timeId.Value || p.TimeVisitanteId == timeId.Value);
            }

            if (!string.IsNullOrEmpty(estadio))
            {
                partidas = partidas.Where(p => p.TimeCasa.Estadio.Contains(estadio));
            }

            if (!string.IsNullOrEmpty(jogo))
            {
                partidas = partidas.Where(p => (p.TimeCasa.Nome + " x " + p.TimeVisitante.Nome).Contains(jogo));
            }

            ViewBag.DataFiltro = data?.ToString("yyyy-MM-dd");
            ViewBag.Times = new SelectList(db.Times, "Id", "Nome", timeId);
            ViewBag.EstadioFiltro = estadio;
            ViewBag.JogoFiltro = jogo;

            return View(partidas.ToList());
        }

        // GET: Partidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var partida = db.Partidas
                .Include(p => p.TimeCasa)
                .Include(p => p.TimeVisitante)
                .Include(p => p.Gols.Select(g => g.Jogador))
                .FirstOrDefault(p => p.Id == id);
            if (partida == null)
                return HttpNotFound();

            return View(partida);
        }

        // GET: Partidas/Create
        public ActionResult Create()
        {
            CarregarViewBags();
            return View();
        }

        // POST: Partidas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DataHora,TimeCasaId,TimeVisitanteId,GolsCasa,GolsVisitante")] Partida partida)
        {
            if (!ModelState.IsValid)
            {
                CarregarViewBags(partida);
                return View(partida);
            }

            if (!PartidaValida(partida))
            {
                ModelState.AddModelError("", "Partida inválida: mandante e visitante distintos; cada time só pode jogar uma vez na mesma data.");
                CarregarViewBags(partida);
                return View(partida);
            }

            db.Partidas.Add(partida);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Partidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var partida = db.Partidas.Find(id);
            if (partida == null)
                return HttpNotFound();

            CarregarViewBags(partida);
            return View(partida);
        }

        // POST: Partidas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DataHora,TimeCasaId,TimeVisitanteId,GolsCasa,GolsVisitante")] Partida partida)
        {
            if (!ModelState.IsValid)
            {
                CarregarViewBags(partida);

                partida.TimeCasa = db.Times.Find(partida.TimeCasaId);
                partida.TimeVisitante = db.Times.Find(partida.TimeVisitanteId);


                return View(partida);
            }
            if (!PartidaValida(partida))
            {
                ModelState.AddModelError("", "Partida inválida...");
                CarregarViewBags(partida);
                return View(partida);
            }

            db.Entry(partida).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Partidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var partida = db.Partidas.Find(id);
            if (partida == null)
                return HttpNotFound();

            bool temGols = db.Gols.Any(g => g.PartidaId == partida.Id);
            if (temGols)
                ViewBag.Erro = "Não é possível excluir partida com gols registrados.";

            return View(partida);
        }

        // POST: Partidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var partida = db.Partidas.Find(id);
            bool temGols = db.Gols.Any(g => g.PartidaId == partida.Id);
            if (temGols)
            {
                ModelState.AddModelError("", "Não é possível excluir partida com gols registrados.");
                return View(partida);
            }

            db.Partidas.Remove(partida);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Partidas/RegistrarPlacar/5
        public ActionResult RegistrarPlacar(int id)
        {
            var partida = db.Partidas
                .Include(p => p.TimeCasa)
                .Include(p => p.TimeVisitante)
                .Include(p => p.Gols.Select(g => g.Jogador))
                .FirstOrDefault(p => p.Id == id);
            if (partida == null) return HttpNotFound();

            CarregarViewBags(partida);
            ViewBag.JogadoresCasa = new SelectList(
                db.Jogadores.Where(j => j.TimeId == partida.TimeCasaId).OrderBy(j => j.Nome),
                "Id", "Nome");
            ViewBag.JogadoresVisitante = new SelectList(
                db.Jogadores.Where(j => j.TimeId == partida.TimeVisitanteId).OrderBy(j => j.Nome),
                "Id", "Nome");

            ViewBag.Sucesso = TempData["Sucesso"];
            ViewBag.Erro = TempData["Erro"];

            return View(partida);
        }

        // POST: Partidas/RegistrarPlacar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarPlacar(int id, FormCollection form)
        {
            var partida = db.Partidas.Find(id);
            if (partida == null)
                return HttpNotFound();

            // Valida rodada anterior...
            var todas = db.Partidas.OrderBy(p => p.DataHora).ToList();
            int idx = todas.FindIndex(p => p.Id == id);
            int rodadaAtual = (idx / 10) + 1;
            if (rodadaAtual > 1)
            {
                var anteriores = todas.Skip((rodadaAtual - 2) * 10).Take(10);
                bool existeSemGols = anteriores.Any(p => !p.GolsCasa.HasValue || !p.GolsVisitante.HasValue);
                if (existeSemGols)
                {
                    TempData["Erro"] = $"Você deve primeiro registrar gols de todas as partidas da rodada {rodadaAtual - 1}.";
                    return RedirectToAction("RegistrarPlacar", new { id });
                }
            }

            db.Gols.RemoveRange(db.Gols.Where(g => g.PartidaId == id));

            int golsCasa = 0;
            var keysCasa = form.AllKeys.Where(k => k.StartsWith("Casa_Jogador_")).OrderBy(k => k);
            foreach (var key in keysCasa)
            {
                if (int.TryParse(form[key], out int jogadorId) &&
                    int.TryParse(form[key.Replace("Jogador", "Minuto")], out int minuto))
                {
                    db.Gols.Add(new Gol { PartidaId = id, JogadorId = jogadorId, Minuto = minuto, Quantidade = 1 });
                    golsCasa++;
                }
            }

            int golsVisitante = 0;
            var keysVisit = form.AllKeys.Where(k => k.StartsWith("Visitante_Jogador_")).OrderBy(k => k);
            foreach (var key in keysVisit)
            {
                if (int.TryParse(form[key], out int jogadorId) &&
                    int.TryParse(form[key.Replace("Jogador", "Minuto")], out int minuto))
                {
                    db.Gols.Add(new Gol { PartidaId = id, JogadorId = jogadorId, Minuto = minuto, Quantidade = 1 });
                    golsVisitante++;
                }
            }

            partida.GolsCasa = golsCasa;
            partida.GolsVisitante = golsVisitante;
            db.Entry(partida).State = EntityState.Modified;
            db.SaveChanges();

            TempData["Sucesso"] = "Gols registrados com sucesso.";
            return RedirectToAction("RegistrarPlacar", new { id });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }

        #region Métodos Privados
        private void CarregarViewBags(Partida partida = null)
        {
            ViewBag.TimeCasaId = new SelectList(db.Times, "Id", "Nome", partida?.TimeCasaId);
            ViewBag.TimeVisitanteId = new SelectList(db.Times, "Id", "Nome", partida?.TimeVisitanteId);
        }

        private bool PartidaValida(Partida partida)
        {
            if (partida.TimeCasaId == partida.TimeVisitanteId)
                return false;

            var data = DbFunctions.TruncateTime(partida.DataHora);
            return !db.Partidas.Any(p => p.Id != partida.Id &&
                DbFunctions.TruncateTime(p.DataHora) == data &&
                (p.TimeCasaId == partida.TimeCasaId || p.TimeVisitanteId == partida.TimeCasaId ||
                 p.TimeCasaId == partida.TimeVisitanteId || p.TimeVisitanteId == partida.TimeVisitanteId));
        }
        #endregion
    }
}
