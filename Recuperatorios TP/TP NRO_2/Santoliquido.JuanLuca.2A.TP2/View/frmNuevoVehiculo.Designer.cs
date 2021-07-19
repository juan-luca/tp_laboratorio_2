namespace View
{
    partial class frmNuevoVehiculo
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
            this.gbPrenda = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCantHoras = new System.Windows.Forms.TextBox();
            this.lblCantHoras = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.DTPickerSalida = new System.Windows.Forms.DateTimePicker();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.DTPickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPrenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrenda
            // 
            this.gbPrenda.Controls.Add(this.txtTotal);
            this.gbPrenda.Controls.Add(this.txtCantHoras);
            this.gbPrenda.Controls.Add(this.lblCantHoras);
            this.gbPrenda.Controls.Add(this.lblTotal);
            this.gbPrenda.Controls.Add(this.lblHoraSalida);
            this.gbPrenda.Controls.Add(this.DTPickerSalida);
            this.gbPrenda.Controls.Add(this.lblHoraEntrada);
            this.gbPrenda.Controls.Add(this.DTPickerEntrada);
            this.gbPrenda.Controls.Add(this.cbTipo);
            this.gbPrenda.Controls.Add(this.lblPatente);
            this.gbPrenda.Controls.Add(this.lblTipo);
            this.gbPrenda.Controls.Add(this.txtPatente);
            this.gbPrenda.Location = new System.Drawing.Point(12, 24);
            this.gbPrenda.Name = "gbPrenda";
            this.gbPrenda.Size = new System.Drawing.Size(398, 335);
            this.gbPrenda.TabIndex = 0;
            this.gbPrenda.TabStop = false;
            this.gbPrenda.Text = "Vehiculo";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(174, 298);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "0";
            this.txtTotal.Visible = false;
            // 
            // txtCantHoras
            // 
            this.txtCantHoras.Location = new System.Drawing.Point(154, 190);
            this.txtCantHoras.Name = "txtCantHoras";
            this.txtCantHoras.Size = new System.Drawing.Size(100, 22);
            this.txtCantHoras.TabIndex = 5;
            this.txtCantHoras.Text = "0";
            this.txtCantHoras.Visible = false;
            // 
            // lblCantHoras
            // 
            this.lblCantHoras.AutoSize = true;
            this.lblCantHoras.Location = new System.Drawing.Point(6, 195);
            this.lblCantHoras.Name = "lblCantHoras";
            this.lblCantHoras.Size = new System.Drawing.Size(128, 17);
            this.lblCantHoras.TabIndex = 13;
            this.lblCantHoras.Text = "Cantidad de horas:";
            this.lblCantHoras.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(71, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 17);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total a pagar:";
            this.lblTotal.Visible = false;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(6, 153);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(104, 17);
            this.lblHoraSalida.TabIndex = 12;
            this.lblHoraSalida.Text = "Hora de salida:";
            this.lblHoraSalida.Visible = false;
            // 
            // DTPickerSalida
            // 
            this.DTPickerSalida.Location = new System.Drawing.Point(154, 148);
            this.DTPickerSalida.Name = "DTPickerSalida";
            this.DTPickerSalida.Size = new System.Drawing.Size(200, 22);
            this.DTPickerSalida.TabIndex = 4;
            this.DTPickerSalida.Visible = false;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(6, 110);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(116, 17);
            this.lblHoraEntrada.TabIndex = 11;
            this.lblHoraEntrada.Text = "Hora de entrada:";
            // 
            // DTPickerEntrada
            // 
            this.DTPickerEntrada.Location = new System.Drawing.Point(154, 105);
            this.DTPickerEntrada.Name = "DTPickerEntrada";
            this.DTPickerEntrada.Size = new System.Drawing.Size(200, 22);
            this.DTPickerEntrada.TabIndex = 3;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(154, 61);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(99, 24);
            this.cbTipo.TabIndex = 2;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(4, 24);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(61, 17);
            this.lblPatente.TabIndex = 9;
            this.lblPatente.Text = "Patente:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 64);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 17);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo: ";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(154, 21);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 22);
            this.txtPatente.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 386);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 52);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 52);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbPrenda);
            this.Name = "frmNuevoVehiculo";
            this.Text = "Nuevo vehiculo";
            this.gbPrenda.ResumeLayout(false);
            this.gbPrenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPatente;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.TextBox txtPatente;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCantHoras;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.DateTimePicker DTPickerEntrada;
        public System.Windows.Forms.Label lblHoraEntrada;
        public System.Windows.Forms.Label lblCantHoras;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblHoraSalida;
        public System.Windows.Forms.DateTimePicker DTPickerSalida;
        public System.Windows.Forms.Button btnAceptar;
    }
}