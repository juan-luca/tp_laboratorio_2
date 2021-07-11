using System;

namespace Excepciones
{
    public sealed class SinEspacioException: Exception
    {
        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje por defecto
        /// </summary>
        public SinEspacioException(): base("No hay mas espacio")
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos indicando el mensaje
        /// <param name="msg">string</param>
        /// </summary>
        public SinEspacioException(string msg): base(msg)
        {
        }
    }
}
