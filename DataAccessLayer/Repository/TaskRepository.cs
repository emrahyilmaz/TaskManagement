using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TaskRepository:BaseRepository<EntitiesLayer.Task>
    {
        public TaskRepository(ManagementContext dbContext) :base(dbContext)
        {
        }
    }
}
