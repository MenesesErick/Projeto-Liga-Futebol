using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Liga_Tabajara.Data; // Certifique-se de que o namespace está correto
namespace Liga_Tabajara.Controllers
{
    public class HomeController : Controller
    {
        private LigaContext db = new LigaContext();

        public ActionResult Index()
        {
            var times = db.Times.ToList();
            foreach (var time in times)
            {
                int qtdJog = db.Jogadores.Count(j => j.TimeId == time.Id);
                int qtdCom = db.ComissaoTecnica
                               .Where(c => c.TimeId == time.Id)
                               .Select(c => c.Cargo)
                               .Distinct().Count();

                time.Status = (qtdJog >= 30) && (qtdCom >= 5);
            }

            db.SaveChanges();
            return View(times);
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
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}