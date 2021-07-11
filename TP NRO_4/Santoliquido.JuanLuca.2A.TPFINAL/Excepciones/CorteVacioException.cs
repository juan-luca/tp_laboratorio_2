using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class CorteVacioException : Exception
    {

        /// <summary>
        /// Constructor: inicializa los atributos
        /// </summary>
        public CorteVacioException() : base("El corte que intenta agregar / modificar se encuentra vacio.")
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje indciado
        /// <param name="msg">string</param>
        /// </summary>
        public CorteVacioException(string msg) : base(msg)
        {
        }

    }
}
