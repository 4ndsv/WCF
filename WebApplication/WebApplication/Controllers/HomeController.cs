using System.Linq;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (var client = new MainService.MainServiceClient())
            {
                var names = client.GetNames("");
                ViewBag.Names = names.ToList();

            }
            return View();
        }
    }
}
