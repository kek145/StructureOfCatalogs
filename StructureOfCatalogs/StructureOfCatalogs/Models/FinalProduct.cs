namespace StructureOfCatalogs.Models
{
    public class FinalProduct
    {
        public int FinalProductID { get; set; }
        public string? Name { get; set; }
        public int GraphicProductsId { get; set; }
        public GraphicProducts? GraphicProducts { get; set; }
    }
}
