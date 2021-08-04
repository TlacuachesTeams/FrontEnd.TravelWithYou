using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FrontEnd.Web.Views.Components
{
    public class NewsletterViewComponent: ViewComponent
    {
        public NewsletterViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(string viewType)
        {
            ViewBag.ViewType = viewType;
            return await Task.FromResult((IViewComponentResult)View(new { ViewType = viewType }));
        }
    }
}
