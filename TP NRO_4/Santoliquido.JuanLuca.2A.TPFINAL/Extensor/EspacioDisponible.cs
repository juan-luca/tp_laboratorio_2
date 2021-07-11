using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
namespace Extensor
{
    public static class EspacioDisponible
    {
        /// <summary>
        /// Extiende la fabrica y verifica el espacio disponible
        /// </summary>
        /// <param name="FB"></param>
        /// <returns>Espacio disponible</returns>
        public static int Verificador(this Fabrica FB)
        {
            
            try
            {
                
                AccesoDatos _acceso = new AccesoDatos();
                int espacioOcupado = _acceso.EspacioOcupadoBD();
                if (espacioOcupado >= FB.EspacioTotal)
                {
                    throw new SinEspacioException();
                }else
                {
                    return FB.EspacioTotal-espacioOcupado;
                }

            }
            catch(Exception)
            {
                throw new SinEspacioException();
            }
            
        }
    }
}
