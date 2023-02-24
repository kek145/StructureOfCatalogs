using System.Collections.Generic;

namespace StructureOfCatalogs.Models
{
    public class CreatingDigitalImages
    {
        public int CreatingDigitalImagesID { get; set; }
        public string? Name { get; set; }
        public List<Resources> Resorces { get; set; } = new();
        public List<Evidence> Evidence { get; set; } = new();
        public List<GraphicProducts> GraphicProducts { get; set; } = new();
    }
}
