using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Category
    {
        public Category()
        {
            DateCreated = DateTime.Now;
        }

        private int categoryId;
        private string name;
        private DateTime? dateCreated;
        private DateTime? dateUpdated;        
      

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime? DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime? DateUpdated { get => dateUpdated; set => dateUpdated = value; }


        public virtual List<Gadget> Gadgets { get; set; }

        
    }
}
