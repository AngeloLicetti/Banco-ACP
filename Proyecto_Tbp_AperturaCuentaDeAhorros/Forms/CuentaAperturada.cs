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
    public partial class CuentaAperturada : Form
    {
        Cuenta nuevaCuenta;
        int numCuenta;

        public CuentaAperturada(Cuenta cuenta_, int numCuent_)
        {
            InitializeComponent();
            nuevaCuenta = cuenta_;
            numCuenta = numCuent_;
            lblUsuario.Text = nuevaCuenta.Apellidos + ", " + nuevaCuenta.Nombres;
            lblMonto.Text = nuevaCuenta.Moneda+" "+Convert.ToString(nuevaCuenta.montoAhorrado);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Deposito nuevoDeposito = new Deposito(nuevaCuenta,numCuenta);
            nuevoDeposito.Show();
            this.Close();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Retiro nuevoRetiro = new Retiro(nuevaCuenta,numCuenta);
            nuevoRetiro.Show();
            this.Close();
        }

        private void btnVocuher_Click(object sender, EventArgs e)
        {
            Voucher nuevoVoucher = new Voucher(nuevaCuenta,numCuenta);
            nuevoVoucher.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Proceso.CuentasCreadas[numCuenta] = nuevaCuenta;
            this.Close();
            Program.NuevoInicio.Show();
           
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "Lima, " + DateTime.Now.ToString("F");
        }
    }
}
