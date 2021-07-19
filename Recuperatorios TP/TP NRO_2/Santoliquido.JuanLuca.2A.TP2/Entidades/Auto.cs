using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        
        

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Auto():base()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
       public Auto(string patente, EPrecios tipo, DateTime horaEntrada) : base(patente, tipo, horaEntrada)
        {


        }

    public Auto(string patente, EPrecios tipo, DateTime horaEntrada, DateTime horaSalida) : base(patente, tipo, horaEntrada, horaSalida)
        {


        }

      
    }
}
