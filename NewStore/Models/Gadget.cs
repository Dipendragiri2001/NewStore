using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Gadget
    {
        private int gadgetId;
        private string name;
        private string description;
        private decimal price;
        private string image;
        private int categoryId;
        private Category category;
        
       

        
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int GadgetId { get => gadgetId; set => gadgetId = value; }
        public decimal Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public Category Category { get => category; set => category = value; }
    }
}
