using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double[] temperatureList = new double[7];
        Module GraphicModule { get; set; }
        object Graphic;
 
        public Form1(Module graphic, object targetWindow)
        {
            InitializeComponent();
            GraphicModule = graphic;
            Graphic = targetWindow;
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
                    temperatureList[0] = double.Parse(textBox.Text);
                    break;

                case "Tuesday_txbx":
                    temperatureList[1] = double.Parse(textBox.Text);
                    break;

                case "Wednesday_txbx":
                    temperatureList[2] = double.Parse(textBox.Text);
                    break;

                case "Thursday_txbx":
                    temperatureList[3] = double.Parse(textBox.Text);
                    break;

                case "Friday_txbx":
                    temperatureList[4] = double.Parse(textBox.Text);
                    break;

                case "Saturday_txbx":
                    temperatureList[5] = double.Parse(textBox.Text);
                    break;

                case "Sunday_txbx":
                    temperatureList[6] = double.Parse(textBox.Text);
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

        private void Send_btn_Click(object sender, EventArgs e)
        {
            GraphicModule.GetType("WindowsFormsApp1.Form1").GetMethod("DrawGraphic").Invoke(Graphic, new object[] { temperatureList });
        }

        private void TextBox_txbx_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text == "0")  textBox.Text = "";
        }
        private void TextBox_txbx_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "") textBox.Text = "0";
        }
    }
}
