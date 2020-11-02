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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonDecToBin = new System.Windows.Forms.Button();
            this.buttonBinToDec = new System.Windows.Forms.Button();
            this.ddlOperador = new System.Windows.Forms.ComboBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(12, 109);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(338, 83);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(582, 110);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(338, 83);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // buttonOperar
            // 
            this.buttonOperar.BackColor = System.Drawing.Color.Lime;
            this.buttonOperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOperar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOperar.Location = new System.Drawing.Point(12, 228);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(210, 89);
            this.buttonOperar.TabIndex = 3;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = false;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.buttonLimpiar.Location = new System.Drawing.Point(365, 228);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(210, 89);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.buttonCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCerrar.Location = new System.Drawing.Point(710, 228);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(210, 89);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonDecToBin
            // 
            this.buttonDecToBin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDecToBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDecToBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.buttonDecToBin.Location = new System.Drawing.Point(12, 370);
            this.buttonDecToBin.Name = "buttonDecToBin";
            this.buttonDecToBin.Size = new System.Drawing.Size(420, 51);
            this.buttonDecToBin.TabIndex = 6;
            this.buttonDecToBin.Text = "Convertir a Binario";
            this.buttonDecToBin.UseVisualStyleBackColor = false;
            this.buttonDecToBin.Click += new System.EventHandler(this.buttonDecToBin_Click);
            // 
            // buttonBinToDec
            // 
            this.buttonBinToDec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBinToDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBinToDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.buttonBinToDec.Location = new System.Drawing.Point(508, 370);
            this.buttonBinToDec.Name = "buttonBinToDec";
            this.buttonBinToDec.Size = new System.Drawing.Size(412, 51);
            this.buttonBinToDec.TabIndex = 7;
            this.buttonBinToDec.Text = "Convertir a Decimal";
            this.buttonBinToDec.UseVisualStyleBackColor = false;
            this.buttonBinToDec.Click += new System.EventHandler(this.buttonBinToDec_Click);
            // 
            // ddlOperador
            // 
            this.ddlOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlOperador.FormattingEnabled = true;
            this.ddlOperador.Location = new System.Drawing.Point(403, 109);
            this.ddlOperador.Name = "ddlOperador";
            this.ddlOperador.Size = new System.Drawing.Size(121, 84);
            this.ddlOperador.TabIndex = 1;
            this.ddlOperador.Text = "+";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.Transparent;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Resultado.Location = new System.Drawing.Point(12, 20);
            this.Resultado.MaximumSize = new System.Drawing.Size(950, 0);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 69);
            this.Resultado.TabIndex = 8;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.ddlOperador);
            this.Controls.Add(this.buttonBinToDec);
            this.Controls.Add(this.buttonDecToBin);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
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

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonDecToBin;
        private System.Windows.Forms.Button buttonBinToDec;
        private System.Windows.Forms.ComboBox ddlOperador;
        private System.Windows.Forms.Label Resultado;
    }
}

