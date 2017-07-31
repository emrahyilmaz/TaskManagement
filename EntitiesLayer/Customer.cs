using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
   public class Customer
    {
       public Customer()
       {
           Contacts = new List<Contact>();
           Projects = new List<Project>();
       }
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<Project> Projects { get; set; }
    }
}
