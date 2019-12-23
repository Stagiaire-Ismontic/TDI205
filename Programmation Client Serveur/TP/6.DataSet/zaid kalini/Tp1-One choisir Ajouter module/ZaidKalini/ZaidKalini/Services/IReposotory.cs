using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidKalini.Services
{
    interface IReposotory<T>
    {
        T Added(T E);
        T Update(T E);
        T Delete(int id);
        T Find(int id);
        List<T> Show();
        int GetId();
    }
}
