using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Configuration
{
    class GadgetConfiguration : EntityTypeConfiguration<Gadget>
    {
        public GadgetConfiguration()
        {
            ToTable("Gadget");
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Price).IsRequired().HasPrecision(8, 2);
            Property(x => x.CategoryId).IsRequired();
        }
    }
}
