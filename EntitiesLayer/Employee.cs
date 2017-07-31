using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
   public class Employee
    {
       public Employee()
       {
           Tasks = new List<Task>();
       }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public int UserID { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
