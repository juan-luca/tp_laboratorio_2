﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {



        #region ATRIBUTOS
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;


        /// <summary>
        /// Enumerado de tamaño de vehiculos
        /// </summary>
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
        /// <summary>
        /// Enumerado de marcas de vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }
        #endregion






        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>

        #region PROPERTIES
        protected virtual ETamanio Tamanio 
        { 
            get => this.Tamanio; 
        }
        #endregion


        #region CONSTRUCTORES
        /// <summary>
        /// Asigna todos los valores correspondientes a la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {

            this.marca = marca;
            this.chasis = chasis;
            this.color = color;

        }
        #endregion

        #region METODOS
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region SOBRECARGAS

        
        public static explicit operator string(Vehiculo p)
        {
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CHASIS: " + p.chasis);
            sb.AppendLine("MARCA : " + p.marca.ToString());
            sb.AppendLine("COLOR : " + p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.chasis == v2.chasis;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Vehiculo)
            {
                rta = this == (Vehiculo)obj;
            }

            return rta;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
