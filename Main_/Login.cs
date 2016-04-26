using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GSBASSIST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Textbox_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                Textbox_Password.Focus();
        }

        private void Textbox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Button_Login.PerformClick();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Textbox_Login.Text))
            {
                MessageBox.Show("Entrez Un nom D'user", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Textbox_Login.Focus();
                return;
            }
            try
            {
                gsbassistanceDataSetTableAdapters.utilisateurTableAdapter utilisateur=new gsbassistanceDataSetTableAdapters.utilisateurTableAdapter();
                gsbassistanceDataSet.utilisateurDataTable dt = utilisateur.Login(Textbox_Login.Text,
                    Textbox_Password.Text);
                if (dt.Rows.Count>0)
                {
         
                    MessageBox.Show("Vous etes Connecté", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Login ici

                    this.Hide(); //On cache la fenêtre courante
                    var Home = new Home(dt.Rows[0][0].ToString(), dt.Rows[0][6].ToString()); //On instancie la seconde
                    Home.Closed += (s, args) => this.Close(); //On notifie à la première de se fermer au moment où la seconde se ferme
                    Home.Show(); //On affiche la seconde
                   // ((Form)Home).Controls["Label_Role"].Text = ;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
