using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace View
{
    public partial class frmNuevoVehiculo : Form
    {
        protected Vehiculo vh;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmNuevoVehiculo()
        {
            InitializeComponent();
            this.cbTipo.DataSource = Enum.GetNames(typeof(EPrecios));
            this.DTPickerEntrada.Format = DateTimePickerFormat.Custom;
            this.DTPickerEntrada.CustomFormat = "hh:mm tt";
            this.DTPickerEntrada.Value = DateTime.Now;
            this.DTPickerSalida.Format = DateTimePickerFormat.Custom;
            this.DTPickerSalida.CustomFormat = "hh:mm tt";
            this.DTPickerSalida.Value = DateTime.Now;
        }


        

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.OK;
        }

        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
