using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class TimesController : Controller
    {
        private readonly LigaContext db = new LigaContext();

        // GET: Times
        public ActionResult Index()
        {
            // inclui jogadores e comissão
            var times = db.Times
                .Include(t => t.Jogadores)
                .Include(t => t.Comissao)
                .ToList();

            // informa na View se a liga está apta para iniciar
            ViewBag.LigaApta = VerificarLigaApta(times);
            return View(times);
        }

        // GET: Times/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var time = db.Times
                .Include(t => t.Jogadores)
                .Include(t => t.Comissao)
                .FirstOrDefault(t => t.Id == id);

            if (time == null)
                return HttpNotFound();

            return View(time);
        }

        // GET: Times/Create
        public ActionResult Create() => View();

        // POST: Times/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
            "Id,Nome,Cidade,Estado,AnoFundacao,Estadio,CapacidadeEstadio,CorUniformePrincipal,CorUniformeSecundario,Status")] Time time)
        {
            if (!ModelState.IsValid)
                return View(time);

            if (!TimeApto(time))
            {
                ModelState.AddModelError("",
                  "Time não atende aos requisitos: mínimo 30 jogadores, 5 cargos distintos na comissão e campos obrigatórios.");
                return View(time);
            }

            db.Times.Add(time);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Times/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var time = db.Times.Find(id);
            if (time == null)
                return HttpNotFound();

            return View(time);
        }

        // POST: Times/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include =
            "Id,Nome,Cidade,Estado,AnoFundacao,Estadio,CapacidadeEstadio,CorUniformePrincipal,CorUniformeSecundario,Status")] Time time)
        {
            if (!ModelState.IsValid)
                return View(time);

            if (!TimeApto(time))
            {
                ModelState.AddModelError("",
                  "Time não atende aos requisitos: mínimo 30 jogadores, 5 cargos distintos na comissão e campos obrigatórios.");
                return View(time);
            }

            db.Entry(time).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Times/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var time = db.Times.Find(id);
            if (time == null)
                return HttpNotFound();

            // impede exclusão se já tiver partidas agendadas/registradas
            bool temPartidas = db.Partidas.Any(p =>
                p.TimeCasaId == time.Id || p.TimeVisitanteId == time.Id);

            if (temPartidas)
            {
                ViewBag.Erro = "Não é possível excluir time que já participou de partidas.";
            }

            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var time = db.Times.Find(id);

            bool temPartidas = db.Partidas.Any(p =>
                p.TimeCasaId == time.Id || p.TimeVisitanteId == time.Id);

            if (temPartidas)
            {
                ModelState.AddModelError("",
                  "Não é possível excluir time que já participou de partidas.");
                return View(time);
            }

            db.Times.Remove(time);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }

        #region Métodos privados de validação

        private bool TimeApto(Time time)
        {
            // carrega coleções para a validação
            db.Entry(time).Collection(t => t.Jogadores).Load();
            db.Entry(time).Collection(t => t.Comissao).Load();

            // 1) mínimo de 30 jogadores
            bool temJogadores = time.Jogadores.Count >= 30;

            // 2) comissão com 5 cargos distintos
            bool temComissao = time.Comissao
                .Select(c => c.Cargo)
                .Distinct()
                .Count() >= 5;

            // 3) campos obrigatórios (ModelState já checa [Required], mas aqui reforçamos)
            bool dadosOk = !string.IsNullOrWhiteSpace(time.Nome)
                       && !string.IsNullOrWhiteSpace(time.Cidade)
                       && !string.IsNullOrWhiteSpace(time.Estadio)
                       && time.AnoFundacao > 1800;

            return temJogadores && temComissao && dadosOk;
        }

        private bool VerificarLigaApta(System.Collections.Generic.List<Time> todosOsTimes)
        {
            // conta apenas os times aptos
            int aptos = todosOsTimes.Count(t => TimeApto(t));
            return aptos == 20;
        }

        #endregion
    }
}
