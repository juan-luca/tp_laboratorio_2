using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Indumentaria : IPrenda
    {
        private int id;
        private int cantidadT1=0;
        private int cantidadT2=0;
        private int cantidadT3=0;
        private int cantidadT4=0;
        private int cantidadT5=0;
        private enumPrenda _tipo;
        private enumMarca _marca;
        private string _modelo;
        private string _variante;


        #region IPrenda
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public int S 
        {
            get
            {
                return this.cantidadT1;
            }

            set
            {
                this.cantidadT1 = value;
            }
        }
        public int M
        {
            get
            {
                return this.cantidadT2;
            }

            set
            {
                this.cantidadT2 = value;
            }
        }
        public int L
        {
            get
            {
                return this.cantidadT3;
            }

            set
            {
                this.cantidadT3 = value;
            }
        }
        public int XL
        {
            get
            {
                return this.cantidadT4;
            }

            set
            {
                this.cantidadT4 = value;
            }
        }
        public int XXL
        {
            get
            {
                return this.cantidadT5;
            }

            set
            {
                this.cantidadT5 = value;
            }
        }

        public enumPrenda Tipo
        {

            get
            {
                return this._tipo;
            }

            set
            {
                this._tipo = value;
            }
        }

        public enumMarca Marca
        {

            get
            {
                return this._marca;
            }

            set
            {
                this._marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return this._modelo;
            }

            set
            {
                this._modelo = value;
            }
        }

        

        public string Variante
        {
            get
            {
                return this._variante;
            }

            set
            {
                this._variante = value;
            }
        }

        #endregion
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Indumentaria()
        {
            
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="T1">Cantidad del talle S</param>
        /// <param name="T2">Cantidad del talle M</param>
        /// <param name="T3">Cantidad del talle L</param>
        /// <param name="T4">Cantidad del talle XL</param>
        /// <param name="T5">Cantidad del talle XXL</param>
        /// <param name="tipo">Tipo de prenda</param>
        /// <param name="marca">Marca</param>
        /// <param name="modelo">Modelo</param>
        /// <param name="variante">Variante</param>
        public Indumentaria(int T1, int T2, int T3, int T4, int T5, enumPrenda tipo, enumMarca marca, string modelo, string variante) : this()
        {

            this.cantidadT1 = T1;
            this.cantidadT2 = T2;
            this.cantidadT3 = T3;
            this.cantidadT4 = T4;
            this.cantidadT5 = T5;
            this._tipo = tipo;
            this._marca = marca;
            this._modelo = modelo;
            this._variante = variante;

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// /// <param name="id">Id del corte</param>
        /// <param name="T1">Cantidad del talle S</param>
        /// <param name="T2">Cantidad del talle M</param>
        /// <param name="T3">Cantidad del talle L</param>
        /// <param name="T4">Cantidad del talle XL</param>
        /// <param name="T5">Cantidad del talle XXL</param>
        /// <param name="tipo">Tipo de prenda</param>
        /// <param name="marca">Marca</param>
        /// <param name="modelo">Modelo</param>
        /// <param name="variante">Variante</param>
        public Indumentaria(int id,int T1, int T2, int T3, int T4, int T5, enumPrenda tipo, enumMarca marca, string modelo, string variante) : this(T1,T2,T3,T4,T5,tipo,marca,modelo,variante)
        {
            this.id = id;

        }
        /// <summary>
        /// Imprime en pantalla los datos del corte
        /// </summary>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------------------------");
            sb.AppendLine("ID: "+this.id);
            sb.AppendLine("Talle S: " + this.cantidadT1.ToString());
            sb.AppendLine("Talle M: " + this.cantidadT2.ToString());
            sb.AppendLine("Talle L: " + this.cantidadT3.ToString());
            sb.AppendLine("Talle XL: " + this.cantidadT4.ToString());
            sb.AppendLine("Talle XXL: " + this.cantidadT5.ToString());
            sb.AppendLine("Marca: "+this.Marca);
            sb.AppendLine("Modelo: "+this.Modelo);
            sb.AppendLine("Tipo: "+this.Tipo);
            sb.AppendLine("Variante: "+this.Variante);
            sb.AppendLine("------------------------------------------------------------------");
            return sb.ToString();
        }

    }
}
