namespace WindowsF
{


    public partial class Data
    {
        public partial class ProduitRow
        {
            public override string ToString()
            {
                return this.Nom;
            }
        }
    }
}

namespace WindowsF.DataTableAdapters
{
    partial class SelectDescriptionsJointureTableAdapter
    {
    }

    partial class SelectDescriptionsTableAdapter
    {
    }

    public partial class ProduitTableAdapter {
    }
}
