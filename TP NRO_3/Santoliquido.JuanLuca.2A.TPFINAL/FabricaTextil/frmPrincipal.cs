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
using Excepciones;

namespace FabricaTextil
{
    public partial class frmPrincipal : Form
    {
        public Fabrica FB;
        private List<Indumentaria> lstInd;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
            this.FB = new Fabrica();
            this.lstInd = new List<Indumentaria>();
            Buzos corte1 = new Buzos(1, 2, 2, 1, 4, 5, true, enumMarca.Adidas, "Anorak");//14
            
            Buzos corte2 = new Buzos(2, 6, 4, 2, 1, 10, false, enumMarca.Nike, "Just Do It");//23
            Joggings corte3 = new Joggings(3, 1, 2, 2, 2, 3, false, enumMarca.Nike, "Duo");//10
            Joggings corte4 = new Joggings(4, 5, 5, 5, 5, 5, false, enumMarca.Puma, "Track");//25
            Joggings corte5 = new Joggings(5, 4, 4, 4, 4, 4, true, enumMarca.Adidas, "Retro");//20

            FB += corte1;
            FB += corte2;
            FB += corte3;
            FB += corte4;
            FB += corte5;
            ActualizarGrilla();


        }
        /// <summary>
        /// Refresca la grilla
        /// </summary>
        public void ActualizarGrilla()
        {
            
            dtGdViewCortes.DataSource = null;


            this.lstInd.Clear();
            foreach(Buzos buzo in this.FB.Buzos)
            {
                
                this.lstInd.Add(buzo);
               

            }
            foreach (Joggings jogging in this.FB.Joggings)
            {
                this.lstInd.Add(jogging);
            }
            dtGdViewCortes.DataSource = this.lstInd;
            configurarGrilla();

        }

        /// <summary>
        /// Abre el formulario hijo para agregar productos
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevaPrenda nuevoCorte = new frmNuevaPrenda();
            
            DialogResult rta = nuevoCorte.ShowDialog();

            try
            {
                if (rta == DialogResult.OK)
            {
                
                    

                    
                        if (nuevoCorte.chkJogging.Checked)
                        {
                            Joggings corte = new Joggings(nuevoCorte.t1.Numero, nuevoCorte.t2.Numero, nuevoCorte.t3.Numero, nuevoCorte.t4.Numero, nuevoCorte.t5.Numero, nuevoCorte.chkVariante.Checked, (enumMarca)nuevoCorte.cbMarca.SelectedIndex, nuevoCorte.txtModelo.Text);
                            FB += corte;
                        }
                        else
                        {
                            Buzos corte = new Buzos(nuevoCorte.t1.Numero, nuevoCorte.t2.Numero, nuevoCorte.t3.Numero, nuevoCorte.t4.Numero, nuevoCorte.t5.Numero, nuevoCorte.chkVariante.Checked, (enumMarca)nuevoCorte.cbMarca.SelectedIndex, nuevoCorte.txtModelo.Text);
                            FB += corte;
                        }
                    
               
               
                ActualizarGrilla();
            }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if(this.lstInd.Count!=0)
            {
                this.dtGdViewCortes.DataSource = this.lstInd;
            }


            configurarGrilla();

        }
        /// <summary>
        /// Abre el formulario hijo para modificar productos
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int id = 0;
                try
                {
                    
                    id = Convert.ToInt32(this.dtGdViewCortes.CurrentRow.Cells[0].Value);
                }
                catch
                {
                    throw new PrendaNoEncontradaException("Seleccione un corte en la tabla");
                }
                
                int variante = -1;
                int cantOG = 0;
                int cantNW = 0;
                Indumentaria corte;
                if(this.FB.BuscarBuzo(id)!=null)
                {
                     corte = this.FB.BuscarBuzo(id);
                }
                else
                {
                     corte = this.FB.BuscarJogging(id);
                }
                cantOG += corte.S;
                cantOG += corte.M;
                cantOG += corte.L;
                cantOG += corte.XL;
                cantOG += corte.XXL;
                frmNuevaPrenda modificarCorte = new frmNuevaPrenda();
                modificarCorte.Text = "Modificar corte";
                modificarCorte.chkJogging.Enabled = false;
                modificarCorte.chkBuzo.Enabled = false;

                if (corte is Buzos)
                {
                    if (corte.Variante == "Con capucha")
                    {
                        modificarCorte.chkVariante.Checked = true;
                        variante = 1;
                    }
                    else
                    {
                        modificarCorte.chkVariante.Checked = false;
                        variante = 2;
                    }
                }
                else
                {
                    if (corte.Variante == "Con punio")
                    {
                        modificarCorte.chkVariante.Checked = true;
                        variante = 3;
                    }
                    else
                    {
                        modificarCorte.chkVariante.Checked = false;
                        variante = 4;
                    }
                }
                
                if (corte.Tipo == enumPrenda.Buzo)
                {
                    modificarCorte.chkBuzo.Checked = true;
                }
                else
                {
                    modificarCorte.chkJogging.Checked = true;

                }


                modificarCorte.cbMarca.SelectedIndex = (int)corte.Marca;

                modificarCorte.lblId.Text = corte.Id.ToString();
                modificarCorte.txtModelo.Text = corte.Modelo;

                modificarCorte.t1.EditText = corte.S.ToString();
                modificarCorte.t2.EditText = corte.M.ToString();
                modificarCorte.t3.EditText = corte.L.ToString();
                modificarCorte.t4.EditText = corte.XL.ToString();
                modificarCorte.t5.EditText = corte.XXL.ToString();
                DialogResult rta = modificarCorte.ShowDialog();

                if (rta == DialogResult.OK)
                {

                    cantNW += modificarCorte.t1.Numero;
                    cantNW += modificarCorte.t2.Numero;
                    cantNW += modificarCorte.t3.Numero;
                    cantNW += modificarCorte.t4.Numero;
                    cantNW += modificarCorte.t5.Numero;
                    if(cantNW > 0)
                    {
                        if (cantNW > cantOG)
                        {
                            int diferencia = cantNW - cantOG;
                            if (!(FB.EspacioDisponible() >= diferencia))
                            {
                                throw new SinEspacioException();
                            }
                        }

                        if (variante == -1)
                        {
                            throw new Exception("Ocurrio un error al modificar");
                        }
                        if (modificarCorte.chkVariante.Checked)
                        {
                            if (variante == 1)
                            {
                                corte.Variante = "Con capucha";
                            }
                            else
                            {

                                corte.Variante = "Con punio";

                            }
                        }
                        else
                        {
                            if (variante == 2)
                            {
                                corte.Variante = "Sin capucha";
                            }
                            else
                            {

                                corte.Variante = "Sin punio";

                            }
                        }



                        corte.Modelo = modificarCorte.txtModelo.Text;
                        corte.Marca = (enumMarca)modificarCorte.cbMarca.SelectedIndex;

                        corte.S = modificarCorte.t1.Numero;
                        corte.M = modificarCorte.t2.Numero;
                        corte.L = modificarCorte.t3.Numero;
                        corte.XL = modificarCorte.t4.Numero;
                        corte.XXL = modificarCorte.t5.Numero;

                    }
                    else
                    {
                        throw new CorteVacioException();
                    }
                    
                    

                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            ActualizarGrilla();
        }
        /// <summary>
        /// Configura el estilo de la grilla
        /// </summary>
        private void configurarGrilla()
        {
            this.dtGdViewCortes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtGdViewCortes.MultiSelect = false;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            style.Font = new Font(this.dtGdViewCortes.Font, FontStyle.Bold);

            this.dtGdViewCortes.DefaultCellStyle = style;
            this.dtGdViewCortes.ColumnHeadersDefaultCellStyle = style;

            foreach (DataGridViewRow item in this.dtGdViewCortes.Rows)
            {
                if ((this.lstInd[item.Index]) is Buzos)
                {
                    item.DefaultCellStyle.BackColor = Color.Coral;
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
        /// <summary>
        /// Elimina el corte previamente seleccionado
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                try
                {
                    id = Convert.ToInt32(this.dtGdViewCortes.CurrentRow.Cells[0].Value);
                    
                }
                catch(Exception)
                {
                    throw new PrendaNoEncontradaException("Seleccione un corte en la tabla");
                }

                Indumentaria corte;
                if (this.FB.BuscarBuzo(id) != null)
                {
                    corte = this.FB.BuscarBuzo(id);
                }
                else
                {
                    corte = this.FB.BuscarJogging(id);
                }
                if (MessageBox.Show("¿Seguro(a) que desea eliminar el corte?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FB -= corte;
                }
                ActualizarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Exporta todos los datos de la fabrica a un archivo XML
        /// </summary>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if(Fabrica.Guardar(this.FB))
                {
                    MessageBox.Show("Exportado con exito");
                }
            }catch(SerializerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Importa todos los datos de la fabrica desde un archivo XML
        /// </summary>
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.FB.Buzos.Clear();
                this.FB.Joggings.Clear();
                this.lstInd.Clear();
                dtGdViewCortes.DataSource = null;
                this.FB = Fabrica.Leer();
                if(this.FB!=null)
                {
                    MessageBox.Show("Importado con exito");

                }
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
