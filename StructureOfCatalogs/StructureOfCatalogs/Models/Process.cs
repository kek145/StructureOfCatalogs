namespace StructureOfCatalogs.Models
{
    public class Process
    {
        public int ProcessID { get; set; }
        public string? Name { get; set; }
        public int GraphicProductsId { get; set; }
        public GraphicProducts? GraphicProducts { get; set; }
    }
}
