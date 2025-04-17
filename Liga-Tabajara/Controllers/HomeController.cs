using System.Linq;
using System.Web.Mvc;
using Liga_Tabajara.Data; // Certifique-se de que o namespace está correto
namespace Liga_Tabajara.Controllers
{
    public class HomeController : Controller
    {
        private LigaContext db = new LigaContext();

        public ActionResult Index()
        {
            var times = db.Times.ToList();
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
