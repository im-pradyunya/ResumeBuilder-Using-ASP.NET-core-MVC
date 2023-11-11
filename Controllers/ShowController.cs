using Microsoft.AspNetCore.Mvc;

namespace register.Controllers
{
    public class ShowController : Controller
    {
        public IActionResult ShowResume()
        {
            return View();
        }
        public ActionResult printResume()
        {
            var report = new Rotativa.AspNetCore.ViewAsPdf("ShowResume");
            return report;
        }

    }
}
