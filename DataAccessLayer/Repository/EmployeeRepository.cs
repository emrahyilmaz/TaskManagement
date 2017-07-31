using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository :BaseRepository<Employee>
    {
        public EmployeeRepository(ManagementContext dbContext):base(dbContext)
        {

        }
    }
}
