using System.Collections.Generic;
using System.Web.Mvc;

namespace PrettyGoods.Controllers
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RightAnswer { get; set; }
        public Dictionary<int, string> AllAswers { get; set; }
    }

    public class HomeController : Controller
    {
        public readonly List<Question> allQuestions = new List<Question>
        {
            new Question
            {
                Id = 1,
                Title = "Какой первый трэк опубликовал админчик в группе олега мурсалова?",
                RightAnswer = 2,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "да хз, иди в пень" },
                    { 2, "зигану лишь только перед гретой тунберг" },
                    { 3, "исповедь делбика под спизженный бит" },
                    { 4, "WARFACE" },
                    { 5, "CS:GO" }
                }
            },
            new Question
            {
                Id = 2,
                Title = "Что иногда пьёт админ, а затем корит себя за это?",
                RightAnswer = 3,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "водку" },
                    { 2, "воду" },
                    { 3, "энергос" },
                    { 4, "молоко" },
                    { 5, "кофе" }
                }
            }
        };

        public ActionResult Test()
        {
            return View("Test", allQuestions);
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