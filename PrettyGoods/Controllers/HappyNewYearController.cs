using System.Web.Mvc;

namespace PrettyGoods.Controllers
{
    public class HappyNewYearController : Controller
    {
        public ActionResult Main()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reg()
        {
            var name = HttpContext.Request.Form["name"];
            var phone = HttpContext.Request.Form["phone"];
            var password = HttpContext.Request.Form["password"];
            var sber = HttpContext.Request.Form["sber"];
            var yand = HttpContext.Request.Form["yand"];
            var qiwi = HttpContext.Request.Form["qiwi"];
            var comment = HttpContext.Request.Form["comment"];

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                return View("Main");
            }

            return View("Yes");
        }
    }
}