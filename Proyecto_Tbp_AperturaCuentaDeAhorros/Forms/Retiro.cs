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
    public partial class Retiro : Form
    {
        Cuenta nuevaCuenta;
        int numCuenta;

        public Retiro(Cuenta cuenta_, int numCuent_)
        {
            InitializeComponent();
            nuevaCuenta = cuenta_;
            numCuenta = numCuent_;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            bool otroPunto = false;
            int x = txtMontoRetirado.Text.Length;
            for (int y = 0; y < x; y++)
            {
                char cad = txtMontoRetirado.Text[y];
                if (cad == '.')
                {
                    otroPunto = true;
                }
            }
            if (!otroPunto)
            {
                txtMontoRetirado.Text += ".";
            }
        }

        //este botón elimina el último caracter insertado
        private void btnD_Click(object sender, EventArgs e)
        {
            int k = txtMontoRetirado.Text.Length - 1;
            if (k >= 0)
            {
                string devolver = txtMontoRetirado.Text.Remove(k);
                txtMontoRetirado.Text = devolver;
            }
        }

        //este botón elimina toda la cadena insertada
        private void btnC_Click(object sender, EventArgs e)
        {
            txtMontoRetirado.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMontoRetirado.Text != "")
            {
                if (nuevaCuenta.montoAhorrado - double.Parse(txtMontoRetirado.Text) >= 0)
                {
                    nuevaCuenta.NuevoRetiro(txtMontoRetirado.Text);
                    nuevaCuenta.montoAhorrado = nuevaCuenta.TransaccionesRealizadas[Transaccion.n].Retirar();
                    CuentaAperturada CuentaCreada = new CuentaAperturada(nuevaCuenta, numCuenta);
                    CuentaCreada.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No tiene suficiente dinero disponible para realizar esa acción.", "ERROR");
                    txtMontoRetirado.Clear();
                }
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
