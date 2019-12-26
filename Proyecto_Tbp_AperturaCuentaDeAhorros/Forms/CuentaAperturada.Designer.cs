namespace Proyecto_Tbp_AperturaCuentaDeAhorros.Forms
{
    partial class CuentaAperturada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaAperturada));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsua = new System.Windows.Forms.Label();
            this.lblMontoActual = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnVocuher = new System.Windows.Forms.Button();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(205, 182);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(361, 43);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsua
            // 
            this.lblUsua.BackColor = System.Drawing.Color.Transparent;
            this.lblUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsua.ForeColor = System.Drawing.Color.White;
            this.lblUsua.Location = new System.Drawing.Point(85, 188);
            this.lblUsua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsua.Name = "lblUsua";
            this.lblUsua.Size = new System.Drawing.Size(115, 30);
            this.lblUsua.TabIndex = 12;
            this.lblUsua.Text = "Usuario:";
            this.lblUsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoActual
            // 
            this.lblMontoActual.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoActual.ForeColor = System.Drawing.Color.White;
            this.lblMontoActual.Location = new System.Drawing.Point(72, 245);
            this.lblMontoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoActual.Name = "lblMontoActual";
            this.lblMontoActual.Size = new System.Drawing.Size(139, 75);
            this.lblMontoActual.TabIndex = 13;
            this.lblMontoActual.Text = "Monto Actual:";
            this.lblMontoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(212, 245);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(417, 75);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetirar.BackgroundImage")));
            this.btnRetirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.Color.White;
            this.btnRetirar.Location = new System.Drawing.Point(347, 342);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(220, 74);
            this.btnRetirar.TabIndex = 1;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(347, 453);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(220, 74);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepositar.BackgroundImage")));
            this.btnDepositar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDepositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.ForeColor = System.Drawing.Color.White;
            this.btnDepositar.Location = new System.Drawing.Point(87, 342);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(220, 74);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnVocuher
            // 
            this.btnVocuher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVocuher.BackgroundImage")));
            this.btnVocuher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVocuher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVocuher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVocuher.ForeColor = System.Drawing.Color.White;
            this.btnVocuher.Location = new System.Drawing.Point(92, 453);
            this.btnVocuher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVocuher.Name = "btnVocuher";
            this.btnVocuher.Size = new System.Drawing.Size(220, 74);
            this.btnVocuher.TabIndex = 2;
            this.btnVocuher.Text = "Voucher";
            this.btnVocuher.UseVisualStyleBackColor = true;
            this.btnVocuher.Click += new System.EventHandler(this.btnVocuher_Click);
            // 
            // lblBanco
            // 
            this.lblBanco.BackColor = System.Drawing.Color.Transparent;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.White;
            this.lblBanco.Location = new System.Drawing.Point(93, 15);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(500, 97);
            this.lblBanco.TabIndex = 14;
            this.lblBanco.Text = "Banco ACP";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(77, 124);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(489, 38);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerFecha
            // 
            this.timerFecha.Enabled = true;
            this.timerFecha.Tick += new System.EventHandler(this.timerFecha_Tick);
            // 
            // CuentaAperturada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Tbp_AperturaCuentaDeAhorros.Properties.Resources.Fondo_madera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnVocuher);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMontoActual);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUsua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CuentaAperturada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco ACP - Cuenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsua;
        private System.Windows.Forms.Label lblMontoActual;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnVocuher;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerFecha;
    }
}