using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MochaPointInventory
{
    static class Program
    {
        // The main entry point for the application
        [STAThread]
        static void Main()
        {
            

            // Enable visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 
            Application.Run(new LoginScreen());
        }
    }
}
