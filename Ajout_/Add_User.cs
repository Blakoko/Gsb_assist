using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBASSIST
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }
       
        

        private void Button_Add_User_Click(object sender, EventArgs e)
        {
            Remove reset = new Remove();
            gsbassistanceDataSet1TableAdapters.utilisateurTableAdapter utilisateurTableAdapter =
            new gsbassistanceDataSet1TableAdapters.utilisateurTableAdapter();

            foreach (Control txt in this.Groupbox_Add_User.Controls)
            {
                if ((txt is TextBox) && (txt.Text.Trim() == ""))
                {

                    mylabel.Text = "Please all Fields";
                    return;
                }

                else if (txt is TextBox  &&(txt.Text.Trim()!=""))
                {
                    MessageBox.Show("Utilisateur AJouté");
                utilisateurTableAdapter.Insert(
                textBox_Add_User_Nom.Text,
                textBox_Add_User_Prenom.Text,
                textBox_Add_User_Login.Text,
                textBox_Add_User_Password.Text,
                textBox_Add_User_Mail.Text,
                Combo_Add_User_Profil.Text,
                 0
              );
                    reset.ResetAll(Groupbox_Add_User);
                 
                    mylabel.Text = "";
                    return;
                    

                }

            }
            

        }
    }  
}
