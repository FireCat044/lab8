using lab8.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab8.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "IPhone", Price = 1000f, CreatedDate = DateTime.Now.AddDays(-5) },
                new Product { ID = 2, Name = "MacBook", Price = 2000f, CreatedDate = DateTime.Now.AddDays(-7) },
                new Product { ID = 3, Name = "IMac", Price = 2500f, CreatedDate = DateTime.Now }
            };

            return View(products);
        }
    }
}
