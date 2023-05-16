using Microsoft.AspNetCore.Mvc;

namespace WebBanDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin",Name="Index")]
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
