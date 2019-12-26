using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//indica que se usan las clases de la carpeta "Classes" que creamos para agrupar de forma más ordenada las clasesde nuestro proyecto
using Proyecto_Tbp_AperturaCuentaDeAhorros.Classes;
//indica que se usan las forms de la carpeta "Forms" que creamos para agrupar de forma más ordenada los Windows Forms de nuestro proyecto
using Proyecto_Tbp_AperturaCuentaDeAhorros.Forms;

namespace Proyecto_Tbp_AperturaCuentaDeAhorros.Classes
{
    public class Proceso
    {
        public static int n = 0;
        static public Cuenta[] CuentasCreadas = new Cuenta[100];
        
        public static void  aumentarContadorCuenta()
        {
            n++;
        }
    }
}
