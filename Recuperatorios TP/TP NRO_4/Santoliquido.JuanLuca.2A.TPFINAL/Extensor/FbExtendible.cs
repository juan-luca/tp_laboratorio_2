using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Serializer;
namespace Extensor
{
    public static class FbExtendible
    {
        public static bool GuardarArchivo(this Fabrica f)
        {

            ImpExpXML<Fabrica> xml = new ImpExpXML<Fabrica>();
            return xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Fabrica.xml", f);
        }
    }
}
