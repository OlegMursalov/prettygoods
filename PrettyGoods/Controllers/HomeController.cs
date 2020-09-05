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
                Title = "Какой первый трэк опубликовал oleg mursalov в группе?",
                RightAnswer = 2,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "тверкай сзади, детка, делай биги-бау" },
                    { 2, "зигану лишь только перед гретой тунберг" },
                    { 3, "исповедь делбика под спизженный бит" },
                    { 4, "WARFACE" },
                    { 5, "CS:GO" }
                }
            },
            new Question
            {
                Id = 2,
                Title = "Что иногда пьёт oleg, а затем корит себя за это?",
                RightAnswer = 3,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "водку" },
                    { 2, "воду" },
                    { 3, "энэргос" },
                    { 4, "молоко" },
                    { 5, "кофе" }
                }
            },
            new Question
            {
                Id = 3,
                Title = "Какая книга повлияла на olega так, что он записал клип на кладбище с костлявыми посылами?",
                RightAnswer = 5,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "Мартин Иден, Джек Лондон" },
                    { 2, "Долбля в ass, Джек Керуак" },
                    { 3, "Смерть за веру, 2018 года" },
                    { 4, "Пролетая над гнедом Кукушки" },
                    { 5, "Искусство оскорблять, Невзоров" }
                }
            },
            new Question
            {
                Id = 4,
                Title = "Самый старый трек, который был записан olegom?",
                RightAnswer = 4,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "Wake up" },
                    { 2, "совместно о всяком" },
                    { 3, "Украинская тема" },
                    { 4, "конец немного предсказуем" },
                    { 5, "WARFACE" }
                }
            },
            new Question
            {
                Id = 5,
                Title = "Какое минимальное кол-во денег разыгрывал oleg в рублях?",
                RightAnswer = 1,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "1" },
                    { 2, "100" },
                    { 3, "500" },
                    { 4, "50" },
                    { 5, "300" }
                }
            },
            new Question
            {
                Id = 6,
                Title = "Сколько трэков в релизе ONLY LOVE oleg'а mursalov'а?",
                RightAnswer = 5,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "10" },
                    { 2, "16" },
                    { 3, "11" },
                    { 4, "13" },
                    { 5, "12" }
                }
            },
            new Question
            {
                Id = 7,
                Title = "Что oleg mursalov никогда не предлагал подписчикам группы (или не подписчикам) до сего дня?",
                RightAnswer = 4,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "фитануть с ним" },
                    { 2, "поучавствовать в его розыгрыше" },
                    { 3, "подписаться на группу" },
                    { 4, "удалить комментарий" },
                    { 5, "поставить лайк" }
                }
            },
            new Question
            {
                Id = 8,
                Title = "Клип 'oleg mursalov - костлявайа тематика (prod by Невзоров), черновайа версийа' был снят на...",
                RightAnswer = 2,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "казанском кладбище, москва" },
                    { 2, "Всехсвятское кладбище (Тула)" },
                    { 3, "ПИТЕР, кладбище разводных мостов" },
                    { 4, "Кладбище 'Дружинское', Омск" },
                    { 5, "Кладбище старых развратников, москва" }
                }
            },
            new Question
            {
                Id = 9,
                Title = "Какие строчки НЕ читал oleg mursalov в своих треках?",
                RightAnswer = 3,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "я сплёвывал сперму как Эдик Лимонов" },
                    { 2, "Себя вспоминаю не особо грызущим гранит" },
                    { 3, "почему мне не везёт, будто таракану" },
                    { 4, "бахали петарды после школы, нынче я Петраде респектую" },
                    { 5, "Простите за мат, уебки, ой" }
                }
            },
            new Question
            {
                Id = 10,
                Title = "Чего oleg mursalov не делал/не имел?",
                RightAnswer = 4,
                AllAswers = new Dictionary<int, string>
                {
                    { 1, "фит с Тем Самым Колей" },
                    { 2, "секс с мулаткой" },
                    { 3, "мастурбация" },
                    { 4, "фит с Young Bargnerd" },
                    { 5, "секс втроём" }
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