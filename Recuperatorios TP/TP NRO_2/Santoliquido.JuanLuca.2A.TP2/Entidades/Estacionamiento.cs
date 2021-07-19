
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int _espacioAutoCamioneta;
        private int _espacioMoto;
        private List<Vehiculo> _vehiculos;


        /// <summary>
        /// propiedad: carga los atributos
        /// </summary>
     
        public List<Vehiculo> Vehiculos
        {
            get { return _vehiculos; }
            set { _vehiculos = value; }
        }
        
        /// <summary>
        /// propiedad: carga los atributos
        /// </summary>
        public int EspacioAutoCamioneta
        { 
            get { return _espacioAutoCamioneta; } 
            set { _espacioAutoCamioneta = value; } 
        }

        public int EspacioMoto
        {
            get { return _espacioMoto; }
            set { _espacioMoto = value; }
        }

        /// <summary>
        /// Constructor por defecto: inicializa los atributos
        /// </summary>
        public Estacionamiento()
        {
            this.Vehiculos = new List<Vehiculo>();
            this._espacioAutoCamioneta = 75;
            this._espacioMoto = 35;

             

        }

        /// <summary>
        /// Constructor: inicializa los atributos
        /// </summary>
        /// <param name="espacioAutoCamio">int</param>
        /// /// <param name="espacioMoto">int</param>
        public Estacionamiento(int espacioAutoCamio, int espacioMoto) : this()
        {
            this._espacioAutoCamioneta = espacioAutoCamio;
            this._espacioMoto = espacioMoto;
        }
        
        /// <summary>
        /// compara estacionamiento con un vehiculo
        /// </summary>
        /// <param name="e">Estacionamiento</param>
        /// <param name="v">Vehiculo</param>
        /// <returns> Devuelve TRUE o FALSE de acuerdo si contiene el vehiculo o no</returns>
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool ret = false;

            if ((object)e != null && (object)v != null)
            {
               
                    foreach (Vehiculo item in e._vehiculos)
                    {
                        if (item.Patente == v.Patente)
                        {
                            ret = true;
                        }
                    }
                
                
                
            }
            return ret;
        }

        /// <summary>
        /// compara un estacionamiento y un vehiculo
        /// </summary>
        /// <param name="e">Estacionamiento</param>
        /// <param name="v">Vehiculo</param>
        /// <returns> Devuelve TRUE o FALSE de acuerdo si contiene el vehiculo o no</returns>
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }



        /// <summary>
        /// agrega un vehiculo al estacionamiento si es que no existe o tiene espacio
        /// </summary>
        /// <param name="e">Estacionamiento</param>
        /// <param name="v">Vehiculo</param>
        /// <returns> Devuelve true or false si puede agregarlo</returns>
        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            if ((object)e != null && (object)v != null)
            {
            if (e != v)
            {
                   
                    if(v is Auto || v is Camioneta)
                    {
                        e.EspacioAutoCamioneta--;
                        
                    }else
                    {
                        e.EspacioMoto--;
                    }
                    e.Vehiculos.Add(v);
                    return true;



                }

            }
           

            return false;
        }

        /// <summary>
        /// Si el vehiculo se encuentra en el estacionamiento se retirara
        /// </summary>
        /// <param name="e">Estacionamiento</param>
        /// <param name="v">Vehiculo</param>
        /// <returns> Devuelve true or false si logro eliminarlo</returns>
        public static bool operator -(Estacionamiento e, Vehiculo v)
        {
            if((object)e != null && (object)v != null)
            {

                if (e == v)
                {
                    if (v is Auto || v is Camioneta)
                    {
                        e.EspacioAutoCamioneta++;

                    }
                    else
                    {
                        e.EspacioMoto++;
                    }
                    e.Vehiculos.Remove(v);
                    return true;
                }
            }
              
            return false;
        }
        public Vehiculo BuscarVehiculo(string patente)
        {
            foreach (Vehiculo item in this.Vehiculos)

                {
                    if (item.Patente == patente)
                    {

                        return item;

                    }
                }

            
            return null;
        }

    }
}
