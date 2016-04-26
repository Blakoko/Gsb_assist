using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GSBASSIST.gsbassistanceDataSet4TableAdapters;
using GSBASSIST.gsbassistanceDataSet2TableAdapters;

namespace GSBASSIST
{
    public partial class Incident : Form
    {
        private string id_incident;
        private string id_tech;
        private string id_equip;
        private string statut;
        private int statt;

        public Incident(string id,string tech)
        {

            InitializeComponent();
            //Recuperation de l'id pour l'Afficher.
            id_incident = id;
            Label_Incident_Ticket.Text = id;
            //
            Label_Incident_Equipement.Text = id_equip;
            //
            id_tech = tech;
            //
            Label_Incident_Statut.Text = statut;
            //
            Button_Incident_Resolution.Visible = false;
            Groupbox_Resolution.Visible = false;
            if (Label_Incident_Ticket.Text == "En cours")
            {
                Groupbox_Resolution.Visible = true;
                Button_Incident_Resolution.Visible = true;
            }


        }

        private void Incident_Load(object sender, EventArgs e)
        {


          gsbassistanceDataSet2TableAdapters.equipementTableAdapter equip = new gsbassistanceDataSet2TableAdapters.equipementTableAdapter();
            //Instanciation du TableAdapter 
            gsbassistanceDataSet4TableAdapters.incidentTableAdapter incident = new gsbassistanceDataSet4TableAdapters.incidentTableAdapter();
            //
            int lid = Int32.Parse(id_incident);
            DataTable tablO = incident.getincident(lid);

           

            //Remplissage des Champs
            foreach (DataRow dr in tablO.Rows)
            {

                

                //Ticket
                Label_Incident_Statut.Text = dr["STATUT"].ToString();
                Label_Incident_Niveau.Text = dr["NIVEAU"].ToString();
                //Dates
                Label_Incident_Demande.Text = dr["DEMANDE"].ToString();
                Label_Incident_Date.Text = dr["PRISE"].ToString();
                //Technicien
                Textbox_Incident_Comm.Text = dr["COMM"].ToString();
                //Objet
                Label_Incident_Objet.Text = dr["OBJET"].ToString();
                Textbox_Incident_Mess.Text = dr["MESSAGE"].ToString();
                //Resolution
                Textbox_Incident_Solution.Text = dr["SOLUTION"].ToString();
                Label_Incident_Date.Text = dr["RESOLU"].ToString();


                //
                Label_Incident_Equipement.Text = dr["EQUIPEMENT"].ToString();

                
                return;

                //foreach (DataRow dr1 in tabl1.Rows)
                //{
                       
                   


                //}


            }



            incident.Connection.Close();







           

        }

        private
            void Button_Incident_Prise_Click(object sender, EventArgs e)
        {
            
            
            int _equip = Convert.ToInt32(id_equip);
            Label_Incident_Equipement.Text = "oooooooooooooooooooooo";
            incidentTableAdapter.Upincident(3,DateTime.Now,_equip);

           this.Refresh();
            incidentTableAdapter.Connection.Close();
            

        }

        private void Button_Incident_Modif_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Incident_Resolution_Click(object sender, EventArgs e)
        {
            Resolution Button_Add = new Resolution(id_incident,id_tech);
            Button_Add.Show();
        }

    }
}
