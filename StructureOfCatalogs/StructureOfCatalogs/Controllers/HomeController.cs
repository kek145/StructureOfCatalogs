using Microsoft.AspNetCore.Mvc;
using StructureOfCatalogs.Models.Data;

namespace StructureOfCatalogs.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _context;
        public HomeController(ApplicationContext context) => _context = context;
        public IActionResult Index()
        {
            return View();
        }
        public string PrintString()
        {
            return "PrintString";
        }
    }
}
