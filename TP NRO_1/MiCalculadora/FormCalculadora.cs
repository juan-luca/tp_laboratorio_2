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
            this.ddlOperador.Items.AddRange(new String[] { "+", "-", "*", "/" });
        }

       

      

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            double total;
            if(string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("Ingrese un numero en ambos campos por favor...", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }else
            {
                total=Operar(this.txtNum1.Text, this.txtNum2.Text, this.ddlOperador.Text);
                if(total == double.MinValue)
                {
                    Resultado.Text = "SYNTAX ERROR";
                }
                else
                { 
                    Resultado.Text = total.ToString();
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
            this.txtNum1.Text = "";
            this.txtNum2.Text = "";
            this.Resultado.Text = "";
            this.ddlOperador.Text = "+";
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
            Resultado.Text = Numero.DecimalBinario(Resultado.Text);
        }

        private void buttonBinToDec_Click(object sender, EventArgs e)
        {

            string ResultadoParcial= Numero.BinarioDecimal(Resultado.Text);
            if(ResultadoParcial!="-1")
            {
                Resultado.Text = ResultadoParcial;
            }else
            {
                MessageBox.Show("El numero debe ser BINARIO para poder convertirlo a decimal", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }

      
    }
}
