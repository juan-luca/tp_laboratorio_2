using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        

       
        #region atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;


        #endregion
        #region PROPIEDADES
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
        /// <summary>
        /// Propiedad de la lista de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        /// <summary>
        /// Propiedad de la lista de profesores
        /// </summary>
        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }


        }
        /// <summary>
        /// Indexador de Jornada
        /// </summary>
        public Jornada this[int i]
        {
            get
            {
                if(i>=0 && i<this.Jornadas.Count)
                {
                    return this.Jornadas[i];
                }
                else
                {
                    return null;
                }
                
            }
            set 
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i]=value;
                }
                else if(i== this.Jornadas.Count)
                {
                    this.Jornadas.Add(value);
                }
            }
        }
        #endregion
        #region METODOS
        /// <summary>
        /// Guarda en un .xml toda la informacion de la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad u)
        {
            Xml<Universidad> serializador = new Xml<Universidad>();

            string path = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";

            return serializador.Guardar(path, u);
        }


        /// <summary>
        /// Lee toda la informacion de la universidad desde un xml
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Xml<Universidad> lectorSerializado = new Xml<Universidad>();

            string path = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";


            Universidad ret;
            lectorSerializado.Leer(path, out ret);

            return ret;
        }
        
        /// <summary>
        /// Muestra la informacion de universidad
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad u)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            foreach (Jornada jornada in u.jornada)
            {
                sb.Append(jornada.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region enumerado
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #endregion
        #region constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion
        #region sobrecargas
        /// <summary>
        /// Hace publico los datos de MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        /// <summary>
        /// La univdersidad es igual al alumno si el es encuentra en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool ret = false;
           foreach(Alumno item in g.Alumnos)
            {
                if(item == a)
                {
                    ret = true;
                    break;
                }
            }

            return ret;
        }
        /// <summary>
        /// La univdersidad es igual al profesor si el se encuentra en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool ret = false;
            foreach (Profesor item in g.Profesores)
            {
                if (item == i)
                {
                    ret = true;
                    break;
                }
            }

            return ret;
        }

        /// <summary>
        /// La univdersidad es igual a la clase si algun profesor la da
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad g, EClases clases)
        {
            foreach (Profesor item in g.profesores)
            {
                if (item == clases)
                {
                    return item;
                }
            }

            throw new SinProfesorException();
        }
        /// <summary>
        /// Agrega un alumno a universidad si no existe previamente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
           if(u==a)
            {
                throw new AlumnoRepetidoException();
                
            }
           u.alumnos.Add(a);


            return u;
        }
        /// <summary>
        /// Agrega un profesor a universidad si no existe previamente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Profesores.Add(i);
            }

            return u;
        }
        /// <summary>
        /// Agrega una jornada a universidad 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, EClases clase)
        {
            Profesor profAux = (u == clase);

            Jornada jorAux = new Jornada(clase, profAux);
            
            foreach(Alumno item in u.alumnos)
            {
                if(item == clase)
                {
                    
                    jorAux += item;
                }
            }
            u.jornada.Add(jorAux);

            return u;
        }
        /// <summary>
        /// Un alumno es diferente de universidad si no se encuentra en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            


            return !(g==a);
        }
        /// <summary>
        /// Un profesor es diferente de universidad si no se encuentra en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            

            return !(g==i);
        }

        /// <summary>
        /// Una clase es diferente de universidad si ningun profesor la da
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad g, EClases clases)
        {
            foreach (Profesor item in g.profesores)
            {
                if (item != clases)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        
        #endregion

    }
}
