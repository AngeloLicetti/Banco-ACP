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
    public partial class Deposito : Form
    {
        Cuenta nuevaCuenta;
        int numCuenta;

        public Deposito(Cuenta cuenta_, int numCuent_)
        {
            InitializeComponent();
            nuevaCuenta = cuenta_;
            numCuenta = numCuent_;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            bool otroPunto = false;
            int x = txtMontoDepositado.Text.Length;
            for (int y = 0; y < x; y++)
            {
                char cad = txtMontoDepositado.Text[y];
                if (cad == '.')
                {
                    otroPunto = true;
                }
            }
            if (!otroPunto)
            {
                txtMontoDepositado.Text += ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Text += "0";
        }

        //este botón elimina el último caracter insertado
        private void btnD_Click(object sender, EventArgs e)
        {
            int k = txtMontoDepositado.Text.Length - 1;
            if (k >= 0)
            {
                string devolver = txtMontoDepositado.Text.Remove(k);
                txtMontoDepositado.Text = devolver;
            }
        }

        //este botón elimina toda la cadena insertada
        private void btnC_Click(object sender, EventArgs e)
        {
            txtMontoDepositado.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMontoDepositado.Text!= "")
            {
                nuevaCuenta.NuevoDeposito(txtMontoDepositado.Text);
                nuevaCuenta.montoAhorrado = nuevaCuenta.TransaccionesRealizadas[Transaccion.n].Depositar();
                CuentaAperturada CuentaCreada = new CuentaAperturada(nuevaCuenta, numCuenta);
                CuentaCreada.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CuentaAperturada CuentaCreada = new CuentaAperturada(nuevaCuenta,numCuenta);
            CuentaCreada.Show();
            this.Close();
        }
    }
}
