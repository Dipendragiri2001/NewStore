using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class StoreSeedData :DropCreateDatabaseIfModelChanges<StoreEntities>
    {
        protected override void Seed(StoreEntities context)
        {
           
        }

        private static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category
                {
                    Name = "Tablets"
                },
                new Category
                {
                    Name = "Laptops"
                },
                new Category
                {
                    Name="Mobiles"
                }
            };
        }

        private static List<Gadget> GetGadgets()
        {
            return new List<Gadget>
            {
                new Gadget
                {
                    Name = "Samsung Tab 3",
                    Description="Android 9 pie,Cortex A8 1.2 GHz Dual Core Processor,512MB / 4GB,Dual Camera,G-Sensor (Black)",
                    CategoryId=1,
                    Price = 50000,
                    Image= "abc.jpg"
                },
                new Gadget
                {
                    Name = "Samsung Galaxy S20",
                    Description = "Android 4.4 Kit Kat OS, 1.2 GHz quad-core processor",
                    CategoryId = 3,
                    Price = 120.95m,
                    Image= "samsung-galaxy.jpg"
                },
                new Gadget
                {
                    Name="Acer Predator Helios 300",
                    Description="Core i7 16GB 512Gb 6GB Gtx 1660Ti",
                    CategoryId=2,
                    Price=150000,
                    Image="xyz.jpg"
                }
            };
        }
    }
}
