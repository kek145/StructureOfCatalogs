using Microsoft.AspNetCore.Mvc;
using StructureOfCatalogs.Models;

namespace StructureOfCatalogs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CreatingDigitalImages
            {
                Name = "Creating Digital Images"
            };
            return View(model);
        }
        [Route("Evidance")]
        public IActionResult Evidance()
        {
            var model = new Evidence
            {
                Name = "Evidance"
            };
            return View(model);
        }
        [Route("Resources")]
        public IActionResult Resources()
        {
            var model = new Resources
            {
                Name = "Resources"
            };
            return View(model);
        }
        [Route("Primary-Sources")]
        public IActionResult PrimarySources()
        {
            var model = new PrimarySources
            {
                Name = "Primary Sources"
            };
            return View(model);
        }
        [Route("Secondary-Sources")]
        public IActionResult SecondarySources()
        {
            var model = new SecondarySources
            {
                Name = "Secondary Sources"
            };
            return View(model);
        }
        [Route("Graphic-Products")]
        public IActionResult GraphicProducts()
        {
            var model = new GraphicProducts
            {
                Name = "Graphic Products"
            };
            return View(model);
        }
        [Route("Process")]
        public IActionResult Process()
        {
            var model = new Process
            {
                Name = "Process"
            };
            return View(model);
        }
        [Route("Final-Product")]
        public IActionResult FinalProduct()
        {
            var model = new FinalProduct
            {
                Name = "Final Product"
            };
            return View(model);
        }

    }
}
