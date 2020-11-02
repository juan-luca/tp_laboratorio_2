using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un archivo de tipo string en formato txt
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            bool ret = false;
            try
            {
                
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(datos);
                    ret = true;
                }

            }
            catch (ArchivosException e)
            {
                ret = false;
                throw new ArchivosException(e);
            }
            return ret;
        }
        /// <summary>
        /// Lee un archivo de formato .txt en string
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            bool ret = false;
            StringBuilder sb = new StringBuilder();
            try
            {
               
                using (StreamReader sr = new StreamReader(archivo))
                {
                    String linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(linea);
                        ret = true;
                    }

                }
            }
            catch (ArchivosException e)
            {
                ret = false;
                throw new ArchivosException(e);
            }
            datos = sb.ToString();
            return ret;
        }
    }

    
}
