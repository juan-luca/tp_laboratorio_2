using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Serializer
{
    public class ImpExpXML<T>  : ISerializer<T>
    {
        /// <summary>
        /// Exportara los datos en un formato XML
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns>Devolverá true en caso de poder guardarlo</returns>
        public bool Guardar(string path, T data)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(path, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, data);
                return true;
            }
            catch (Exception ex)
            {
                throw new SerializerException(ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Importara datos desde un archivo XML
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Leer(string path, out T data)
            {
                XmlTextReader reader = null;
                XmlSerializer serializer = null;
                try
                {
                    reader = new XmlTextReader(path);
                    serializer = new XmlSerializer(typeof(T));
                    data = (T)serializer.Deserialize(reader);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new SerializerException(ex);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }

            }
        
    }
}
