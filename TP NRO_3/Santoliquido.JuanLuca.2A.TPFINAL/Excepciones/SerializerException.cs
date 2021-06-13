using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class SerializerException : Exception
    {

        /// <summary>
        /// Constructor: inicializa los atributos
        /// </summary>
        public SerializerException(Exception innerException) : base("Ocurrio un error con el archivo seleccionado",innerException)
        {
        }

    }
}
