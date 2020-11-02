
using System.Text;
using System.Text.RegularExpressions;
using Excepciones;
namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion
        #region PROPIEDADES

        /// <summary>
        /// Propiedad de apellido, valida que este en formato correcto
        /// </summary>
        public string Apellido
        {
            get{ return this.apellido; }


            set
            {
                this.apellido = ValidarNombreApellido(value);


            }
                
        }
        /// <summary>
        /// Propiedad de DNI, valida que este en formato correcto
        /// </summary>
        public int Dni 
        { 
            get { return this.dni; }

            set
            {
                this.dni=ValidarDni(Nacionalidad,value);
                
            }
                
        }
        /// <summary>
        /// Propiedad de DNI string, valida el formato
        /// </summary>
        public string StringToDni
        {

            set
            {

                this.dni = ValidarDni(this.nacionalidad, value);


            }
        }
        /// <summary>
        /// Propiedad de nombre, valida que el nombre este en formato correcto
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }

        }
        /// <summary>
        /// Propiedad de Nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
#endregion
        #region VALIDADORES
        /// <summary>
        /// Valida que el nombre o apellido este en el formato correcto
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            Regex reg = new Regex("^[a - zA - Z] +$");
            if (reg.IsMatch(dato) == false)
            {
                dato = "";
            }

            return dato;
        }
       
        /// <summary>
        /// Valida que el DNI sea correcto de acuerdo a la nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && dato > 89999999)
            {
                throw new NacionalidadInvalidaException();
            }

            if ( dato < 90000000 && nacionalidad == ENacionalidad.Extranjero)
            {
                throw new NacionalidadInvalidaException();
            }

            if (dato > 99999999 || dato < 1)
            {
                throw new DniInvalidoException();
            }

            return dato;
        }
        /// <summary>
        /// Valida que el DNI string sea correcto de acuerdo a la nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nac, string dni)
        {
            bool ret = false;
            int DniAux = 0;


            ret = int.TryParse(dni, out DniAux);
            if (ret == true)
            {
                Dni = DniAux;

            }
            else
            {
                throw new DniInvalidoException();
            }

            return DniAux;
        }

        #endregion

        #region enumerado
        public enum ENacionalidad
        {
            Argentino,
                Extranjero
        }
        #endregion
        #region constructores

        /// <summary>
        /// Constructor por defecto de persona
        /// </summary>
        public Persona()
        {
            
        }

        /// <summary>
        /// Constructor de persona de string nombre, string apellido, ENacionalidad nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;

        }
        /// <summary>
        /// Constructor de persona de dni int
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            Dni = dni;
        }
        /// <summary>
        /// Constructor de persona dni string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            StringToDni = dni;
        }
        #endregion
        #region sobrecargas
        /// <summary>
        /// Muestra la informacion de persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO : "+Nombre+", "+Apellido);
            sb.AppendLine("Nacionalidad: " +Nacionalidad);

            return sb.ToString();
        }
        #endregion


    }
}
