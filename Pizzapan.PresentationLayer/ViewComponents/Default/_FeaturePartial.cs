using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her Gün Pizza Yiyin";
            ViewBag.title2 = "Sevdiğiniz Pizzaları Paylaşın";
            return View();
        }
    }
}
