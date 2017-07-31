using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Customer>
    {
        public ContactMap()
        {
            //HasOptional(p => p.Customer)
            //     .WithMany(c => c.Products)
            //     .HasForeignKey(p => p.CategoryID);
        }
    }
}
