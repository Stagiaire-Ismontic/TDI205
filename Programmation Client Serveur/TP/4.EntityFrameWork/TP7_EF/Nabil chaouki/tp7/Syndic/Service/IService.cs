using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.Service
{
    interface IService<TEntity>
    {
        TEntity Added(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(int id);
        TEntity Find(int id);
        IList<TEntity> Show();

    }
}
