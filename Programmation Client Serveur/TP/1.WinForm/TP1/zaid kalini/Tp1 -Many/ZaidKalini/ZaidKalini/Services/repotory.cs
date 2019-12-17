using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidKalini.Services
{
    interface repotory<T>
    {
        T Added(T E);
        T Update(T E);
        T Delete(int id);
        T Find(int id);
        IList<T> Show();
    }
}
