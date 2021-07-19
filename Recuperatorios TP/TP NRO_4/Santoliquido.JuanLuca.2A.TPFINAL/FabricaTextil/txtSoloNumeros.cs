using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class txtSoloNumeros : UserControl
    {
        private int numero=0;
        public txtSoloNumeros()
        {
            InitializeComponent();
        }



            public string EditText
            {
                get { return txtNumeros.Text; }
                set { txtNumeros.Text = value; }
            }

        public int Numero
        {
            get { return this.numero; }
        }
        public bool Error
            {
                get
                {
                    if (errorProvider1.GetError(txtNumeros).ToString() != string.Empty)
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
            }

            private void txtNumeros_KeyPress(object sender, KeyPressEventArgs v)
            {
                if (Char.IsDigit(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
               
            else
                {
                    v.Handled = true;
                    MessageBox.Show("Solo numeros enteros");
                }
            }

            

            private void txtNumeros_TextChanged(object sender, EventArgs e)
            {
            int.TryParse(txtNumeros.Text, out numero);
                if (txtNumeros.Text == string.Empty && numero<0)
                {
                    txtNumeros.Text = "0";
                }
            }

       
    }
}
