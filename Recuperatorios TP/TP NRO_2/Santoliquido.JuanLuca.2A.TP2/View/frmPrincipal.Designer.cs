namespace View
{
    partial class frmPrincipal
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
            this.gbEstacionamiento = new System.Windows.Forms.GroupBox();
            this.dtGdViewEstacionamiento = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.gbEstacionamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGdViewEstacionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstacionamiento
            // 
            this.gbEstacionamiento.Controls.Add(this.dtGdViewEstacionamiento);
            this.gbEstacionamiento.Controls.Add(this.btnEliminar);
            this.gbEstacionamiento.Controls.Add(this.btnEstacionar);
            this.gbEstacionamiento.Location = new System.Drawing.Point(10, 24);
            this.gbEstacionamiento.Name = "gbEstacionamiento";
            this.gbEstacionamiento.Size = new System.Drawing.Size(897, 333);
            this.gbEstacionamiento.TabIndex = 1;
            this.gbEstacionamiento.TabStop = false;
            this.gbEstacionamiento.Text = "Estacionamiento";
            // 
            // dtGdViewEstacionamiento
            // 
            this.dtGdViewEstacionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGdViewEstacionamiento.Location = new System.Drawing.Point(6, 21);
            this.dtGdViewEstacionamiento.MultiSelect = false;
            this.dtGdViewEstacionamiento.Name = "dtGdViewEstacionamiento";
            this.dtGdViewEstacionamiento.ReadOnly = true;
            this.dtGdViewEstacionamiento.RowHeadersWidth = 51;
            this.dtGdViewEstacionamiento.RowTemplate.Height = 24;
            this.dtGdViewEstacionamiento.Size = new System.Drawing.Size(712, 280);
            this.dtGdViewEstacionamiento.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(724, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 68);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Retirar y cobrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.Location = new System.Drawing.Point(724, 21);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(167, 68);
            this.btnEstacionar.TabIndex = 2;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = true;
            this.btnEstacionar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 373);
            this.Controls.Add(this.gbEstacionamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Santoliquido.JuanLuca.2A";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbEstacionamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGdViewEstacionamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEstacionamiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEstacionar;
        private System.Windows.Forms.DataGridView dtGdViewEstacionamiento;
    }
}

