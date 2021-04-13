using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            setNumero = strNumero;
        }
        public string setNumero
        {
            set { 
                this.numero = validarNumero(value); 
            }
        }
        /// <summary>
        /// Recibe una cadena para intentar convertirla
        /// /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>si no puede convertirla, retornara 0</returns>
        public double validarNumero(string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }

        public static double operator +(Numero n1, Numero n2)
            {
            return n1.numero + n2.numero;
            }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if(n1.numero  > 0 && n2.numero > 0)
            {
                retorno = n1.numero / n2.numero;
            }

            return retorno;
        }
        /// <summary>
        /// Convierte el numero de decimal a binario luego de una operacion
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Devuelve el numero en binario en formato string</returns>
        public static string DecimalBinario(double num)
        {
            Int32 numero = Convert.ToInt32(num);

            String cadena = "";


            if (numero > 0)
            {

                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }

            }

            return cadena;
        }
       //Parsea el string y reutiliza la funcion anterior
        public static string DecimalBinario(string strNumero)
        {
            return DecimalBinario(double.Parse(strNumero));
        }


        /// <summary>
        /// Convierte un numero binario a decimal desde lblresultado
        /// </summary>
        /// <param name="strNumero">strNumero</param>
        /// <returns>retornará un string de acuerdo al resultado</returns>

        public static string BinarioDecimal(string strNumero)
        {
            int num = 0;
            char[] array = strNumero.ToCharArray();
            if(EsBinario(strNumero)==true)
            { 
                        Array.Reverse(array);
          
          

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == '1')
                        {
                    
                            if (i == 0)
                            {
                                num += 1;
                            }
                            else
                            {
                                num += (int)Math.Pow(2, i);
                            }
                        }

                    }   
            }
            else
            {
                return "-1";
            }
            return num.ToString();
        }
        /// <summary>
        /// Validará que el lblResultado.Text sea un numero binario
        /// </summary>
        /// <param name="strNumero">Lo recib</param>
        /// <returns>Devolverá true si es binario, o false si no lo es </returns>
        private static bool EsBinario(string strNumero)
        {
            for (int i = 0; i < strNumero.Length; i++)
            {
                if (strNumero.Substring(i, 1) != "0" && strNumero.Substring(i, 1) != "1")
                {
                    return false;
                }
            }
            return true;
        }


    }
}
