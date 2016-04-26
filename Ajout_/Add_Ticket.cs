using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBASSIST.gsbassistanceDataSet4TableAdapters;

namespace GSBASSIST
{
    public partial class Add_Ticket : Form
    {
        public Add_Ticket()
        {
            InitializeComponent();

           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Ticket_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet4.utilisateur_incident'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateur_incidentTableAdapter.Fill(this.gsbassistanceDataSet4.utilisateur_incident);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet3.equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipementTableAdapter1.Fill(this.gsbassistanceDataSet3.equipement);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.niveau'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.niveauTableAdapter.Fill(this.gsbassistanceDataSet.niveau);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet2.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter1.Fill(this.gsbassistanceDataSet2.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter.Fill(this.gsbassistanceDataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipementTableAdapter.Fill(this.gsbassistanceDataSet.equipement);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.equipementTableAdapter.Fill(this.gsbassistanceDataSet.equipement);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Remove reset = new Remove();

            gsbassistanceDataSet3TableAdapters.incidentTableAdapter incidentTableAdapter =
             new gsbassistanceDataSet3TableAdapters.incidentTableAdapter();
            gsbassistanceDataSet4TableAdapters.logiciel_equipementTableAdapter logiciel_equipementTableAdapter =
                new gsbassistanceDataSet4TableAdapters.logiciel_equipementTableAdapter();
            //
            int equipement = Convert.ToInt32(Combo_Add_Ticket_Equipement.SelectedValue);
            int niveau = Convert.ToInt32(Combo_Add_Ticket_Niveau.SelectedValue);
            int technicien = Convert.ToInt32(Combo_Add_Ticket_Technicien.SelectedValue);

            
            //
           incidentTableAdapter.InsertQuery(Textbox_Add_Ticket_Mess.Text, Textbox_Add_Ticket_Objet.Text,
              Textbox_Add_Ticket_Techcomm.Text, niveau, 1,
              equipement, Date_Add_Ticket_Time.Value,
               technicien);
            incidentTableAdapter.Connection.Close();

            //Prendre LA Derniere Insertion Effectué (Dernier id)
            int incid = Convert.ToInt32(equipementTableAdapter.maxid2()); //GetMAxid est defini dans le dataset
            //
            logiciel_equipementTableAdapter.Insert(technicien,incid);
            logiciel_equipementTableAdapter.Connection.Close();
            //
            MessageBox.Show("Ticket Ajouté", "Réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //
            reset.ResetAll(groupBox1);
            reset.ResetAll(groupBox2); 
            reset.ResetAll(groupBox3);           
        }
    }
}
