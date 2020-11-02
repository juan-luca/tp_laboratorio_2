using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        /// <summary>
        /// Muestra el mensaje por defecto de error del no existencia de profesores
        /// </summary>
        public SinProfesorException() : base("No hay profesor para la clase.")
        {

        }
        

      
    }
}
