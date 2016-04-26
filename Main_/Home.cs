using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBASSIST.gsbassistanceDataSetTableAdapters;

namespace GSBASSIST
{
    public partial class Home : Form
    {
        private string id_tech;
      

        public Home(string id,string role)
        {
            InitializeComponent();
            Label_Tech.Text = id;
            Label_Role.Text = role;

            id_tech = id;
            
            //COmpter le nombre de Materiel
            Label_Stat_Equip_Count.Text = equipementTableAdapter.ScalarQuery().ToString();
            //Compter le nombre d'utilisateur
            Label_Stat_User_Count.Text = incidentTableAdapter.ScalarQuery().ToString();
            Label_Stat_Ass_Count.Text = utilisateurTableAdapter.ScalarQuery1().ToString();

           

        }

    
        private void Home_Load(object sender, EventArgs e)
        {

            this.incidentTableAdapter1.FillIncident(this.gsbassistanceDataSet1.incident);
            incidentTableAdapter1.Connection.Close();
            this.incidentTableAdapter2.Fillincidentencours(this.gsbassistanceDataSet2.incident);
            incidentTableAdapter2.Connection.Close();
            this.incidentTableAdapter.Fillincidentnow(this.gsbassistanceDataSet.incident);
            incidentTableAdapter.Connection.Close();
            this.equipementTableAdapter.Fill(this.gsbassistanceDataSet.equipement);
            equipementTableAdapter.Connection.Close();
            

        }

        private void Button_Parc_Add_Mat_Click(object sender, EventArgs e)
        {
            Add_Equip Button_Add = new Add_Equip();
            Button_Add.Show();
        }

        private void Button_User_Add_Click(object sender, EventArgs e)
        {
            Add_User Button_Add = new Add_User();
            Button_Add.Show();
        }

        private void Button_Parc_Add_Comp_Click(object sender, EventArgs e)
        {
            Add_Materiel Button_Add = new Add_Materiel();
            Button_Add.Show();
        }

        private void Button_Materiel_New_Click(object sender, EventArgs e)
        {
            Add_Equip Button_Add = new Add_Equip();
            Button_Add.Show();
        }

        private void Button_Ticket_Add_Click(object sender, EventArgs e)
        {


            Add_Ticket Button_Add = new Add_Ticket();
            Button_Add.Show();
        }

        private void Button_User_Modsupr_Click(object sender, EventArgs e)
        {
            List_User Button_Add = new List_User();
            Button_Add.Show();
        }

        private void Button_Panel_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Stat_Equip_Count_Click(object sender, EventArgs e)
        {

        }

        private void Button_Home_Refresh_Click(object sender, EventArgs e)
        {
            this.incidentTableAdapter1.FillIncident(this.gsbassistanceDataSet1.incident);
            this.incidentTableAdapter2.Fillincidentencours(this.gsbassistanceDataSet2.incident);
            this.incidentTableAdapter.Fillincidentnow(this.gsbassistanceDataSet.incident);

           

        }

        private void Button_Incident_Refresh_Click(object sender, EventArgs e)
        {
            this.incidentTableAdapter1.FillIncident(this.gsbassistanceDataSet1.incident);
            this.incidentTableAdapter2.Fillincidentencours(this.gsbassistanceDataSet2.incident);
            this.incidentTableAdapter.Fillincidentnow(this.gsbassistanceDataSet.incident);
            
        }

        private void Button_Materiel_Refresh_Click(object sender, EventArgs e)
        {
            this.equipementTableAdapter.Fill(this.gsbassistanceDataSet.equipement);
            
        }

        private void Datagrid_Assist_Now_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = Datagrid_Assist_Now.CurrentCell.RowIndex;
            string id_ticket = Datagrid_Assist_Demande.Rows[i].Cells[0].Value.ToString();
            Incident Button_Add = new Incident(id_ticket, id_tech);
            Button_Add.Show();
            incidentTableAdapter.Connection.Close();
        }

        private void Datagrid_Assist_Demande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Datagrid_Assist_Demande.CurrentCell.RowIndex;
            string id_ticket = Datagrid_Assist_Demande.Rows[i].Cells[0].Value.ToString();
            Incident Button_Add = new Incident(id_ticket,id_tech);
            Button_Add.Show();
            incidentTableAdapter.Connection.Close();
        }
    }
}
