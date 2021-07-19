using Entidades;
using System;
using System.Windows.Forms;




namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        Validar v = new Validar();

        public FormCalculadora()
        {
            

            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.AddRange(new String[] { "+", "-", "*", "/" });
            this.Limpiar();
        }

       

      

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            double total;
            if(string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("Ingrese un numero en ambos campos por favor...", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }else
            {
                if(this.cmbOperador.Text!="+" && this.cmbOperador.Text != "-" && this.cmbOperador.Text != "*" && this.cmbOperador.Text != "/")
                {
                    this.cmbOperador.Text = "+";
                }

                total = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                if (total == double.MinValue)
                {
                    lblResultado.Text = "SYNTAX ERROR";
                }
                else
                {
                    lblResultado.Text = total.ToString();
                }


            }
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            double total = 0;

            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            total = Calculadora.Operar(numeroUno, numeroDos, operador);
            return total;
        }

      

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "+";
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosDecimales(e);
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosDecimales(e);
        }

        private void buttonDecToBin_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void buttonBinToDec_Click(object sender, EventArgs e)
        {

            string ResultadoParcial= Numero.BinarioDecimal(lblResultado.Text);
            if(ResultadoParcial!="-1")
            {
                lblResultado.Text = ResultadoParcial;
            }else
            {
                MessageBox.Show("El numero debe ser BINARIO para poder convertirlo a decimal", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea salir?",
               "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
