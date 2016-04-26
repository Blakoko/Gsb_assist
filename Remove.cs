using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBASSIST
{
    class Remove
    {

        public void ResetAll(GroupBox gbox)

        {

            foreach (Control ctrl in gbox.Controls)

            {

                if (ctrl is TextBox)

                {

                    TextBox textBox = (TextBox)ctrl;

                    textBox.Text = null;

                }

                if (ctrl is ComboBox)

                {

                    ComboBox comboBox = (ComboBox)ctrl;

                    comboBox.SelectedIndex = -1;

                }

                if (ctrl is CheckBox)

                {

                    CheckBox checkBox = (CheckBox)ctrl;

                    checkBox.Checked = false;

                }

                if (ctrl is RadioButton)

                {

                    RadioButton radioButton = (RadioButton)ctrl;

                    radioButton.Checked = false;

                }

                if (ctrl is ListBox)

                {

                    ListBox listBox = (ListBox)ctrl;

                    listBox.ClearSelected();

                }

            }

        }



    }
}
