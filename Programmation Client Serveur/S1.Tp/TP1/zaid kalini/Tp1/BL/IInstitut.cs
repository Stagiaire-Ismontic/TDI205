using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1.BL
{
    interface IInstitut<Tentity>
    {
        void Ajouter(Tentity s);
        void suprimer(int num);
        void update(Tentity entity, int num);
        Tentity rechercher(int num);
    }
}
