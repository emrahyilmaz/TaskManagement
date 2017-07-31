using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
   public class Project
    {
       public Project()
       {
           Tasks = new List<Task>();
       }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedStart { get; set; }
        public DateTime EstimatedFinish { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualFinish { get; set; }
        public bool Closed { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
