using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }
    }
}
