using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {

        /// <summary>
        /// Muestra el mensaje por defecto de error del nacionaliad invalida
        /// </summary>
        public NacionalidadInvalidaException() : base("La nacionalidad no se condice con el DNI ingresado")
        {

        }
        /// <summary>
        /// Muestra el mensaje pasado como parametro de error del nacionaliad invalida
        /// </summary>
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
    }
}
