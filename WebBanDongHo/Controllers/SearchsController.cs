using Microsoft.AspNetCore.Mvc;
using WebBanDongHo.Model;

namespace WebBanDongHo.Controllers
{
    public class SearchsController : Controller
    {
        private readonly dbMarketsContext _context;
        public SearchsController(dbMarketsContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Search(string searchTerm)
        {
            var products = _context.Products
                .Where(p => p.ProductName.Contains(searchTerm))
                .ToList();

            return View(products);
        }
    }
}
