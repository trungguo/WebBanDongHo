using Microsoft.AspNetCore.Mvc;

namespace WebBanDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("index.html",Name="Index")]
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
