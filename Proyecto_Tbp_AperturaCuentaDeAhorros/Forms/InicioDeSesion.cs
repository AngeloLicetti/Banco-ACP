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
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text != "" && txtContraseña.Text != "")
            {
                string nombUs = txtNombreDeUsuario.Text;
                string cont = txtContraseña.Text;
                Cuenta CuentaX;
                bool proboTodasLasCuentas=false;
                for (int i = 0; i < Proceso.n; i++)
                {
                    if (Proceso.CuentasCreadas[i].nombreDeUsuario == nombUs && Proceso.CuentasCreadas[i].contraseña == cont)
                    {
                        CuentaX = Proceso.CuentasCreadas[i];
                        CuentaAperturada CuentaDolaresCreada = new CuentaAperturada(CuentaX, i);
                        CuentaDolaresCreada.Show();
                        this.Close();
                        break;
                    }
                    if (i == Proceso.n - 1)
                    {
                        proboTodasLasCuentas = true;
                    }
                    if (proboTodasLasCuentas)
                    {
                        MessageBox.Show("DATOS INCORRECTOS.", "Alerta");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Alerta");
                txtNombreDeUsuario.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
