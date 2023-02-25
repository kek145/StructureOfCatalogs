using System.Linq;
using StructureOfCatalogs.Models.Data;

namespace StructureOfCatalogs.Models
{
    public static class ClassWriteInTables
    {
        private static void WriteValueInTable()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                CreatingDigitalImages images0 = new CreatingDigitalImages { Name = "Resources" };
                CreatingDigitalImages images1 = new CreatingDigitalImages { Name = "Evidence" };
                CreatingDigitalImages images2 = new CreatingDigitalImages { Name = "GraphicProducts" };


                Resources resources0 = new Resources { Name = "PrimarySources", CreatingDigitalImages = images0 };
                Resources resources1 = new Resources { Name = "SecondarySources", CreatingDigitalImages = images0 };

                GraphicProducts products0 = new GraphicProducts { Name = "Process", CreatingDigitalImages = images2 };
                GraphicProducts products1 = new GraphicProducts { Name = "FinalProduct", CreatingDigitalImages = images2 };

                db.AddRange(images0, images1, images2);
                db.AddRange(resources0, resources1);
                db.AddRange(products0, products1);
                db.SaveChanges();
            }
        }

        public static void GetStatusDuplicateInTable()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                var duplicateCheck = db.CreatingDigitalImages.FirstOrDefault(value => value.Name == "Resources" || value.Name == "Evidence" || value.Name == "Graphic Products");

                if (duplicateCheck == null)
                {
                    WriteValueInTable();
                }
                else
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
