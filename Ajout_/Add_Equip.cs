using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBASSIST.gsbassistanceDataSetTableAdapters;

namespace GSBASSIST
{
    public partial class Add_Equip : Form
    {
        public Add_Equip()
        {
            InitializeComponent();

            
        }

        private void Groupbox_Add_Equip_Logiciel_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Equip_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.logiciel_equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.logiciel_equipementTableAdapter.Fill(this.gsbassistanceDataSet.logiciel_equipement);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet4.equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipementTableAdapter.Fill(this.gsbassistanceDataSet4.equipement);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.incident'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.incidentTableAdapter.Fillincidentnow(this.gsbassistanceDataSet.incident);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.logiciel'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.logicielTableAdapter.Fill(this.gsbassistanceDataSet.logiciel);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet4.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter1.Fill(this.gsbassistanceDataSet4.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.typeequipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeequipementTableAdapter.Fill(this.gsbassistanceDataSet.typeequipement);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.processeur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.processeurTableAdapter.Fill(this.gsbassistanceDataSet.processeur);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.stockage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.stockageTableAdapter.Fill(this.gsbassistanceDataSet.stockage);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.utilisateurTableAdapter.Fill(this.gsbassistanceDataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.marque'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.marqueTableAdapter.Fill(this.gsbassistanceDataSet.marque);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.ram'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ramTableAdapter.Fill(this.gsbassistanceDataSet.ram);
            // TODO: cette ligne de code charge les données dans la table 'gsbassistanceDataSet.fournisseur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.fournisseurTableAdapter.Fill(this.gsbassistanceDataSet.fournisseur);


            //Listbox Des Logiciel (Perso)
            Listbox_Add_Equip_Logiciel.DataSource = gsbassistanceDataSet.logiciel;
           Listbox_Add_Equip_Logiciel.DisplayMember = "nom";
            Listbox_Add_Equip_Logiciel.ValueMember = "id";
            Combo_Add_Fournisseur.Text = "";

            //Dataset4
            gsbassistanceDataSet4TableAdapters.equipementTableAdapter 
                equipementTableAdapter = new gsbassistanceDataSet4TableAdapters.equipementTableAdapter();

            //Dataset1
            gsbassistanceDataSetTableAdapters.logiciel_equipementTableAdapter 
                logicielEquipementTableAdapter = new gsbassistanceDataSetTableAdapters.logiciel_equipementTableAdapter();

            

        }

        //Listbox_Add_Equip_Logiciel.CheckedItems.Count.ToString()
   

        private void button1_Click(object sender, EventArgs e)
        {
            Remove reset = new Remove();

            //Conversion des données du Formulaire
            int fournisseur = Convert.ToInt32(Combo_Add_Fournisseur.SelectedValue);
           int marque = Convert.ToInt32(Combo_Add_Marque.SelectedValue);
           int utilisateur = Convert.ToInt32(Combo_Add_User.SelectedValue);
           int type = Convert.ToInt32(Combo_Add_Type.SelectedValue);
           int ram = Convert.ToInt32(Combo_Add_Ram.SelectedValue);
          int stockage = Convert.ToInt32(Combo_Add_Stockage.SelectedValue);
           int processeur = Convert.ToInt32(Combo_Add_Processeur.SelectedValue);
           int count = Convert.ToInt32(Listbox_Add_Equip_Logiciel.CheckedItems.Count);
            string nom = Textbox_Add_Model.Text;

           
            //Insertion des données du Formulaire
           equipementTableAdapter.Insert(dateTimePicker1.Value, dateTimePicker2.Value, nom, fournisseur, marque,
             utilisateur, type, ram, stockage, processeur, 1);

            //Fermeture de la Connexion
            equipementTableAdapter.Connection.Close();

            //Prendre LA Derniere Insertion Effectué (Dernier id)
            int equip = Convert.ToInt32(equipementTableAdapter.GetMaxid()); //GetMAxid est defini dans le dataset


            //Ajouter des Logiciel Selectionné dans la Listbox.
            if (equip > 0)
            {
                foreach (DataRowView checkedItem in Listbox_Add_Equip_Logiciel.CheckedItems)
                {
                    //if (Listbox_Add_Equip_Logiciel.GetItemChecked(1))
                    //{
                    int logiciel = Convert.ToInt32(checkedItem[Listbox_Add_Equip_Logiciel.ValueMember]);
                    logiciel_equipementTableAdapter.Insert(logiciel, equip);
                    //}
                }
            }


            MessageBox.Show("Equipement Ajouté", "Réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Fermeture de la connexion
            logicielTableAdapter.Connection.Close();
            
            //Remise a Zero du Formulaire
            reset.ResetAll(Groupbox_Add_Equip_Caracteristiques);
            reset.ResetAll(Groupbox_Add_Equip_Infos);
            reset.ResetAll(Groupbox_Add_Equip_Logiciel);
            reset.ResetAll(Groupbox_Add_Equip_Materiel);
            reset.ResetAll(Groupbox_Add_Equip_Produit);
            reset.ResetAll(Groupbox_Add_Equip_User);

        
            

        }


       
    }
}
