using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        /// <summary>
        /// Muestra el mensaje por defecto de error del DNI invalido
        /// </summary>
        public DniInvalidoException():base("El DNI ingresado es invalido")
        {

        }

        /// <summary>
        /// Muestra el mensaje de error del DNI invalido
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e) : base("El DNI ingresado es invalido", e)
        {
        }
        /// <summary>
        ///  Ingresa el mensaje de error dado previamente
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message) : base( message)
        {
        }
        /// <summary>
        /// Ingresa el mensaje de error dado previamente
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message, Exception e) : base(message, e)
        {
        }
    }
}
