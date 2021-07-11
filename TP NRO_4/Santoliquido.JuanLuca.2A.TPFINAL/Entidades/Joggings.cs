using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Joggings : Indumentaria
    {
        private bool punio;

        public bool Punio
        { 
            get
            { 
                return this.punio;
            }
                
            set
            {
                this.punio = value;
            }
                
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Joggings():base()
        {
            punio = false;
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
        public Joggings(int T1, int T2, int T3, int T4, int T5, bool Punio, EMarca marca, string modelo) : base(T1, T2, T3, T4, T5, EPrenda.Jogging, marca, modelo, Punio ? "Con punio" : "Sin punio")
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
        public Joggings(int id,int T1, int T2, int T3, int T4, int T5,bool Punio, EMarca marca, string modelo) :base(id,T1,T2,T3,T4,T5,EPrenda.Jogging, marca,modelo,Punio ? "Con punio" : "Sin punio")
        {

        }



    }
}
