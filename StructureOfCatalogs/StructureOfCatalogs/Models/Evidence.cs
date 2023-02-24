namespace StructureOfCatalogs.Models
{
    public class Evidence
    {
        public int EvidenceID { get; set; }
        public string? Name { get; set; }
        public int CreatingDigitalImagesId { get; set; }
        public CreatingDigitalImages? CreatingDigitalImages { get; set; }
    }
}
