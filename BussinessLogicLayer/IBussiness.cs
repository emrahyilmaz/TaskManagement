using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    interface IBussiness<TEntity>
    {
        bool Add(TEntity item);
        bool Update(TEntity item);
        bool Remove(TEntity Remove);
        TEntity Get(int id);
        List<TEntity> GetAll();
    }
}
