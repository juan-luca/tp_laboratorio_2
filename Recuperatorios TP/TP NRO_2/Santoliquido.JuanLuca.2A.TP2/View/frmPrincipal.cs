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
    public partial class frmPrincipal : Form
    {
        public Estacionamiento ES;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
            this.ES = new Estacionamiento();
           


        }
        /// <summary>
        /// Refresca la grilla
        /// </summary>
        public void ActualizarGrilla()
        {
            this.btnEliminar.Enabled = true;
            dtGdViewEstacionamiento.DataSource = null;


            
            dtGdViewEstacionamiento.DataSource = this.ES.Vehiculos;
            ConfigurarGrilla();

        }

        /// <summary>
        /// Abre el formulario hijo para agregar vehiculos
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoVehiculo nv = new frmNuevoVehiculo();
            
            DialogResult rta = nv.ShowDialog();
            bool ret;
           
                if (rta == DialogResult.OK && nv.txtPatente.Text!="")
                {
                
                    EPrecios tipo;
                    Enum.TryParse(nv.cbTipo.SelectedValue.ToString(), out tipo);
                    
                    switch (tipo)
                    {
                        case EPrecios.Auto:
                        if(ES.EspacioAutoCamioneta>0)
                        {
                            Auto a = new Auto(nv.txtPatente.Text, tipo, nv.DTPickerEntrada.Value);
                            ret = this.ES + a;
                            
                        }else
                        {
                            ret = false;
                        }
                            
                            break;
                        case EPrecios.Camioneta:
                        if (ES.EspacioAutoCamioneta > 0)
                        {
                            Camioneta c = new Camioneta(nv.txtPatente.Text, tipo, nv.DTPickerEntrada.Value);
                            ret = this.ES + c;
                        }
                        else
                        {
                            ret = false;
                        }
                        break;
                        case EPrecios.Moto:
                        if (ES.EspacioMoto > 0)
                        {
                            Moto m = new Moto(nv.txtPatente.Text, tipo, nv.DTPickerEntrada.Value);
                            ret = this.ES + m;
                        }
                        else
                        {
                            ret = false;
                        }
                        break;
                    default:
                          ret = false;
                        
                        break;
                    }
                
                

                if (ret == true)
                {
                    MessageBox.Show("Se estaciono con exito");

                }
                else
                {
                    MessageBox.Show("Espacio insuficiente para el tipo seleccionado o ya se encuentra estacionado un vehiculo con dicha patente");
                }



                ActualizarGrilla();
                }else
                {

                MessageBox.Show("Debe ingresar la patente del vehiculo");

                 }
           

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if(this.ES.Vehiculos.Count!=0)
            {
                this.dtGdViewEstacionamiento.DataSource = this.ES.Vehiculos;
                this.btnEliminar.Enabled = true;
            }else
            {
                this.btnEliminar.Enabled = false;
            }


            ConfigurarGrilla();

        }
        
        /// <summary>
        /// Configura el estilo de la grilla
        /// </summary>
        private void ConfigurarGrilla()
        {
            this.dtGdViewEstacionamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtGdViewEstacionamiento.MultiSelect = false;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            style.Font = new Font(this.dtGdViewEstacionamiento.Font, FontStyle.Bold);

            this.dtGdViewEstacionamiento.DefaultCellStyle = style;
            this.dtGdViewEstacionamiento.ColumnHeadersDefaultCellStyle = style;

            foreach (DataGridViewRow item in this.dtGdViewEstacionamiento.Rows)
            {
                if ((this.ES.Vehiculos[item.Index]) is Auto || (this.ES.Vehiculos[item.Index]) is Camioneta)
                {
                    item.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }
        /// <summary>
        /// Elimina el vehiculo previamente seleccionado
        /// </summary>
        private void btnRetirar_Click(object sender, EventArgs e)
        {
           
                string patente = "";

            patente = Convert.ToString(this.dtGdViewEstacionamiento.CurrentRow.Cells[0].Value);
            if(patente!="")
            {
                Vehiculo item;
                bool ret = false;
                if (this.ES.BuscarVehiculo(patente) != null)
                {
                    item = this.ES.BuscarVehiculo(patente);

                    //llenado del form
                    frmNuevoVehiculo rv = new frmNuevoVehiculo();
                    rv.Text = "Retirar vehiculo";
                    rv.btnAceptar.Text = "Cobrar";
                    
                    rv.txtPatente.Text = item.Patente;
                    rv.DTPickerEntrada.Value = item.HoraEntrada;
                    rv.DTPickerSalida.Value = DateTime.Now;
                    rv.cbTipo.SelectedItem = (int)item.Tipo;
                    item.HoraSalida = DateTime.Now;
                    //hago visible los controles
                    rv.DTPickerSalida.Visible = true;
                    rv.lblHoraSalida.Visible = true;
                    rv.lblCantHoras.Visible = true;
                    rv.txtCantHoras.Visible = true;
                    rv.lblTotal.Visible = true;
                    rv.txtTotal.Visible = true;
                    //deshabilito lo que nos e puede modificar
                    rv.txtPatente.Enabled = false;
                    rv.txtTotal.Enabled = false;
                    rv.txtCantHoras.Enabled = false;
                    rv.cbTipo.Enabled = false;
                    rv.DTPickerEntrada.Enabled = false;
                    rv.DTPickerSalida.Enabled = false;
                    double Tot = 0;
                    TimeSpan diff = item.HoraSalida.Subtract(item.HoraEntrada);
                    rv.txtCantHoras.Text = diff.TotalHours.ToString();
                    Tot = diff.TotalHours * (int)item.Tipo;
                    rv.txtTotal.Text = Tot.ToString();
                    DialogResult rta = rv.ShowDialog();
                    if (rta == DialogResult.OK)
                    {
                        if (MessageBox.Show("¿Seguro(a) que desea retirar el vehiculo?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ret = this.ES - item;
                        }

                    }



                   
                }




                ActualizarGrilla();
                if (ret == true)
                {
                    MessageBox.Show("Se retiro con exito");

                }
                else
                {
                    MessageBox.Show("No se pudo retirar el vehiculo");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un vehiculo");
            }
            
            
            
        }
        

    }
}
