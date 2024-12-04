using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.Controllers
{
    public class IstatisticController : Controller
    {

        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Portfolios.Count();
            ViewBag.v7 = context.Skills.Average(x => (float)x.Value);
            ViewBag.v8 = context.SocialMedias.Count();
            return View();
        }
    }
}
