using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region PROPERTIES
        /// <summary>
        /// Las motos son CHICAS
        /// </summary>
        protected override ETamanio Tamanio
        {
            get => ETamanio.Chico;
        }
        #endregion



        #region CONSTRUCTORES
        /// <summary>
        /// Asigna todos los valores correspondientes a la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Publica todos los datos del CICLOMOTOR.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            
            sb.AppendLine();
            sb.AppendLine("TAMAÑO : " + this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion


    }
}
