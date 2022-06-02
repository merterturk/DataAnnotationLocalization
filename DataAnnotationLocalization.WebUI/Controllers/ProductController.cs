using DataAnnotationLocalization.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotationLocalization.WebUI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            return View();
        }
    }
}
