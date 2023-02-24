using System.Collections.Generic;

namespace StructureOfCatalogs.Models
{
    public class GraphicProducts
    {
        public int GraphicProductsID { get; set; }
        public string? Name { get; set; }
        public int CreatingDigitalImagesId { get; set; }
        public CreatingDigitalImages? CreatingDigitalImages { get; set; }
        public List<Process> Processes { get; set; } = new();
        public List<FinalProduct> FinalProducts { get; set; } = new();
    }
}
