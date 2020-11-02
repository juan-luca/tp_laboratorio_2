using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    public class Profesor:Universitario
    {
        #region atributos
        private Queue<EClases> clasesDelDia;

        static Random random;
        #endregion



        #region METODOS
        /// <summary>
        /// Genera 1 clase aleatoria al profesor
        /// </summary>
        private void _randomClases()
        {
            clasesDelDia.Enqueue((EClases)random.Next(0, 3));
        }
        /// <summary>
        /// Muestra las 2 clases del profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DEL DIA ");
            foreach(Universidad.EClases item in clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Muestra los datos del profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {

            return base.MostrarDatos() + this.ParticiparEnClase() ;
        }
        #endregion
        #region constructores
        /// <summary>
        /// Constructor por defecto statico
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }


        /// <summary>
        /// Cosntructor defecto
        /// </summary>
        public Profesor():base()
        {
        }


        /// <summary>
        /// Constructor completo del profesor, asigna 2 clases
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }

        #endregion
        #region sobrecargas
        /// <summary>
        /// Hace publicos los datos de MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {



            return this.MostrarDatos();
        }
        /// <summary>
        /// Un profesor es igual a una clase si el da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, EClases clase)
        {
            bool ret = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if(item == clase)
                {
                    ret = true;
                }
               
            }
            return ret;
        }
        /// <summary>
        /// Un profesor es diferente a una clase si el no da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }
       
        #endregion
    }
}
