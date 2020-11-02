
using EntidadesAbstractas;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    public sealed class Alumno:Universitario
    {

        #region atributos
        private EClases claseQueToma;
        private EEstadoCuenta estadoDeCuenta;
        #endregion
        

        #region enumerado
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion
        #region METODOS
        /// <summary>
        /// Muestra que clase toma el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {

            return "TOMA CLASES DE:"+this.claseQueToma+"\n";
        }

        /// <summary>
        /// Muestra todos los datos del alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + ParticiparEnClase() + "Estado de cuenta: "+this.estadoDeCuenta;
        }
        #endregion
        #region constructores

        /// <summary>
        /// Constructor de alumno por defecto
        /// </summary>
        public Alumno():base()
        {

        }
        /// <summary>
        /// Constructor de alumno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,EClases claseQueToma ):base(id,nombre,apellido,dni,nacionalidad)
        {

            this.claseQueToma = claseQueToma;

        }
        /// <summary>
        /// Constructor de alumno completo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id,nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoDeCuenta = estadoCuenta;
        }
        #endregion
        #region sobrecargas
        /// <summary>
        /// hace publico lo que muestra el metodo MostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
          
            

            return this.MostrarDatos();
        }
        /// <summary>
        /// Un alumno es igual a una clase solo si NO es deudor y toma la clase indicada
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, EClases clase)
        {

            return a.claseQueToma == clase && a.estadoDeCuenta != EEstadoCuenta.Deudor;
        }
        /// <summary>
        /// Un alumno es diferente a una clase solo si NO  toma la clase indicada
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, EClases clase)
        {
            return !(a == clase);
        }
       
        #endregion

    }
}
