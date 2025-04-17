using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class GolsController : Controller
    {
        private LigaContext db = new LigaContext();

        // GET: Gols
        public ActionResult Index()
        {
            var gols = db.Gols.Include(g => g.Jogador).Include(g => g.Partida);
            return View(gols.ToList());
        }

        // GET: Gols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gol gol = db.Gols.Find(id);
            if (gol == null)
            {
                return HttpNotFound();
            }
            return View(gol);
        }

        // GET: Gols/Create
        public ActionResult Create()
        {
            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome");
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Id");
            return View();
        }

        // POST: Gols/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GolId,JogadorId,PartidaId,Minuto,Quantidade")] Gol gol)
        {
            // 1) checar ranges básicos
            if (gol.Minuto < 0 || gol.Minuto > 120)
                ModelState.AddModelError(nameof(gol.Minuto), "Minuto deve estar entre 0 e 120.");
            if (gol.Quantidade <= 0)
                ModelState.AddModelError(nameof(gol.Quantidade), "Quantidade de gols deve ser pelo menos 1.");

            // 2) checar vínculo jogador–time–partida
            var partida = db.Partidas.Find(gol.PartidaId);
            var jogador = db.Jogadores.Find(gol.JogadorId);
            if (partida == null || jogador == null ||
                (jogador.TimeId != partida.TimeCasaId && jogador.TimeId != partida.TimeVisitanteId))
            {
                ModelState.AddModelError("", "O jogador deve pertencer a um dos dois times desta partida.");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome", gol.JogadorId);
                ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Id", gol.PartidaId);
                return View(gol);
            }

            db.Gols.Add(gol);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Gols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gol gol = db.Gols.Find(id);
            if (gol == null)
            {
                return HttpNotFound();
            }
            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome", gol.JogadorId);
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Id", gol.PartidaId);
            return View(gol);
        }

        // POST: Gols/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GolId,JogadorId,PartidaId,Minuto")] Gol gol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JogadorId = new SelectList(db.Jogadores, "Id", "Nome", gol.JogadorId);
            ViewBag.PartidaId = new SelectList(db.Partidas, "Id", "Id", gol.PartidaId);
            return View(gol);
        }

        // GET: Gols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gol gol = db.Gols.Find(id);
            if (gol == null)
            {
                return HttpNotFound();
            }
            return View(gol);
        }

        // POST: Gols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gol gol = db.Gols.Find(id);
            db.Gols.Remove(gol);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
