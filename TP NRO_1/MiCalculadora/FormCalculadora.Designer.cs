namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirAlBinario = new System.Windows.Forms.Button();
            this.btnConvertirAlDecimal = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(12, 109);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(338, 83);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(582, 110);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(338, 83);
            this.txtNumero2.TabIndex = 2;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.Lime;
            this.btnOperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOperar.Location = new System.Drawing.Point(12, 228);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(210, 89);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(365, 228);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(210, 89);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Location = new System.Drawing.Point(710, 228);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(210, 89);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // btnConvertirAlBinario
            // 
            this.btnConvertirAlBinario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConvertirAlBinario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertirAlBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnConvertirAlBinario.Location = new System.Drawing.Point(12, 370);
            this.btnConvertirAlBinario.Name = "btnConvertirAlBinario";
            this.btnConvertirAlBinario.Size = new System.Drawing.Size(420, 51);
            this.btnConvertirAlBinario.TabIndex = 6;
            this.btnConvertirAlBinario.Text = "Convertir a Binario";
            this.btnConvertirAlBinario.UseVisualStyleBackColor = false;
            this.btnConvertirAlBinario.Click += new System.EventHandler(this.buttonDecToBin_Click);
            // 
            // btnConvertirAlDecimal
            // 
            this.btnConvertirAlDecimal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConvertirAlDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertirAlDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnConvertirAlDecimal.Location = new System.Drawing.Point(508, 370);
            this.btnConvertirAlDecimal.Name = "btnConvertirAlDecimal";
            this.btnConvertirAlDecimal.Size = new System.Drawing.Size(412, 51);
            this.btnConvertirAlDecimal.TabIndex = 7;
            this.btnConvertirAlDecimal.Text = "Convertir a Decimal";
            this.btnConvertirAlDecimal.UseVisualStyleBackColor = false;
            this.btnConvertirAlDecimal.Click += new System.EventHandler(this.buttonBinToDec_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(403, 109);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 84);
            this.cmbOperador.TabIndex = 1;
            this.cmbOperador.Text = "+";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(12, 20);
            this.lblResultado.MaximumSize = new System.Drawing.Size(950, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 69);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.btnConvertirAlDecimal);
            this.Controls.Add(this.btnConvertirAlBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Juan Luca santoliquido del curso 2ºA";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirAlBinario;
        private System.Windows.Forms.Button btnConvertirAlDecimal;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
    }
}

