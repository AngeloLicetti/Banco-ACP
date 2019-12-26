namespace Proyecto_Tbp_AperturaCuentaDeAhorros.Forms
{
    partial class Voucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voucher));
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbHistorial = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.lblMontoPosterior = new System.Windows.Forms.Label();
            this.lblMontoAnterior = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtFechaYHora = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMontoPosterior = new System.Windows.Forms.TextBox();
            this.txtMontoAnterior = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMont = new System.Windows.Forms.Label();
            this.lblMontoActual = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.gbHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBanco
            // 
            this.lblBanco.BackColor = System.Drawing.Color.Transparent;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.White;
            this.lblBanco.Location = new System.Drawing.Point(355, 23);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(521, 80);
            this.lblBanco.TabIndex = 1;
            this.lblBanco.Text = "Banco ACP";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsu
            // 
            this.lblUsu.BackColor = System.Drawing.Color.Transparent;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.ForeColor = System.Drawing.Color.White;
            this.lblUsu.Location = new System.Drawing.Point(113, 123);
            this.lblUsu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(155, 32);
            this.lblUsu.TabIndex = 7;
            this.lblUsu.Text = "Usuario:";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(659, 129);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(413, 30);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(257, 129);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(356, 30);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbHistorial
            // 
            this.gbHistorial.BackColor = System.Drawing.Color.Transparent;
            this.gbHistorial.Controls.Add(this.lblCantidad);
            this.gbHistorial.Controls.Add(this.lblFechaYHora);
            this.gbHistorial.Controls.Add(this.lblMontoPosterior);
            this.gbHistorial.Controls.Add(this.lblMontoAnterior);
            this.gbHistorial.Controls.Add(this.lblTipo);
            this.gbHistorial.Controls.Add(this.lblNumero);
            this.gbHistorial.Controls.Add(this.txtFechaYHora);
            this.gbHistorial.Controls.Add(this.txtCantidad);
            this.gbHistorial.Controls.Add(this.txtTipo);
            this.gbHistorial.Controls.Add(this.txtMontoPosterior);
            this.gbHistorial.Controls.Add(this.txtMontoAnterior);
            this.gbHistorial.Controls.Add(this.txtNumero);
            this.gbHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistorial.ForeColor = System.Drawing.Color.White;
            this.gbHistorial.Location = new System.Drawing.Point(112, 174);
            this.gbHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHistorial.Name = "gbHistorial";
            this.gbHistorial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHistorial.Size = new System.Drawing.Size(960, 411);
            this.gbHistorial.TabIndex = 11;
            this.gbHistorial.TabStop = false;
            this.gbHistorial.Text = "Historial de transacciones";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(364, 54);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(131, 26);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFechaYHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaYHora.Location = new System.Drawing.Point(681, 54);
            this.lblFechaYHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(267, 26);
            this.lblFechaYHora.TabIndex = 8;
            this.lblFechaYHora.Text = "Fecha y hora:";
            this.lblFechaYHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoPosterior
            // 
            this.lblMontoPosterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMontoPosterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPosterior.Location = new System.Drawing.Point(495, 54);
            this.lblMontoPosterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoPosterior.Name = "lblMontoPosterior";
            this.lblMontoPosterior.Size = new System.Drawing.Size(187, 26);
            this.lblMontoPosterior.TabIndex = 8;
            this.lblMontoPosterior.Text = "Monto Posterior:";
            this.lblMontoPosterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoAnterior
            // 
            this.lblMontoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMontoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAnterior.Location = new System.Drawing.Point(61, 54);
            this.lblMontoAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAnterior.Name = "lblMontoAnterior";
            this.lblMontoAnterior.Size = new System.Drawing.Size(183, 26);
            this.lblMontoAnterior.TabIndex = 8;
            this.lblMontoAnterior.Text = "Monto Anterior:";
            this.lblMontoAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(244, 54);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(120, 26);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(8, 54);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(53, 26);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Nº";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFechaYHora
            // 
            this.txtFechaYHora.Enabled = false;
            this.txtFechaYHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaYHora.Location = new System.Drawing.Point(681, 84);
            this.txtFechaYHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaYHora.Multiline = true;
            this.txtFechaYHora.Name = "txtFechaYHora";
            this.txtFechaYHora.Size = new System.Drawing.Size(265, 319);
            this.txtFechaYHora.TabIndex = 7;
            this.txtFechaYHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(364, 84);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 319);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(244, 84);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(119, 319);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMontoPosterior
            // 
            this.txtMontoPosterior.Enabled = false;
            this.txtMontoPosterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPosterior.Location = new System.Drawing.Point(495, 84);
            this.txtMontoPosterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoPosterior.Multiline = true;
            this.txtMontoPosterior.Name = "txtMontoPosterior";
            this.txtMontoPosterior.Size = new System.Drawing.Size(185, 319);
            this.txtMontoPosterior.TabIndex = 5;
            this.txtMontoPosterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMontoAnterior
            // 
            this.txtMontoAnterior.Enabled = false;
            this.txtMontoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAnterior.Location = new System.Drawing.Point(61, 84);
            this.txtMontoAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoAnterior.Multiline = true;
            this.txtMontoAnterior.Name = "txtMontoAnterior";
            this.txtMontoAnterior.Size = new System.Drawing.Size(181, 319);
            this.txtMontoAnterior.TabIndex = 5;
            this.txtMontoAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(8, 84);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 319);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMont
            // 
            this.lblMont.BackColor = System.Drawing.Color.Transparent;
            this.lblMont.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMont.ForeColor = System.Drawing.Color.White;
            this.lblMont.Location = new System.Drawing.Point(111, 592);
            this.lblMont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMont.Name = "lblMont";
            this.lblMont.Size = new System.Drawing.Size(211, 138);
            this.lblMont.TabIndex = 12;
            this.lblMont.Text = "Monto actual:";
            this.lblMont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoActual
            // 
            this.lblMontoActual.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoActual.ForeColor = System.Drawing.Color.White;
            this.lblMontoActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMontoActual.Location = new System.Drawing.Point(329, 592);
            this.lblMontoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoActual.Name = "lblMontoActual";
            this.lblMontoActual.Size = new System.Drawing.Size(393, 138);
            this.lblMontoActual.TabIndex = 13;
            this.lblMontoActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.BackgroundImage = global::Proyecto_Tbp_AperturaCuentaDeAhorros.Properties.Resources.Fondo_marron_degradado;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(829, 610);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(243, 94);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Volver";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // timerFecha
            // 
            this.timerFecha.Enabled = true;
            this.timerFecha.Tick += new System.EventHandler(this.timerFecha_Tick);
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Tbp_AperturaCuentaDeAhorros.Properties.Resources.Fondo_madera;
            this.ClientSize = new System.Drawing.Size(1179, 740);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblMontoActual);
            this.Controls.Add(this.lblMont);
            this.Controls.Add(this.gbHistorial);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.lblBanco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Voucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco ACP - Voucher";
            this.gbHistorial.ResumeLayout(false);
            this.gbHistorial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbHistorial;
        private System.Windows.Forms.TextBox txtFechaYHora;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMontoAnterior;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMontoPosterior;
        private System.Windows.Forms.Label lblMontoAnterior;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMontoPosterior;
        private System.Windows.Forms.Label lblMont;
        private System.Windows.Forms.Label lblMontoActual;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Timer timerFecha;
    }
}