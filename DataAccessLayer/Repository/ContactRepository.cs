using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ContactRepository :BaseRepository<Contact>
    {
        public ContactRepository(ManagementContext dbContext) :base(dbContext)
        {

        }
    }
}
