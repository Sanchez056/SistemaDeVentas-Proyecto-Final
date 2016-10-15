using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
           // Database.SetInitializer<SistemaDeVentasDb>(new DropCreateDatabaseAlways<Siste>());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUsuarios());

        }
    }
}
