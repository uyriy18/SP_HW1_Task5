using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double  step = 1.0, x, y;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void DrawGraphic(double[] d)
        {
            x = d.Length;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < d.Length; i++)
            {
                y = d[i];
                x += step;
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        
             
                Image img = new Bitmap(panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);

          
                Graphics imgDC = Graphics.FromImage(img);

         
                imgDC.Clear(BackColor);

               
                e.Graphics.DrawImage(img, 0, 0);
            
        }
    }
}
