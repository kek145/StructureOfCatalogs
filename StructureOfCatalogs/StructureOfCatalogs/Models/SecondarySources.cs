namespace StructureOfCatalogs.Models
{
    public class SecondarySources
    {
        public int SecondarySourcesID { get; set; }
        public string? Name { get; set; }
        public int ResourcesId { get; set; }
        public Resources? Resources { get; set; }
    }
}
