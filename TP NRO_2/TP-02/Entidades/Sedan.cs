using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        
        private ETipo tipo;

        /// <summary>
        /// Enumerado de tipos de SEDAN
        /// </summary>
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas,
            Monovolumen
        }



        #region PROPERTIES
        /// <summary>
        /// Los automoviles son MEDIANOS
        /// </summary>
        protected override ETamanio Tamanio
        {
            get => ETamanio.Mediano;
        }
        #endregion



        #region CONSTRUCTORES
        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
            this.tipo = ETipo.Monovolumen;
        }
        /// <summary>
        /// Asigna todos los valores correspondientes a la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// 
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca,chasis,color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Publica todos los datos del SEDAN.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            
            sb.AppendLine();
            sb.AppendLine("TAMAÑO : " + this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
