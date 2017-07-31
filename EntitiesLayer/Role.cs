using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Role
    {
        public Role()
        {
            Employees = new List<Employee>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
