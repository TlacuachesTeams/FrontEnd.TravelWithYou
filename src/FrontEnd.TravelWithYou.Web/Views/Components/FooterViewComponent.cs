using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FrontEnd.Web.Views.Components
{
    public class FooterViewComponent: ViewComponent
    {
        public FooterViewComponent() { 
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View());
        }

    }
}
