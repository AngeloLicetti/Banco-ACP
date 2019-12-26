using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tbp_AperturaCuentaDeAhorros
{
    public static class Program
    {
        public static Inicio NuevoInicio;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NuevoInicio = new Inicio();
            Application.Run(NuevoInicio);
        }
    }
}
