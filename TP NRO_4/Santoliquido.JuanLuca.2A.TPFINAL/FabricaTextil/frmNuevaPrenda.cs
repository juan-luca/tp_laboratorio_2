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

namespace FabricaTextil
{
    public partial class frmNuevaPrenda : Form
    {
        protected Indumentaria ind;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmNuevaPrenda()
        {
            InitializeComponent();
            this.cbMarca.DataSource = Enum.GetNames(typeof(EMarca));
            if(!this.chkBuzo.Checked && !this.chkJogging.Checked )
            {
                this.chkBuzo.Checked = true;
            }
        }


        /// <summary>
        /// Al cambiar un checkbox no deja que ambos esten checkados
        /// </summary>
        private void chkBuzo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBuzo.Checked)
            {
                chkJogging.Checked = false;
                lblVariante.Text = "Capucha: ";
            }
        }

        /// <summary>
        /// Al cambiar un checkbox no deja que ambos esten checkados
        /// </summary>
        private void chkJogging_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJogging.Checked)
            {
                chkBuzo.Checked = false;
                lblVariante.Text = "Puño: ";
            }
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
