using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
   public class PrendaRepetidaException: Exception
    {
        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje por defecto
        /// </summary>
        public PrendaRepetidaException(): base("Esta prenda ya existe")
        {
        }
        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje indicado
        /// <param name="mensaje">string</param>
        /// </summary>
        public PrendaRepetidaException(string msg): base(msg)
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje y el trazo de la excepcion
        /// <param name="innerException">Exception</param>
        /// </summary>
        public PrendaRepetidaException(Exception innerException): base("Este codigo de prenda ya existe", innerException)
        {
        }
    }
}
