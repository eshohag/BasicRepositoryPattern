using BasicRepositoryPattern.Models;
using System.Web.Mvc;

namespace BasicRepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var student = new Student();
            student.FirstName = "Mr Jon";
            student.LastName = "Doe";
            student.DeptName = "CSE";

            var fullName = student.GetFullName();


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