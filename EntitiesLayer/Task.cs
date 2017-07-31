using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedFinishDate { get; set; }
        public DateTime ActualFinishDate { get; set; }
        public int Priority { get; set; }
        public int StatusID { get; set; }
        public virtual Status Status { get; set; }
        public int AssignedEmployeeID { get; set; }
        public virtual Employee AssignedEmployee { get; set; }
        public int TypeID { get; set; }
        public virtual Type Type { get; set; }
        public int CreatedByEmployeeID { get; set; }
        public virtual Employee CreatedByEmployee { get;set; }
        public int LastUpdatedEmployeeID { get; set; }
        public virtual Employee LastUpdatedEmployee { get; set; }
        public DateTime LastUpdatedTime { get; set; }

    }
}
