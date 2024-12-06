using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = context.Contacts.ToList();

            return View(value);
        }
    }
}
