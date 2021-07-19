﻿namespace FabricaTextil
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
            this.gbGestionCortes = new System.Windows.Forms.GroupBox();
            this.dtGdViewCortes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbSerializer = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbTela = new System.Windows.Forms.GroupBox();
            this.lblMtsTela = new System.Windows.Forms.Label();
            this.lblTela = new System.Windows.Forms.Label();
            this.btnAgregarMtsTela = new System.Windows.Forms.Button();
            this.lblAddTela = new System.Windows.Forms.Label();
            this.txtAddTela = new Controles.txtSoloNumeros();
            this.gbGestionCortes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGdViewCortes)).BeginInit();
            this.gbSerializer.SuspendLayout();
            this.gbTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGestionCortes
            // 
            this.gbGestionCortes.Controls.Add(this.dtGdViewCortes);
            this.gbGestionCortes.Controls.Add(this.btnEliminar);
            this.gbGestionCortes.Controls.Add(this.btnModificar);
            this.gbGestionCortes.Controls.Add(this.btnAgregar);
            this.gbGestionCortes.Location = new System.Drawing.Point(10, 24);
            this.gbGestionCortes.Name = "gbGestionCortes";
            this.gbGestionCortes.Size = new System.Drawing.Size(1438, 379);
            this.gbGestionCortes.TabIndex = 1;
            this.gbGestionCortes.TabStop = false;
            this.gbGestionCortes.Text = "Gestion de cortes";
            // 
            // dtGdViewCortes
            // 
            this.dtGdViewCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGdViewCortes.Location = new System.Drawing.Point(6, 21);
            this.dtGdViewCortes.MultiSelect = false;
            this.dtGdViewCortes.Name = "dtGdViewCortes";
            this.dtGdViewCortes.ReadOnly = true;
            this.dtGdViewCortes.RowHeadersWidth = 51;
            this.dtGdViewCortes.RowTemplate.Height = 24;
            this.dtGdViewCortes.Size = new System.Drawing.Size(1426, 280);
            this.dtGdViewCortes.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1265, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 68);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(654, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 67);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 307);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 68);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbSerializer
            // 
            this.gbSerializer.Controls.Add(this.btnImport);
            this.gbSerializer.Controls.Add(this.btnExport);
            this.gbSerializer.Location = new System.Drawing.Point(1476, 24);
            this.gbSerializer.Name = "gbSerializer";
            this.gbSerializer.Size = new System.Drawing.Size(218, 374);
            this.gbSerializer.TabIndex = 3;
            this.gbSerializer.TabStop = false;
            this.gbSerializer.Text = "Exportar / Importar";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(22, 184);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(167, 68);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(22, 82);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(167, 68);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gbTela
            // 
            this.gbTela.Controls.Add(this.txtAddTela);
            this.gbTela.Controls.Add(this.lblAddTela);
            this.gbTela.Controls.Add(this.btnAgregarMtsTela);
            this.gbTela.Controls.Add(this.lblTela);
            this.gbTela.Controls.Add(this.lblMtsTela);
            this.gbTela.Location = new System.Drawing.Point(180, 411);
            this.gbTela.Name = "gbTela";
            this.gbTela.Size = new System.Drawing.Size(1077, 100);
            this.gbTela.TabIndex = 4;
            this.gbTela.TabStop = false;
            this.gbTela.Text = "Tela";
            this.gbTela.UseCompatibleTextRendering = true;
            // 
            // lblMtsTela
            // 
            this.lblMtsTela.AutoSize = true;
            this.lblMtsTela.Location = new System.Drawing.Point(174, 38);
            this.lblMtsTela.Name = "lblMtsTela";
            this.lblMtsTela.Size = new System.Drawing.Size(0, 17);
            this.lblMtsTela.TabIndex = 0;
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(42, 38);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(126, 17);
            this.lblTela.TabIndex = 1;
            this.lblTela.Text = "Metros cuadrados:";
            // 
            // btnAgregarMtsTela
            // 
            this.btnAgregarMtsTela.Location = new System.Drawing.Point(829, 28);
            this.btnAgregarMtsTela.Name = "btnAgregarMtsTela";
            this.btnAgregarMtsTela.Size = new System.Drawing.Size(116, 37);
            this.btnAgregarMtsTela.TabIndex = 2;
            this.btnAgregarMtsTela.Text = "Agregar metros";
            this.btnAgregarMtsTela.UseVisualStyleBackColor = true;
            this.btnAgregarMtsTela.Click += new System.EventHandler(this.btnAgregarMtsTela_Click);
            // 
            // lblAddTela
            // 
            this.lblAddTela.AutoSize = true;
            this.lblAddTela.Location = new System.Drawing.Point(584, 38);
            this.lblAddTela.Name = "lblAddTela";
            this.lblAddTela.Size = new System.Drawing.Size(168, 17);
            this.lblAddTela.TabIndex = 3;
            this.lblAddTela.Text = "Metros de tela a agregar:";
            // 
            // txtAddTela
            // 
            this.txtAddTela.EditText = "0";
            this.txtAddTela.Location = new System.Drawing.Point(750, 38);
            this.txtAddTela.Name = "txtAddTela";
            this.txtAddTela.Size = new System.Drawing.Size(73, 23);
            this.txtAddTela.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1703, 523);
            this.Controls.Add(this.gbTela);
            this.Controls.Add(this.gbSerializer);
            this.Controls.Add(this.gbGestionCortes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Santoliquido.JuanLuca.2A";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbGestionCortes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGdViewCortes)).EndInit();
            this.gbSerializer.ResumeLayout(false);
            this.gbTela.ResumeLayout(false);
            this.gbTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGestionCortes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtGdViewCortes;
        private System.Windows.Forms.GroupBox gbSerializer;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox gbTela;
        private Controles.txtSoloNumeros txtAddTela;
        private System.Windows.Forms.Label lblAddTela;
        private System.Windows.Forms.Button btnAgregarMtsTela;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Label lblMtsTela;
    }
}

