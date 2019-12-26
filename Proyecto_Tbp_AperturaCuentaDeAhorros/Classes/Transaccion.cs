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
    public class Transaccion
    {
        public static int n;
        public double montoUtilizado, montoAnterior,nuevoMonto;
        public string fechaYHora;
        public string tipoDeTransaccion;

        public Transaccion(string montoTransaccion,string tipo, double montoAhorrado)
        {
            montoUtilizado = double.Parse(montoTransaccion);
            fechaYHora = DateTime.Now.ToString("g");
            tipoDeTransaccion = tipo;
            montoAnterior = montoAhorrado;
        }
        public double Retirar()
        {
            nuevoMonto = montoAnterior - montoUtilizado;
            n++;
            return nuevoMonto;
        }
        public double Depositar()
        {
            nuevoMonto = montoAnterior + montoUtilizado;
            n++;
            return nuevoMonto;
        }
    }
}
