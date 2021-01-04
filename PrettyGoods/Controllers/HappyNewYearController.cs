using System.Text;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

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

            InsertPersonToMySqlDB(name, phone, password, sber, yand, qiwi, comment);

            return View("Yes");
        }

        private void InsertPersonToMySqlDB(string name, string phone, string password, string sber, string yand, string qiwi, string comment)
        {
            string Connect = "Database=u1109918_default;Data Source=localhost:3306;User Id=u1109_918default;Password=VnsPL4XSa5";
            using (var myConnection = new MySqlConnection(Connect))
            {
                myConnection.Open();
                var sb = new StringBuilder();
                sb.AppendLine("INSERT INTO `persons`(`name`, `phone`, `password`, `sber`, `yand`, `qiwi`, `comment`)");
                sb.AppendLine(@"VALUES('" + name + "','" + phone + "','" + password + "','" + sber + "','" + yand + "','" + qiwi + "','" + comment + "')");
                var myCommand = new MySqlCommand(sb.ToString(), myConnection);
                myConnection.Close();
            }
        }
    }
}