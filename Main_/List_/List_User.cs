using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBASSIST
{
    public partial class List_User : Form
    {
       

        public List_User()
        {
            InitializeComponent();
        }

        private void List_User_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter.Fill(this.gsbassistanceDataSet.utilisateur);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(gsbassistanceDataSet.utilisateur);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                //if (
                  //  MessageBox.Show("", "Message", MessageBoxButtons.YesNo,
                  //      MessageBoxIcon.Question) ==
                //    DialogResult.Yes)

                try
                {
                    this.Validate();
                    this.utilisateurBindingSource.EndEdit();
                    this.utilisateurTableAdapter.Update(this.gsbassistanceDataSet.utilisateur);
                    MessageBox.Show("Mis A Jour");

                }
                catch (System.Exception)
                {

                    MessageBox.Show("Erreur");


                }
                  
                



                //utilisateurBindingSource.RemoveCurrent();
                //utilisateurTableAdapter.DeleteQuery(e.ColumnIndex);
                //utilisateurTableAdapter.Update(this.gsbassistanceDataSet.utilisateur);

            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(
                MessageBox.Show("Etes vous sur de supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
                

                utilisateurBindingSource.RemoveCurrent();
                utilisateurTableAdapter.DeleteQuery(e.ColumnIndex);
                utilisateurTableAdapter.Update(this.gsbassistanceDataSet.utilisateur);
            }

          utilisateurTableAdapter.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.gsbassistanceDataSet.utilisateur);
            utilisateurTableAdapter.Connection.Close();
        }
    }
}
