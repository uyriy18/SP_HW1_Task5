using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_txbx_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!CheckTextBoxValue(textBox.Text))
            {
                textBox.Text = "";
                return;
            }
            switch (textBox.Name)
            {
                case "Monday_txbx":

                    break;

                case "Tuesday_txbx":

                    break;

                case "Wednesday_txbx":

                    break;

                case "Thursday_txbx":

                    break;

                case "Friday_txbx":

                    break;

                case "Saturday_txbx":

                    break;

                case "Sunday_txbx":

                    break;
            }
        }

        bool CheckTextBoxValue(string d)
        {
            try
            {
                double i = double.Parse(d);
                return true;
            }
            catch { return false; }
        }
    }
}
