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
        List<double> dList;

        public Form1(double[] d)
        {
            InitializeComponent();
            dList = new List<double>(d);
            DrawGraphic();
        }

        void DrawGraphic()
        {
            chart1.Series[0].Points.Clear();
            x = dList.Count;
           for(int i = 0; i < dList.Count; i++)
            {
                y = dList[i];
                x += step;
                chart1.Series[0].Points.AddXY(x, y);
            }
          
            
        }
    }
}
