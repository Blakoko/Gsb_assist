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
    public partial class Add_Materiel : Form
    {
        public Add_Materiel()
        {
            InitializeComponent();
        }

        //Chargement DES Tables Pour L'insertion

        //FOurnisseur
        gsbassistanceDataSetTableAdapters.fournisseurTableAdapter
        fournisseurTableAdapter = new gsbassistanceDataSetTableAdapters.fournisseurTableAdapter();

        //Stockage
        gsbassistanceDataSetTableAdapters.stockageTableAdapter
        stockageTableAdapter = new gsbassistanceDataSetTableAdapters.stockageTableAdapter();

        //Ram
        gsbassistanceDataSetTableAdapters.ramTableAdapter
        ramTableAdapter = new gsbassistanceDataSetTableAdapters.ramTableAdapter();

        //Processeur
        gsbassistanceDataSetTableAdapters.processeurTableAdapter
        processeurTableAdapter = new gsbassistanceDataSetTableAdapters.processeurTableAdapter();

        //type
        gsbassistanceDataSetTableAdapters.typeequipementTableAdapter
        typeequipementTableAdapter = new gsbassistanceDataSetTableAdapters.typeequipementTableAdapter();

        //Logiciel
        gsbassistanceDataSetTableAdapters.logicielTableAdapter
        logicielTableAdapter = new gsbassistanceDataSetTableAdapters.logicielTableAdapter();

        //Marque
        gsbassistanceDataSetTableAdapters.marqueTableAdapter
         marqueTableAdapter = new gsbassistanceDataSetTableAdapters.marqueTableAdapter();


        ///FIN


        private void Button_Add_Fournisseur_Click(object sender, EventArgs e)
        {

            fournisseurTableAdapter.Insert(Texbox_Add_Fourniseur_Adr.Text,Texbox_Add_Fourniseur_Mail.Text,Texbox_Add_Fourniseur_Nom.Text,Texbox_Add_Fourniseur_Phone.Text);

        }

        private void Button_Add_Stockage_Click(object sender, EventArgs e)
        {
            stockageTableAdapter.Insert(Texbox_Add_Stockage_Size.Text, Texbox_Add_Stockage_Type.Text);
        }

        private void Button_Add_Ram_Click(object sender, EventArgs e)
        {
            ramTableAdapter.Insert(Texbox_Add_Ram_Size.Text, Texbox_Add_Ram_Type.Text);
        }

        private void Button_Add_Processeur_Click(object sender, EventArgs e)
        {
            processeurTableAdapter.Insert(Texbox_Add_Processeur_Core.Text, Texbox_Add_Processeur_Nom.Text,Texbox_Add_Processeur_Vit.Text);
        }

        private void Button_Add_Type_Click(object sender, EventArgs e)
        {
            typeequipementTableAdapter.Insert(Texbox_Add_Type_Nom.Text);
        }

        private void Button_Add_Logiciel_Click(object sender, EventArgs e)
        {
            logicielTableAdapter.Insert(Texbox_Add_Logiciel_Nom.Text, Texbox_Add_Logiciel_Editeur.Text,Texbox_Add_Logiciel_Licence.Text);
        }

        private void Button_Add_Marque_Click(object sender, EventArgs e)
        {
            marqueTableAdapter.Insert(Texbox_Add_Marque_Nom.Text);
        }
    }
}
