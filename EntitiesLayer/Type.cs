using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
   public class Type
    {
       public Type()
       {
           Tasks = new List<Task>();
       }
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
