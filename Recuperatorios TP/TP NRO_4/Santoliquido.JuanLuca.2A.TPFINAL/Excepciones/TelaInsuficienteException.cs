using System;

namespace Excepciones
{
    public sealed class TelaInsuficienteException: Exception
    {
        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje por defecto
        /// </summary>
        public TelaInsuficienteException(): base("No hay mas espacio")
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos indicando el mensaje
        /// <param name="msg">string</param>
        /// </summary>
        public TelaInsuficienteException(string msg): base(msg)
        {
        }
    }
}
