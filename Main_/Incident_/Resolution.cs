using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBASSIST
{
    public partial class Resolution : Form
    {
        private string _idtech;
        private string _idresolv;

        public Resolution(string id,string tech)
        {
            InitializeComponent();
            Label_Numero_Ticket.Text = id;
            _idtech = tech;
            _idresolv = id;
        }

        private void Resolution_Load(object sender, EventArgs e)
        {
            //Dataset1
            

            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet4.incident'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.incidentTableAdapter.Fill(this.gsbassistanceDataSet4.incident);

                 gsbassistanceDataSetTableAdapters.incidentTableAdapter
                incidentTableAdapter = new gsbassistanceDataSetTableAdapters.incidentTableAdapter();
        }

        private void Button_Resoudre_Incident_Click(object sender, EventArgs e)
        {
           
            int tech = Convert.ToInt32(_idtech);
            int resolu = Convert.ToInt32(_idresolv);
            DateTime datres = Date_Resolution.Value;
            

            incidentTableAdapter.Updateincident(datres, tech, resolu);

            MessageBox.Show("BRAVO COUILLON");




        }


    }




}
