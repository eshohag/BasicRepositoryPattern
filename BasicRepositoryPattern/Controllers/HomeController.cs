using BasicRepositoryPattern.BL;
using System.Web.Mvc;

namespace BasicRepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentManager studentManager = new StudentManager();
            var students = studentManager.GetAll();

            return View(students);
        }
        public ActionResult GetById()
        {
            ViewBag.Message = "Your application description page.";

            return View();
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
    }
}