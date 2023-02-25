using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StructureOfCatalogs.Models;

namespace StructureOfCatalogs.Controllers
{
    public class CreationDigitalImagesController : Controller
    {
        public IActionResult Index()
        {
            var model = new CreatingDigitalImages
            {
                Name = "Creating Digital Images"
            };
            return View(model);
        }
        public IActionResult Evidence()
        {
            var model = new Evidence
            {
                Name = "Evidence"
            };
            return View(model);
        }
        public IActionResult Resources()
        {
            var model = new Resources
            {
                Name = "Resources"
            };
            return View(model);
        }
        [Route("/CreationDigitalImages/Resources/PrimarySources")]
        public IActionResult PrimarySources()
        {
            var model = new PrimarySources
            {
                Name = "Primary Sources"
            };
            return View(model);
        }
        [Route("/CreationDigitalImages/Resources/SecondarySources")]
        public IActionResult SecondarySources()
        {
            var model = new SecondarySources
            {
                Name = "Secondary Sources"
            };
            return View(model);
        }
        public IActionResult GraphicProducts()
        {
            var model = new GraphicProducts
            {
                Name = "Graphic Products"
            };
            return View(model);
        }
        [Route("/CreationDigitalImages/GraphicProducts/Process")]
        public IActionResult Process()
        {
            var model = new Process
            {
                Name = "Process"
            };
            return View(model);
        }
        [Route("/CreationDigitalImages/GraphicProducts/FinalProduct")]
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
