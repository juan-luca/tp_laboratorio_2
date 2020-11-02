

using EntidadesAbstractas;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Archivos;
using System;
using System.Text;

namespace ClasesInstanciables
{
    public class Jornada
    {
        

         #region atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion
        #region PROPIEDADES
       
        /// <summary>
        /// Propiedad de instructor
        /// </summary>
        public Profesor Instructor 
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value; 
            }
                
        }
        /// <summary>
        /// Propiedad de clase
        /// </summary>
        public Universidad.EClases Clase 
        { 
            get
            {
                return this.clase;
            }

            set
            {
                this.clase = value;
            }
        }
        /// <summary>
        /// Propiedad de la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos 
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        #endregion


        #region METODOS
        /// <summary>
        /// guarda la informacion de la jornada para 
        /// </summary>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada j)
        {
            Texto archivo = new Texto();

            string path = AppDomain.CurrentDomain.BaseDirectory + "Texto.txt";

            return archivo.Guardar(path, j.ToString());
        }


        public static string Leer()
        {
            Texto archivo = new Texto();

            string path = AppDomain.CurrentDomain.BaseDirectory + "Texto.txt";
            archivo.Leer(path, out string datos);

            return datos;
        }
        #endregion
        #region constructores
        public Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;

        }

        #endregion
        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASE DE "+this.clase.ToString()+" POR "+this.instructor);
            sb.AppendLine("ALUMNOS: ");

            foreach (Alumno alumno in this.alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            sb.AppendLine("<------------------------------------------------------------->");

            return sb.ToString();
        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool ret = false;
            foreach(Universitario item in j.alumnos)
            {
                if(item.Equals(a))
                {
                    ret = true;
                }
            }

            return ret;
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
       
        #endregion

    }
}
