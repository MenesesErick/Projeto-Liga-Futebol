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
        public ActionResult Index(DateTime? data, int? timeId)
        {
            var partidas = db.Partidas
                .Include(p => p.TimeCasa)
                .Include(p => p.TimeVisitante)
                .AsQueryable();

            // Filtros: data e time
            if (data.HasValue)
            {
                var dia = data.Value.Date;
                partidas = partidas.Where(p => DbFunctions.TruncateTime(p.DataHora) == dia);
            }
            if (timeId.HasValue)
            {
                partidas = partidas.Where(p => p.TimeCasaId == timeId.Value || p.TimeVisitanteId == timeId.Value);
            }

            ViewBag.DataFiltro = data?.ToString("yyyy-MM-dd");
            ViewBag.Times = new SelectList(db.Times, "Id", "Nome", timeId);
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
                .Include(p => p.Gols)
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
                return View(partida);
            }

            if (!PartidaValida(partida))
            {
                ModelState.AddModelError("", "Partida inválida: mandante e visitante distintos; cada time só pode jogar uma vez na mesma data.");
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

            // Bloqueia exclusão se houver gols lançados
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
            // mandante != visitante
            if (partida.TimeCasaId == partida.TimeVisitanteId)
                return false;

            // conflito de data: cada team só uma partida por dia
            var data = DbFunctions.TruncateTime(partida.DataHora);
            bool conflito = db.Partidas.Any(p => p.Id != partida.Id
                && DbFunctions.TruncateTime(p.DataHora) == data
                && (p.TimeCasaId == partida.TimeCasaId || p.TimeVisitanteId == partida.TimeCasaId
                    || p.TimeCasaId == partida.TimeVisitanteId || p.TimeVisitanteId == partida.TimeVisitanteId));
            if (conflito)
                return false;

            return true;
        }

        #endregion
    }
}
