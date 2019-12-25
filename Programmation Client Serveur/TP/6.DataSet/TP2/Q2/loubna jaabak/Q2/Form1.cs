using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            DataSetEditeur ds = new DataSetEditeur();
            new DataSetEditeurTableAdapters.EditeurTableAdapter().Fill(ds.Editeur);
            new DataSetEditeurTableAdapters.LivreTableAdapter().Fill(ds.Livre);

            bindingSource1.DataSource =ds.Editeur.ToList<DataSetEditeur.EditeurRow>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            combo_livre.DataSource = new DataSetEditeurTableAdapters.LivreTableAdapter().GetData();
            text_Id.DataBindings.Add("Text",bindingSource1,"id");
            text_Nom.DataBindings.Add("Text", bindingSource1, "Nom");
            text_Cat.DataBindings.Add("Text", bindingSource1, "categorie");
            combo_livre.DataBindings.Add("Text", bindingSource1, "id_livre");

        }

        private void button1_Click(object sender, EventArgs e)//Quitter
        {
            this.Close();
        }

        private void but_Debut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void but_Fin_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void but_Suivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void but_Precedent_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }
      
        private void but_Ajouter_Click(object sender, EventArgs e)
        {
            DataSetEditeurTableAdapters.EditeurTableAdapter dd = new DataSetEditeurTableAdapters.EditeurTableAdapter();
            dd.Insert(Convert.ToInt32(text_Id.Text),text_Nom.Text,text_Cat.Text,Convert.ToInt32(combo_livre.SelectedValue));
            this.Actualiser();
        }
       
        private void but_Nouveau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Vider  les champs?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.text_Id.Text = "";
                this.text_Nom.Text = "";
                this.text_Cat.Text = "";
                this.combo_livre.SelectedValue = "";
            }
            
        }

        private void but_Modifier_Click(object sender, EventArgs e)
        {
            DataSetEditeur.EditeurRow data = new DataSetEditeurTableAdapters.EditeurTableAdapter().GetData().FindByid(Convert.ToInt32(text_Id.Text));

            data.Nom =text_Nom.Text;
            data.categorie = text_Cat.Text;
            data.id_livre = (int)combo_livre.SelectedValue;
            new DataSetEditeurTableAdapters.EditeurTableAdapter().Update(data);
            this.Actualiser();
        }

        private void but_Supprimer_Click(object sender, EventArgs e)
        {
            string Message = "Voulez-vous Supprimer cet Editeur??";
            if (MessageBox.Show(Message, "Message de confirmation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DataSetEditeur.EditeurRow s = new DataSetEditeurTableAdapters.EditeurTableAdapter().GetData().FindByid(Convert.ToInt32(text_Id.Text));
                s.Delete();
           
            new DataSetEditeurTableAdapters.EditeurTableAdapter().Update(s);
            this.Actualiser();
        }
        }
    }
}
