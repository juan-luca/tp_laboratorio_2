namespace FabricaTextil
{
    partial class frmNuevaPrenda
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
            this.chkBuzo = new System.Windows.Forms.CheckBox();
            this.chkJogging = new System.Windows.Forms.CheckBox();
            this.lblJogging = new System.Windows.Forms.Label();
            this.lblBuzo = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.t5 = new Controles.txtSoloNumeros();
            this.t4 = new Controles.txtSoloNumeros();
            this.t3 = new Controles.txtSoloNumeros();
            this.t2 = new Controles.txtSoloNumeros();
            this.t1 = new Controles.txtSoloNumeros();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.chkVariante = new System.Windows.Forms.CheckBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblVariante = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCantTalle = new System.Windows.Forms.Label();
            this.lblCantT5 = new System.Windows.Forms.Label();
            this.lblCantT4 = new System.Windows.Forms.Label();
            this.lblCantT3 = new System.Windows.Forms.Label();
            this.lblCantT2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantT1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPrenda.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrenda
            // 
            this.gbPrenda.Controls.Add(this.chkBuzo);
            this.gbPrenda.Controls.Add(this.chkJogging);
            this.gbPrenda.Controls.Add(this.lblJogging);
            this.gbPrenda.Controls.Add(this.lblBuzo);
            this.gbPrenda.Location = new System.Drawing.Point(12, 24);
            this.gbPrenda.Name = "gbPrenda";
            this.gbPrenda.Size = new System.Drawing.Size(398, 97);
            this.gbPrenda.TabIndex = 0;
            this.gbPrenda.TabStop = false;
            this.gbPrenda.Text = "Prenda";
            // 
            // chkBuzo
            // 
            this.chkBuzo.AutoSize = true;
            this.chkBuzo.Location = new System.Drawing.Point(66, 47);
            this.chkBuzo.Name = "chkBuzo";
            this.chkBuzo.Size = new System.Drawing.Size(18, 17);
            this.chkBuzo.TabIndex = 1;
            this.chkBuzo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkBuzo.UseVisualStyleBackColor = true;
            this.chkBuzo.CheckedChanged += new System.EventHandler(this.chkBuzo_CheckedChanged);
            // 
            // chkJogging
            // 
            this.chkJogging.AutoSize = true;
            this.chkJogging.Location = new System.Drawing.Point(296, 47);
            this.chkJogging.Name = "chkJogging";
            this.chkJogging.Size = new System.Drawing.Size(18, 17);
            this.chkJogging.TabIndex = 2;
            this.chkJogging.UseVisualStyleBackColor = true;
            this.chkJogging.CheckedChanged += new System.EventHandler(this.chkJogging_CheckedChanged);
            // 
            // lblJogging
            // 
            this.lblJogging.AutoSize = true;
            this.lblJogging.Location = new System.Drawing.Point(232, 45);
            this.lblJogging.Name = "lblJogging";
            this.lblJogging.Size = new System.Drawing.Size(58, 17);
            this.lblJogging.TabIndex = 2;
            this.lblJogging.Text = "Jogging";
            // 
            // lblBuzo
            // 
            this.lblBuzo.AutoSize = true;
            this.lblBuzo.Location = new System.Drawing.Point(20, 45);
            this.lblBuzo.Name = "lblBuzo";
            this.lblBuzo.Size = new System.Drawing.Size(40, 17);
            this.lblBuzo.TabIndex = 1;
            this.lblBuzo.Text = "Buzo";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.lblId);
            this.gbDetalle.Controls.Add(this.t5);
            this.gbDetalle.Controls.Add(this.t4);
            this.gbDetalle.Controls.Add(this.t3);
            this.gbDetalle.Controls.Add(this.t2);
            this.gbDetalle.Controls.Add(this.t1);
            this.gbDetalle.Controls.Add(this.cbMarca);
            this.gbDetalle.Controls.Add(this.chkVariante);
            this.gbDetalle.Controls.Add(this.lblModelo);
            this.gbDetalle.Controls.Add(this.lblVariante);
            this.gbDetalle.Controls.Add(this.lblMarca);
            this.gbDetalle.Controls.Add(this.txtModelo);
            this.gbDetalle.Controls.Add(this.lblCantTalle);
            this.gbDetalle.Controls.Add(this.lblCantT5);
            this.gbDetalle.Controls.Add(this.lblCantT4);
            this.gbDetalle.Controls.Add(this.lblCantT3);
            this.gbDetalle.Controls.Add(this.lblCantT2);
            this.gbDetalle.Controls.Add(this.lblCodigo);
            this.gbDetalle.Controls.Add(this.lblCantT1);
            this.gbDetalle.Location = new System.Drawing.Point(12, 127);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(398, 224);
            this.gbDetalle.TabIndex = 2;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalles de la curva";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(270, 89);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 37;
            // 
            // t5
            // 
            this.t5.EditText = "0";
            this.t5.Location = new System.Drawing.Point(72, 172);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(73, 23);
            this.t5.TabIndex = 7;
            // 
            // t4
            // 
            this.t4.EditText = "0";
            this.t4.Location = new System.Drawing.Point(72, 145);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(73, 23);
            this.t4.TabIndex = 6;
            // 
            // t3
            // 
            this.t3.EditText = "0";
            this.t3.Location = new System.Drawing.Point(72, 117);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(73, 23);
            this.t3.TabIndex = 5;
            // 
            // t2
            // 
            this.t2.EditText = "0";
            this.t2.Location = new System.Drawing.Point(72, 90);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(73, 23);
            this.t2.TabIndex = 4;
            // 
            // t1
            // 
            this.t1.EditText = "0";
            this.t1.Location = new System.Drawing.Point(72, 64);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(73, 23);
            this.t1.TabIndex = 3;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(273, 111);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(99, 24);
            this.cbMarca.TabIndex = 9;
            // 
            // chkVariante
            // 
            this.chkVariante.AutoSize = true;
            this.chkVariante.Location = new System.Drawing.Point(320, 36);
            this.chkVariante.Name = "chkVariante";
            this.chkVariante.Size = new System.Drawing.Size(18, 17);
            this.chkVariante.TabIndex = 8;
            this.chkVariante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkVariante.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(207, 146);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 17);
            this.lblModelo.TabIndex = 30;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblVariante
            // 
            this.lblVariante.AutoSize = true;
            this.lblVariante.Location = new System.Drawing.Point(250, 34);
            this.lblVariante.Name = "lblVariante";
            this.lblVariante.Size = new System.Drawing.Size(64, 17);
            this.lblVariante.TabIndex = 5;
            this.lblVariante.Text = "Capucha";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(211, 115);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 17);
            this.lblMarca.TabIndex = 29;
            this.lblMarca.Text = "Marca: ";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(273, 143);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 10;
            // 
            // lblCantTalle
            // 
            this.lblCantTalle.AutoSize = true;
            this.lblCantTalle.Location = new System.Drawing.Point(43, 34);
            this.lblCantTalle.Name = "lblCantTalle";
            this.lblCantTalle.Size = new System.Drawing.Size(119, 17);
            this.lblCantTalle.TabIndex = 26;
            this.lblCantTalle.Text = "Cantidad por talle";
            this.lblCantTalle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCantT5
            // 
            this.lblCantT5.AutoSize = true;
            this.lblCantT5.Location = new System.Drawing.Point(42, 178);
            this.lblCantT5.Name = "lblCantT5";
            this.lblCantT5.Size = new System.Drawing.Size(34, 17);
            this.lblCantT5.TabIndex = 25;
            this.lblCantT5.Text = "XXL";
            // 
            // lblCantT4
            // 
            this.lblCantT4.AutoSize = true;
            this.lblCantT4.Location = new System.Drawing.Point(42, 150);
            this.lblCantT4.Name = "lblCantT4";
            this.lblCantT4.Size = new System.Drawing.Size(25, 17);
            this.lblCantT4.TabIndex = 23;
            this.lblCantT4.Text = "XL";
            // 
            // lblCantT3
            // 
            this.lblCantT3.AutoSize = true;
            this.lblCantT3.Location = new System.Drawing.Point(43, 120);
            this.lblCantT3.Name = "lblCantT3";
            this.lblCantT3.Size = new System.Drawing.Size(16, 17);
            this.lblCantT3.TabIndex = 21;
            this.lblCantT3.Text = "L";
            // 
            // lblCantT2
            // 
            this.lblCantT2.AutoSize = true;
            this.lblCantT2.Location = new System.Drawing.Point(43, 92);
            this.lblCantT2.Name = "lblCantT2";
            this.lblCantT2.Size = new System.Drawing.Size(19, 17);
            this.lblCantT2.TabIndex = 19;
            this.lblCantT2.Text = "M";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(151, 89);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(115, 17);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo de curva:";
            // 
            // lblCantT1
            // 
            this.lblCantT1.AutoSize = true;
            this.lblCantT1.Location = new System.Drawing.Point(43, 64);
            this.lblCantT1.Name = "lblCantT1";
            this.lblCantT1.Size = new System.Drawing.Size(17, 17);
            this.lblCantT1.TabIndex = 2;
            this.lblCantT1.Text = "S";
            this.lblCantT1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 386);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 52);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 52);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevaPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbPrenda);
            this.Name = "frmNuevaPrenda";
            this.Text = "Nueva Prenda";
            this.gbPrenda.ResumeLayout(false);
            this.gbPrenda.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrenda;
        private System.Windows.Forms.Label lblJogging;
        private System.Windows.Forms.Label lblBuzo;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblCantT1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantT5;
        private System.Windows.Forms.Label lblCantT4;
        private System.Windows.Forms.Label lblCantT3;
        private System.Windows.Forms.Label lblCantT2;
        private System.Windows.Forms.Label lblCantTalle;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblVariante;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.CheckBox chkBuzo;
        public System.Windows.Forms.CheckBox chkJogging;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.CheckBox chkVariante;
        public Controles.txtSoloNumeros t5;
        public Controles.txtSoloNumeros t4;
        public Controles.txtSoloNumeros t3;
        public Controles.txtSoloNumeros t2;
        public Controles.txtSoloNumeros t1;
        public System.Windows.Forms.Label lblId;
    }
}