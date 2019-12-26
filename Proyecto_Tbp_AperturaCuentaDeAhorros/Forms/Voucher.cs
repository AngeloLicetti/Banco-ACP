using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//indica que se usan las clases de la carpeta "Classes" que creamos para agrupar de forma más ordenada las clasesde nuestro proyecto
using Proyecto_Tbp_AperturaCuentaDeAhorros.Classes;
//indica que se usan las forms de la carpeta "Forms" que creamos para agrupar de forma más ordenada los Windows Forms de nuestro proyecto
using Proyecto_Tbp_AperturaCuentaDeAhorros.Forms;

namespace Proyecto_Tbp_AperturaCuentaDeAhorros.Forms
{
    public partial class Voucher : Form
    {
        Cuenta nuevaCuenta;
        int numCuenta;

        public Voucher(Cuenta cuenta_, int numCuent_)
        {
            InitializeComponent();
            nuevaCuenta = cuenta_;
            numCuenta = numCuent_;
            lblUsuario.Text = nuevaCuenta.Apellidos + ", " + nuevaCuenta.Nombres;
            lblFecha.Text= DateTime.Now.Date.ToString("d");
            txtNumero.Text = nuevaCuenta.ImprimirIds();
            txtMontoAnterior.Text = nuevaCuenta.ImprimirMontosAnteriores();
            txtTipo.Text = nuevaCuenta.ImprimirTipos();
            txtCantidad.Text = nuevaCuenta.ImprimirCantidades();
            txtMontoPosterior.Text = nuevaCuenta.ImprimirMontosPosteriores();
            txtFechaYHora.Text = nuevaCuenta.ImprimirFechasYHoras();
            lblMontoActual.Text= nuevaCuenta.Moneda + " " + Convert.ToString(nuevaCuenta.montoAhorrado);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CuentaAperturada CuentaCreada = new CuentaAperturada(nuevaCuenta,numCuenta);
            CuentaCreada.Show();
            this.Close();
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "Lima, " + DateTime.Now.ToString("F");
        }
    }
}
