
using System.Text;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region atributos
        private int legajo;
        #endregion

        #region METODOS
        protected abstract string ParticiparEnClase();
        
        /// <summary>
        /// Muestra todos los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Legajo: " + this.legajo);

            return sb.ToString();
        }
        #endregion
        #region constructores
        /// <summary>
        /// Constructor por defecto de universitario
        /// </summary>
        public Universitario():base()
        {

        }
        /// <summary>
        /// Constructor de universitarion con el dni en string
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;

        }
            #endregion
        #region sobrecargas
        /// <summary>
        /// Un universitario es igual a otro si tiene mismo dni y legajo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Universitario)
            {
                if ((this.legajo == ((Universitario)obj).legajo || this.Dni == ((Universitario)obj).Dni))
                {
                    rta = true;
                }
                
            }

            return rta;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Un universitario es igual a otro si tiene mismo dni y legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {

            return pg1.Equals(pg2);
        }
        /// <summary>
        /// Un universitario es diferente a otro si tiene diferente dni y legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1==pg2);
        }

        #endregion
    }
}
