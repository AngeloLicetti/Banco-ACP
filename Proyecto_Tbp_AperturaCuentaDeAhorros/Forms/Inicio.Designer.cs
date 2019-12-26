namespace Proyecto_Tbp_AperturaCuentaDeAhorros
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnDolares = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSoles = new System.Windows.Forms.Button();
            this.bntIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(88, 213);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(477, 137);
            this.lblPregunta.TabIndex = 4;
            this.lblPregunta.Text = "¿En qué moneda desea aperturar una cuenta de ahorros?";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(32, 18);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(576, 188);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "¡Bienvenido al banco ACP!";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDolares
            // 
            this.btnDolares.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDolares.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDolares.BackgroundImage")));
            this.btnDolares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDolares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDolares.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDolares.ForeColor = System.Drawing.Color.White;
            this.btnDolares.Location = new System.Drawing.Point(363, 366);
            this.btnDolares.Margin = new System.Windows.Forms.Padding(4);
            this.btnDolares.Name = "btnDolares";
            this.btnDolares.Size = new System.Drawing.Size(203, 75);
            this.btnDolares.TabIndex = 1;
            this.btnDolares.Text = "Dólares";
            this.btnDolares.UseVisualStyleBackColor = false;
            this.btnDolares.Click += new System.EventHandler(this.btnDolares_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(362, 464);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 132);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSoles
            // 
            this.btnSoles.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSoles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoles.BackgroundImage")));
            this.btnSoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoles.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoles.ForeColor = System.Drawing.Color.White;
            this.btnSoles.Location = new System.Drawing.Point(85, 366);
            this.btnSoles.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoles.Name = "btnSoles";
            this.btnSoles.Size = new System.Drawing.Size(203, 75);
            this.btnSoles.TabIndex = 0;
            this.btnSoles.Text = "Soles";
            this.btnSoles.UseVisualStyleBackColor = false;
            this.btnSoles.Click += new System.EventHandler(this.btnSoles_Click);
            // 
            // bntIniciarSesion
            // 
            this.bntIniciarSesion.BackColor = System.Drawing.Color.SaddleBrown;
            this.bntIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntIniciarSesion.BackgroundImage")));
            this.bntIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntIniciarSesion.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.bntIniciarSesion.Location = new System.Drawing.Point(85, 464);
            this.bntIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bntIniciarSesion.Name = "bntIniciarSesion";
            this.bntIniciarSesion.Size = new System.Drawing.Size(203, 132);
            this.bntIniciarSesion.TabIndex = 2;
            this.bntIniciarSesion.Text = "Iniciar Sesión";
            this.bntIniciarSesion.UseVisualStyleBackColor = false;
            this.bntIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Tbp_AperturaCuentaDeAhorros.Properties.Resources.Fondo_madera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 628);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnDolares);
            this.Controls.Add(this.bntIniciarSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco ACP - Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnDolares;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSoles;
        private System.Windows.Forms.Button bntIniciarSesion;
    }
}

