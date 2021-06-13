
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializer;

namespace Entidades
{
    public class Fabrica
    {
        private int espacioTotal;
        private List<Buzos> _buzos;
        private List<Joggings> _joggings;


        /// <summary>
        /// propiedad: carga los atributos
        /// </summary>
     
        public List<Buzos> Buzos
        {
            get { return _buzos; }
            set { _buzos = value; }
        }
        public List<Joggings> Joggings
        {
            get { return _joggings; }
            set { _joggings = value; }
        }
        /// <summary>
        /// propiedad: carga los atributos
        /// </summary>
        public int EspacioTotal
        { 
            get { return espacioTotal; } 
            set { espacioTotal = value; } 
        }

        /// <summary>
        /// Constructor por defecto: inicializa los atributos
        /// </summary>
        public Fabrica()
        {
            this._buzos = new List<Buzos>();
            this._joggings = new List<Joggings>();

            this.espacioTotal = 1000;

             

        }

        /// <summary>
        /// Constructor: inicializa los atributos
        /// </summary>
        /// <param name="cantidad">int</param>
        public Fabrica(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }
        
        /// <summary>
        /// compara una fabrica y una prenda
        /// </summary>
        /// <param name="f">Fabrica</param>
        /// <param name="i">Indumentaria</param>
        /// <returns> Devuelve TRUE o FALSE de acuerdo si contiene la prenda la fabrica o no</returns>
        public static bool operator ==(Fabrica f, Indumentaria i)
        {
            bool ret = false;

            if ((object)f != null && (object)i != null)
            {
                if(i is Buzos)
                {
                    foreach (Buzos item in f.Buzos)
                    {
                        if (item.Id == i.Id)
                        {
                            ret = true;
                        }
                    }
                }
                else
                {
                    foreach (Joggings item in f.Joggings)
                    {
                        if (item.Id == i.Id)
                        {
                            ret = true;
                        }
                    }
                }
                
            }
            return ret;
        }

        /// <summary>
        /// compara un fabrica y un corte
        /// </summary>
        /// <param name="f">Fabrica</param>
        /// <param name="i">Indumentaria</param>
        /// <returns> Devuelve TRUE o FALSE de acuerdo si contiene el corte en la fabrica o no</returns>
        public static bool operator !=(Fabrica f, Indumentaria i)
        {
            return !(f == i);
        }

      

        /// <summary>
        /// agrega un corte a la fabrica si es que no existe o tiene espacio, si es q tiene por lo menos 1 prenda
        /// </summary>
        /// <param name="f">Fabrica</param>
        /// <param name="i">Indumentaria</param>
        /// <returns> Devuelve la fabrica</returns>
        public static Fabrica operator +(Fabrica f, Indumentaria i)
        {
            if ((object)f != null && (object)i != null)
            {
            if (f != i)
            {
                    if((i.S + i.M + i.L + i.XL + i.XXL)>0)
                    {
                        if(i is Buzos)
                        {
                            if (f.EspacioDisponible() > (i.S + i.M + i.L + i.XL + i.XXL))
                            {
                                i.Id = f.GenerarId();
                                f._buzos.Add((Buzos)i);
                            }
                            else
                            {
                                throw new SinEspacioException();
                            }
                        }
                        else
                        {
                            if (f.EspacioDisponible() > (i.S + i.M + i.L + i.XL + i.XXL))
                            {
                                i.Id = f.GenerarId();
                                f._joggings.Add((Joggings)i);
                            }
                            else
                            {
                                throw new SinEspacioException();
                            }
                        }
                    }else
                    {
                        throw new CorteVacioException();
                    }
                    
               
            }
            else
            {
                throw new PrendaRepetidaException();
            }

            }
           

            return f;
        }

        /// <summary>
        /// Si el corte se encuentra en la fabrica se eliminara
        /// </summary>
        /// <param name="f">Fabrica</param>
        /// <param name="i">Indumentaria</param>
        /// <returns> Devuelve la fabrica</returns>
        public static Fabrica operator -(Fabrica f, Indumentaria i)
        {
            if((object)f != null && (object)i != null)
            {

                if (f == i)
                {
                    if(i is Buzos)
                    {
                        f._buzos.Remove((Buzos)i);
                    }else
                    {
                        f._joggings.Remove((Joggings)i);
                    }
                }
                else
                {
                    throw new PrendaNoEncontradaException();
                }
            }
              
            return f;
        }

        /// <summary>
        /// Verifica que espacio hay en la fabrica 
        /// </summary>
        /// <returns> Devuelve la cantidad de prendas que le quedan por almacenar</returns>
        public int EspacioDisponible()
        {
            try
            {
            int cantidadOcupada = 0;
            foreach (Buzos item in this._buzos)
            {
                cantidadOcupada += item.S + item.M + item.L + item.XL + item.XXL;
            }
                foreach (Joggings item in this._joggings)
                {
                    cantidadOcupada += item.S + item.M + item.L + item.XL + item.XXL;
                }

                return this.espacioTotal-cantidadOcupada;
            }
            catch (Exception )
            {
                throw new Exception();
            }
            
        }
        /// <summary>
        /// Genera el ID siguiente al ultimo creado
        /// </summary>
        /// <returns> Devuelve el primer ID libre o -1 si no lo encuentra</returns>
        private int GenerarId()
        {
            int primerIdDisponible = 0;
            
            try
            {
                foreach (Buzos item in this._buzos)
                {
                    primerIdDisponible = item.Id;
                }
                foreach (Joggings item in this._joggings)
                {
                    if(primerIdDisponible < item.Id)
                    {
                        primerIdDisponible = item.Id;
                    }
                }

                return primerIdDisponible + 1;
            }
            catch (Exception )
            {
                throw new Exception();
            }

            

        }

        
        /// <summary>
        /// Busca el corte con el id seleccionado
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> Devuelve el corte</returns>
        public Buzos BuscarBuzo(int id)
        {
            try
            {
                foreach (Buzos item in this._buzos)
                {
                    if (item.Id == id)
                    {

                        return item;

                    }
                }

            }
            catch (Exception)
            {
                throw new PrendaNoEncontradaException();
            }
            return null;
        }

        /// <summary>
        /// Busca el corte con el id seleccionado
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> Devuelve el corte</returns>
        public Joggings BuscarJogging(int id)
        {
            try
            {
                foreach (Joggings item in this._joggings)
                {
                    if (item.Id == id)
                    {

                        return item;

                    }
                }

            }
            catch (Exception)
            {
                throw new PrendaNoEncontradaException();
            }
            return null;
        }
        /// <summary>
        /// Serializa en un archivo los datos de la fabrica
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static bool Guardar(Fabrica f)
        {
            
                ImpExpXML<Fabrica> xml = new ImpExpXML<Fabrica>();
                return xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Fabrica.xml", f);
           
            
        }

        /// <summary>
        /// Leerá desde el archivo ubicado en el escritorio
        /// </summary>
        /// <returns></returns>
        public static Fabrica Leer()
        {
            
                ImpExpXML<Fabrica> xml = new ImpExpXML<Fabrica>();
                xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Fabrica.xml", out Fabrica f);
                return f;
           
            
            
        }
    }
}
