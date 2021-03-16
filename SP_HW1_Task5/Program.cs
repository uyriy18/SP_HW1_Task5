using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_HW1_Task5
{
    static class Program
    {

        static AppDomain Data;        
        static AppDomain Graphic;   
        static Assembly DataAsm;      
        static Assembly GraphicAsm; 
        static Form DataWnd;       
        static Form GraphicWnd;       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        [LoaderOptimization(LoaderOptimization.MultiDomain)]
        static void Main()
        {
            Application.EnableVisualStyles();
            Data = AppDomain.CreateDomain("Data");
            Graphic = AppDomain.CreateDomain("Graphic");

            DataAsm = Data.Load(AssemblyName.GetAssemblyName("WindowsFormsApp1.exe"));
            GraphicAsm = Graphic.Load(AssemblyName.GetAssemblyName("WindowsFormsApp2.exe"));

            DataWnd = Activator.CreateInstance(DataAsm.GetType("WindowsFormsApp1.Form1")) as Form;
            GraphicWnd = Activator.CreateInstance(GraphicAsm.GetType("WindowsFormsApp2.Form1")) as Form;

            (new Thread(new ThreadStart(RunData))).Start();
            (new Thread(new ThreadStart(RunGraphic))).Start();
        }
        static void RunData()
        {
            DataWnd.ShowDialog();
            AppDomain.Unload(Data);
        }
        static void RunGraphic()
        {
            GraphicWnd.ShowDialog();
            AppDomain.Unload(Graphic);
        }
    }
}
