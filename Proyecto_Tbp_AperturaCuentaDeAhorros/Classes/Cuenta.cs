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
    public class Cuenta
    {
        public string Nombres, Apellidos, Moneda, nombreDeUsuario, contraseña;
        public double montoAhorrado;
        public string salidaIds, salidaMontosAnteriores,
                      salidaTipos, salidaCantidades,
                      salidaMontoPosterior,salidaFechaYHora;

        public Transaccion[] TransaccionesRealizadas = new Transaccion[100];

        public Cuenta (string noms, string apes, string montoInicial, string moned, string nombDeUsua, string contra)
        {
            Nombres = noms;
            Apellidos = apes;
            Moneda = moned;
            montoAhorrado = double.Parse(montoInicial);
            nombreDeUsuario = nombDeUsua;
            contraseña = contra;
        }

        public void NuevoRetiro (string nuevoRetiro)
        {
            TransaccionesRealizadas[Transaccion.n] = new Transaccion(nuevoRetiro,"Retiro",montoAhorrado);
        }

        public void NuevoDeposito(string nuevoDeposito)
        {
            TransaccionesRealizadas[Transaccion.n] = new Transaccion(nuevoDeposito, "Deposito",montoAhorrado);
        }

        public string ImprimirIds()
        {
            salidaIds = "";
            for (int i = 0; i<Transaccion.n ; i++)
            {
                salidaIds += i + 1+ "\r\n";
            }
            return salidaIds;
        }

        public string ImprimirMontosAnteriores()
        {
            salidaMontosAnteriores = "";
            for (int i = 0; i < Transaccion.n; i++)
            {
                salidaMontosAnteriores += Moneda + " " + Convert.ToString(TransaccionesRealizadas[i].montoAnterior) + "\r\n";
            }
            return salidaMontosAnteriores;
        }

        public string ImprimirTipos()
        {
            salidaTipos = "";
            for (int i = 0; i < Transaccion.n; i++)
            {
                salidaTipos += TransaccionesRealizadas[i].tipoDeTransaccion + "\r\n";
            }
            return salidaTipos;
        }

        public string ImprimirCantidades()
        {
            salidaCantidades = "";
            for (int i = 0; i < Transaccion.n; i++)
            {
                salidaCantidades += Moneda + " " + Convert.ToString(TransaccionesRealizadas[i].montoUtilizado) + "\r\n";
            }
            return salidaCantidades;
        }

        public string ImprimirMontosPosteriores()
        {
            salidaMontoPosterior = "";
            for (int i = 0; i < Transaccion.n; i++)
            {
                salidaMontoPosterior += Moneda + " " + Convert.ToString(TransaccionesRealizadas[i].nuevoMonto) + "\r\n";
            }
            return salidaMontoPosterior;
        }

        public string ImprimirFechasYHoras()
        {
            salidaFechaYHora = "";
            for (int i = 0; i < Transaccion.n; i++)
            {
                salidaFechaYHora += TransaccionesRealizadas[i].fechaYHora + "\r\n";
            }
            return salidaFechaYHora;
        }
    }
}
