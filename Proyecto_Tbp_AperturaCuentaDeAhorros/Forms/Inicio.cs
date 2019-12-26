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

namespace Proyecto_Tbp_AperturaCuentaDeAhorros
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Proceso.n > 0)
            {
                this.Hide();
                InicioDeSesion nuevoInicioDeSesion = new InicioDeSesion();
                nuevoInicioDeSesion.Show();
            }
            else
            {
                MessageBox.Show("No se ha creado ninguna cuenta aún.", "Alerta");
            }
        }

        private void btnSoles_Click(object sender, EventArgs e)
        {
            //oculta esta form
            this.Hide();
            //inicializa y muestra un nuevo Windows Forms de la clase AperturaSoles
            AperturaSoles NuevaAperturaSoles = new AperturaSoles();
            NuevaAperturaSoles.Show(); 
        }

        private void btnDolares_Click(object sender, EventArgs e)
        {
            //oculta esta form
            this.Hide();
            //inicializa y muestra un nuevo Windows Forms de la clase AperturaDolares
            AperturaDolares NuevaAperturaDolares = new AperturaDolares(this);
            NuevaAperturaDolares.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra la aplicación
            this.Close();
        }
    }
}
