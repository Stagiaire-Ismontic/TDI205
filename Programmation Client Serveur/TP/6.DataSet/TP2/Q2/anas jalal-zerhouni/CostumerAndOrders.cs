using System;

namespace Tp2_datase
{

    partial class CostumerAndOrders
    {
        partial class costumersDataTable
        {

        }

        public partial class costumersRow
        {
            public override string ToString()
            {
                return this.NomEtPrenom;
            }
        }
    }
}

namespace Tp2_datase.CostumerAndOrdersTableAdapters
{
    partial class costumersTableAdapter
    {
    }

    public partial class ordersTableAdapter {
    }
}
