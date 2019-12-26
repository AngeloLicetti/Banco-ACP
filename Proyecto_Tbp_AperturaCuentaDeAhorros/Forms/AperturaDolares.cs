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
    public partial class AperturaDolares : Form
    {
        public AperturaDolares(Inicio inicio_)
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            bool otroPunto = false;
            int x = txtMontoInicial.Text.Length;
            for (int y = 0; y < x; y++)
            {
                char cad = txtMontoInicial.Text[y];
                if (cad == '.')
                {
                    otroPunto = true;
                }
            }
            if (!otroPunto)
            {
                txtMontoInicial.Text += ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Text += "0";
        }

        //este botón elimina el último caracter insertado
        private void btnD_Click(object sender, EventArgs e)
        {
            int k = txtMontoInicial.Text.Length - 1;
            if (k >= 0)
            {
                string devolver = txtMontoInicial.Text.Remove(k);
                txtMontoInicial.Text = devolver;
            }
        }

        //este botón elimina toda la cadena insertada
        private void btnC_Click(object sender, EventArgs e)
        {
            txtMontoInicial.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtMontoInicial.Text != "" && txtNombreDeUsuario.Text!="" && txtContraseña.Text!="")
            {
                Proceso.CuentasCreadas[Proceso.n] = new Cuenta(txtNombres.Text, txtApellidos.Text, txtMontoInicial.Text, "S/.", txtNombreDeUsuario.Text, txtContraseña.Text);
                Cuenta nuevaCuenta = Proceso.CuentasCreadas[Proceso.n];
                Proceso.aumentarContadorCuenta();
                CuentaAperturada CuentaDolaresCreada = new CuentaAperturada(nuevaCuenta,Proceso.n);
                CuentaDolaresCreada.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Alerta");
                txtNombres.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.NuevoInicio.Show();
            this.Close();
        }
    }
}
