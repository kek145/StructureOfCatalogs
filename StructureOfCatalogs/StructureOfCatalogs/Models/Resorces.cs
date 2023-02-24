using System.Collections.Generic;

namespace StructureOfCatalogs.Models
{
    public class Resources
    {
        public int ResourcesID { get; set; }
        public string? Name { get; set; }
        public int CreatingDigitalImagesId { get; set; }
        public CreatingDigitalImages? CreatingDigitalImages { get; set; }
        public List<PrimarySources> PrimarySources { get; set; } = new();
        public List<SecondarySources> SecondarySources { get; set; } = new();
    }
}
