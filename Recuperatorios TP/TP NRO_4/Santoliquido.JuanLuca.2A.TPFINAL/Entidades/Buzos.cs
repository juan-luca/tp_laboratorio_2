using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Buzos : Indumentaria
    {
        private bool capucha;
        
        

        public bool Capucha
        {
            get
            {
                return this.capucha;
            }

            set
            {
                this.capucha = value;
            }

        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Buzos():base()
        {
            capucha = false;
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
        public Buzos(int T1, int T2, int T3, int T4, int T5, bool Capucha, EMarca marca, string modelo) : base(T1, T2, T3, T4, T5, EPrenda.Buzo, marca, modelo, Capucha ? "Con capucha" : "Sin capucha")
        {


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
        public Buzos(int id,int T1, int T2, int T3, int T4, int T5, bool Capucha, EMarca marca, string modelo) : base(id,T1, T2, T3, T4, T5, EPrenda.Buzo, marca, modelo, Capucha ? "Con capucha" : "Sin capucha")
        {

        }

       /* public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());

            if (this.Capucha)
            {
                sb.AppendLine("Con capucha");
            }
            else
            {
                sb.AppendLine("Sin capucha");
            }

            return sb.ToString();
        }*/
        /*
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Total de buzos: "+CantidadT1+CantidadT2+CantidadT3+CantidadT4+CantidadT5);
            sb.AppendLine("Talle S: "+CantidadT1);
            sb.AppendLine("Talle M: ");
            sb.AppendLine("Talle L: ");
            sb.AppendLine("Talle XL: ");
            sb.AppendLine("Talle XXL: ");
            sb.AppendLine("Marca: ");
            sb.AppendLine("Tipo: ");
            return "";
        }*/
    }
}
