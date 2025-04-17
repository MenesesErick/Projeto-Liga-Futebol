using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Liga_Tabajara.Data;

namespace Liga_Tabajara.Controllers
{
    public class JogadoresController : Controller
    {
        private readonly LigaContext db = new LigaContext();

        // GET: Jogadores
        public ActionResult Index(string searchName, Posicao? posicao, PePreferido? pePreferido)
        {
            var jogadores = db.Jogadores.Include(j => j.Time).AsQueryable();

            // Filtros
            if (!string.IsNullOrWhiteSpace(searchName))
                jogadores = jogadores.Where(j => j.Nome.Contains(searchName));
            if (posicao.HasValue)
                jogadores = jogadores.Where(j => j.Posicao == posicao.Value);
            if (pePreferido.HasValue)
                jogadores = jogadores.Where(j => j.PePreferido == pePreferido.Value);

            // Dropdowns para View
            ViewBag.Posicoes = Enum.GetValues(typeof(Posicao))
                                   .Cast<Posicao>()
                                   .Select(p => new SelectListItem { Text = p.ToString(), Value = p.ToString(), Selected = (p == posicao) });
            ViewBag.Pes = Enum.GetValues(typeof(PePreferido))
                                .Cast<PePreferido>()
                                .Select(p => new SelectListItem { Text = p.ToString(), Value = p.ToString(), Selected = (p == pePreferido) });
            ViewBag.SearchName = searchName;

            return View(jogadores.ToList());
        }

        // GET: Jogadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var jogador = db.Jogadores.Find(id);
            if (jogador == null)
                return HttpNotFound();

            return View(jogador);
        }

        // GET: Jogadores/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: Jogadores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DataNascimento,Nacionalidade,Posicao,NumeroCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
                return View(jogador);
            }

            if (!JogadorValido(jogador))
            {
                ModelState.AddModelError("",
                    "Jogador inválido: nome não vazio, data de nascimento menor que hoje, camisa única no time e enums selecionados.");

                ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
                return View(jogador);
            }

            db.Jogadores.Add(jogador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Jogadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var jogador = db.Jogadores.Find(id);
            if (jogador == null)
                return HttpNotFound();

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // POST: Jogadores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DataNascimento,Nacionalidade,Posicao,NumeroCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
                return View(jogador);
            }

            if (!JogadorValido(jogador))
            {
                ModelState.AddModelError("",
                    "Jogador inválido: nome não vazio, data de nascimento menor que hoje, camisa única no time e enums selecionados.");

                ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
                return View(jogador);
            }

            db.Entry(jogador).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Jogadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var jogador = db.Jogadores.Find(id);
            if (jogador == null)
                return HttpNotFound();

            // Bloqueia exclusão se houver gols registrados
            bool temGols = db.Gols.Any(g => g.JogadorId == jogador.Id);
            if (temGols)
                ViewBag.Erro = "Não é possível excluir jogador com gols registrados.";

            return View(jogador);
        }

        // POST: Jogadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var jogador = db.Jogadores.Find(id);
            bool temGols = db.Gols.Any(g => g.JogadorId == jogador.Id);

            if (temGols)
            {
                ModelState.AddModelError("", "Não é possível excluir jogador com gols registrados.");
                return View(jogador);
            }

            db.Jogadores.Remove(jogador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }

        #region Métodos Privados de Validação
        private bool JogadorValido(Jogador jogador)
        {
            // Nome
            if (string.IsNullOrWhiteSpace(jogador.Nome))
                return false;
            // Data de nascimento
            if (jogador.DataNascimento >= DateTime.Today)
                return false;
            // Numeração única por time
            var qtMesmoNumero = db.Jogadores
                .Count(j => j.TimeId == jogador.TimeId && j.NumeroCamisa == jogador.NumeroCamisa && j.Id != jogador.Id);
            if (qtMesmoNumero > 0)
                return false;
            // Enums preenchidos (não dependem de null pois são tipos valor)
            return Enum.IsDefined(typeof(Posicao), jogador.Posicao)
                && Enum.IsDefined(typeof(PePreferido), jogador.PePreferido);
        }
        #endregion
    }
}
