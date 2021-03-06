﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Extensor;

namespace FabricaTextil
{
    public partial class frmPrincipal : Form
    {
        public Fabrica FB;
        private List<Indumentaria> lstInd;
        private DataTable dtInd;
        private AccesoDatos _acceso;
        Thread hiloActualizador;
        private bool pauseThread = false;
        private int rowSelected = -1;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
            this.FB = new Fabrica();
            this._acceso = new AccesoDatos();
            this.dtInd = new DataTable();
            this.dtInd = _acceso.LoadDTFromBD();
            this.lstInd = new List<Indumentaria>();
            this.btnImport.Click += new System.EventHandler(this.Importar);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);

            //asocio el evento
            this._acceso.SinTelaEvent += SinTela;


            this.hiloActualizador = new Thread(this.ActualizarGrilla);
         


        }
        /// <summary>
        /// Refresca la grilla
        /// </summary>
        public void ActualizarGrilla()
        {
            try
            {
                while (this.pauseThread == false)
                {
                    Thread.Sleep(500);
                    
                    if (this.dtGdViewCortes.SelectedRows.Count > 0)
                    {
                        rowSelected = this.dtGdViewCortes.SelectedRows[0].Index;
                    }
                       
                    if (this.dtGdViewCortes.InvokeRequired)
                    {
                    this.dtGdViewCortes.BeginInvoke((MethodInvoker)delegate ()
                    {
                        dtGdViewCortes.DataSource = null;
                        this.dtInd = _acceso.LoadDTFromBD();

                        dtGdViewCortes.DataSource = this.dtInd;
                        ConfigurarGrilla();
                        
                    });
                        if (this.lblMtsTela.InvokeRequired)
                        {
                            this.lblMtsTela.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.lblMtsTela.Text = this._acceso.TelaDisponibleBD().ToString();

                            });

                        }
                    }       
                }
            }
            catch(Exception)
            {

            }
            

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
                if(nuevoCorte.t1.Numero + nuevoCorte.t2.Numero + nuevoCorte.t3.Numero + nuevoCorte.t4.Numero + nuevoCorte.t5.Numero> 0)
                    {
                        /*if (_acceso.TelaDisponibleBD() > nuevoCorte.t1.Numero*this.FB.costo.+ nuevoCorte.t2.Numero + nuevoCorte.t3.Numero + nuevoCorte.t4.Numero + nuevoCorte.t5.Numero)
                        {*/
                            if (nuevoCorte.chkJogging.Checked)
                            {
                            double mtsJogging = 0;
                            mtsJogging = nuevoCorte.t1.Numero * this.FB.costo.JT1 + nuevoCorte.t2.Numero * this.FB.costo.JT2 + nuevoCorte.t3.Numero * this.FB.costo.JT3 + nuevoCorte.t4.Numero * this.FB.costo.JT4 + nuevoCorte.t5.Numero * this.FB.costo.JT5;
                           /* if (_acceso.TelaDisponibleBD() > mtsJogging && this._acceso.UpdateTela(mtsJogging * -1))
                            {*/
                                Joggings corte = new Joggings(nuevoCorte.t1.Numero, nuevoCorte.t2.Numero, nuevoCorte.t3.Numero, nuevoCorte.t4.Numero, nuevoCorte.t5.Numero, nuevoCorte.chkVariante.Checked, (EMarca)nuevoCorte.cbMarca.SelectedIndex, nuevoCorte.txtModelo.Text);

                                if (this._acceso.InsertarCorte(corte) && this._acceso.UpdateTela(mtsJogging*-1))
                                {
                                    MessageBox.Show("Se agrego el corte con exito");
                                }/*else
                                {
                                    throw new TelaInsuficienteException();
                                }*/
                            //}
                                

                            }
                            else
                            {
                            double mtsBuzo = 0;
                            mtsBuzo = nuevoCorte.t1.Numero * this.FB.costo.BT1 + nuevoCorte.t2.Numero * this.FB.costo.BT2 + nuevoCorte.t3.Numero * this.FB.costo.BT3 + nuevoCorte.t4.Numero * this.FB.costo.BT4 + nuevoCorte.t5.Numero * this.FB.costo.BT5;

                               /* if (_acceso.TelaDisponibleBD() > mtsBuzo && this._acceso.UpdateTela(mtsBuzo * -1))
                                {*/
                                    Buzos corte = new Buzos(nuevoCorte.t1.Numero, nuevoCorte.t2.Numero, nuevoCorte.t3.Numero, nuevoCorte.t4.Numero, nuevoCorte.t5.Numero, nuevoCorte.chkVariante.Checked, (EMarca)nuevoCorte.cbMarca.SelectedIndex, nuevoCorte.txtModelo.Text);
                                    if (this._acceso.InsertarCorte(corte) && this._acceso.UpdateTela(mtsBuzo * -1))
                                    {
                                        MessageBox.Show("Se agrego el corte con exito");
                                    }/*else
                                    {
                                        throw new TelaInsuficienteException();
                                    }

                                }  */ 
                            }
                        /*}
                        else
                        {
                            throw new SinEspacioException();
                        }*/
                    }else
                    {
                        throw new CorteVacioException();
                    }
                    
            }
            }
            catch (TelaInsuficienteException)
            {

                MessageBox.Show("No hay mas espacio!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SinTela(object sender, EventArgs e)
        {
            if(sender is double)
            {
                if(_acceso.TelaDisponibleBD()< (double)sender)
                {
                    throw new TelaInsuficienteException();
                }
            }
            
                
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if(this.lstInd.Count!=0)
            {
                this.dtGdViewCortes.DataSource = this.lstInd;
            }
            


            ConfigurarGrilla();
           this.hiloActualizador.Start();

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
                double mtsOG = 0;
                double mtsNW = 0;
                double diferenciaMts = 0;
                Indumentaria corte = this._acceso.BuscarCorte(id);
                if(corte is Buzos)
                {
                    mtsOG += corte.S*this.FB.costo.BT1;
                    mtsOG += corte.M * this.FB.costo.BT2;
                    mtsOG += corte.L * this.FB.costo.BT3;
                    mtsOG += corte.XL * this.FB.costo.BT4;
                    mtsOG += corte.XXL * this.FB.costo.BT5;
                }
                else
                {
                    mtsOG += corte.S * this.FB.costo.JT1;
                    mtsOG += corte.M * this.FB.costo.JT2;
                    mtsOG += corte.L * this.FB.costo.JT3;
                    mtsOG += corte.XL * this.FB.costo.JT4;
                    mtsOG += corte.XXL * this.FB.costo.JT5;
                }

                
                frmNuevaPrenda modificarCorte = new frmNuevaPrenda();
                modificarCorte.Text = "Modificar corte";
                modificarCorte.chkJogging.Enabled = false;
                modificarCorte.chkBuzo.Enabled = false;

                if (corte.Tipo == EPrenda.Buzo)
                {
                    modificarCorte.chkBuzo.Checked = true;
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
                    modificarCorte.chkJogging.Checked = true;
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

                    
                    if (corte is Buzos)
                    {
                        mtsNW += modificarCorte.t1.Numero * this.FB.costo.BT1;
                        mtsNW += modificarCorte.t2.Numero * this.FB.costo.BT2;
                        mtsNW += modificarCorte.t3.Numero * this.FB.costo.BT3;
                        mtsNW += modificarCorte.t4.Numero * this.FB.costo.BT4;
                        mtsNW += modificarCorte.t5.Numero * this.FB.costo.BT5;
                    }
                    else
                    {
                        mtsNW += modificarCorte.t1.Numero * this.FB.costo.JT1;
                        mtsNW += modificarCorte.t2.Numero * this.FB.costo.JT2;
                        mtsNW += modificarCorte.t3.Numero * this.FB.costo.JT3;
                        mtsNW += modificarCorte.t4.Numero * this.FB.costo.JT4;
                        mtsNW += modificarCorte.t5.Numero * this.FB.costo.JT5;
                    }
                    diferenciaMts = mtsNW - mtsOG;
                    if (mtsNW > 0)
                    {
                        if (mtsNW > mtsOG)
                        {
                             
                            
                            
                            if (!(_acceso.TelaDisponibleBD() >= diferenciaMts))
                            {
                                throw new TelaInsuficienteException();
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
                        corte.Marca = (EMarca)modificarCorte.cbMarca.SelectedIndex;

                        corte.S = modificarCorte.t1.Numero;
                        corte.M = modificarCorte.t2.Numero;
                        corte.L = modificarCorte.t3.Numero;
                        corte.XL = modificarCorte.t4.Numero;
                        corte.XXL = modificarCorte.t5.Numero;

                        

                        if(this._acceso.UpdateCorte(corte) && this._acceso.UpdateTela(diferenciaMts*-1))
                        {
                            MessageBox.Show("Se modifico el corte con exito");
                        }

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


        }
        /// <summary>
        /// Configura el estilo de la grilla
        /// </summary>
        private void ConfigurarGrilla()
        {
            this.dtGdViewCortes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtGdViewCortes.MultiSelect = false;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            //Formateo de la  fuentes
            style.Font = new Font(this.dtGdViewCortes.Font, FontStyle.Bold);

            this.dtGdViewCortes.DefaultCellStyle = style;
            this.dtGdViewCortes.ColumnHeadersDefaultCellStyle = style;
            //Coloreo de las filas segun su contenido
            foreach (DataGridViewRow item in this.dtGdViewCortes.Rows)
            {
                if (item.Cells[6].Value!=null)
                {
                    if (item.Cells[6].Value.ToString() == "Buzo")
                    {
                        item.DefaultCellStyle.BackColor = Color.Coral;
                    }
                    else
                    {
                        item.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }else
                {
                    item.DefaultCellStyle.BackColor = Color.Green;
                }
                
            }
            //mantenemos la fila anteriormente seleccionada
            if (rowSelected >= 0)
            {
                this.dtGdViewCortes.Rows[rowSelected].Selected = true;
                this.dtGdViewCortes.CurrentCell = this.dtGdViewCortes[0, rowSelected];
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

                
                if (MessageBox.Show("¿Seguro(a) que desea eliminar el corte?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this._acceso.DeleteCorte(id);
                }
               
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
                
                this.FB.Buzos.Clear();
                this.FB.Joggings.Clear();
                this.lstInd.Clear();
                this.FB = _acceso.loadFb(this.FB);

                if(FB.GuardarArchivo())
                {
                    

                    MessageBox.Show("Exportado con exito");

                }

            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }
        /// <summary>
        /// Importa todos los datos de la fabrica desde un archivo XML
        /// </summary>
        private void Importar(object sender, EventArgs e)
        {
            try
            {
                
                this.FB.Buzos.Clear();
                this.FB.Joggings.Clear();
                this.lstInd.Clear();
                dtGdViewCortes.DataSource = null;
                this.FB = Fabrica.Leer();
                this._acceso.ReemplazarTela(this.FB.TelaDisponible);
                foreach(Buzos b in this.FB.Buzos)
                {
                    this.lstInd.Add(b);

                }
                foreach (Joggings j in this.FB.Joggings)
                {
                    this.lstInd.Add(j);

                }
                _acceso.CargarBdFromLst(this.lstInd);


                if (this.lstInd.Count==_acceso.CountBD())
                {
                    MessageBox.Show("Importado con exito");

                }else
                {
                    throw new Exception("No se logro importar con exito");
                }
            
                this.FB.Buzos.Clear();
                this.FB.Joggings.Clear();
                this.lstInd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Al cerrar el formulario cambia la bandera para que no se siga ejecutando el hilo
        /// </summary>
        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            pauseThread = true;
        }

        private void btnAgregarMtsTela_Click(object sender, EventArgs e)
        {
            try
            {
                this.FB.TelaDisponible += this.txtAddTela.Numero;
                this._acceso.UpdateTela(this.txtAddTela.Numero);
                this.txtAddTela.EditText = "0";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblMtsTela.Text = this._acceso.TelaDisponibleBD().ToString();
        }
    }
}
