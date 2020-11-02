using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException:Exception
    {
        /// <summary>
        /// Mensaje de error de la excepcion de los archivos
        /// </summary>
        public ArchivosException(Exception innerException) : base("No se pudo abrir el archivo ",innerException)
        {

        }
        

       
    }
}
