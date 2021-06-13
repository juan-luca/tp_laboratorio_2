using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class PrendaNoEncontradaException : Exception
    {

        /// <summary>
        /// Constructor: inicializa los atributos
        /// </summary>
        public PrendaNoEncontradaException() : base("No se pudo encontrar el corte en el stock.")
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje indciado
        /// <param name="msg">string</param>
        /// </summary>
        public PrendaNoEncontradaException(string msg) : base(msg)
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos
        /// <param name="innerException">Exception</param>
        /// </summary>
        public PrendaNoEncontradaException(Exception innerException) : base("No se pudo encontrar la prenda en el stock.", innerException)
        {

        }
    }
}
