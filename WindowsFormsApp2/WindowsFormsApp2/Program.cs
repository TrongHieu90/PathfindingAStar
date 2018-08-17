using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        //public static Form1 form1 = new Form1();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             // Place this var out of the constructor
            //Application.Run(form1);
            Application.Run(new Form1());
        }
    }
}
