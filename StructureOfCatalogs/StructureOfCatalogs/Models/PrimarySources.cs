namespace StructureOfCatalogs.Models
{
    public class PrimarySources
    {
        public int PrimarySourcesID { get; set; }
        public string? Name { get; set; }
        public int ResourcesId { get; set; }
        public Resources? Resources { get; set; }
    }
}
