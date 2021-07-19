using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {



        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Camioneta() : base()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        public Camioneta(string patente, EPrecios tipo, DateTime horaEntrada) : base(patente, tipo, horaEntrada)
        {


        }

        public Camioneta(string patente, EPrecios tipo, DateTime horaEntrada, DateTime horaSalida) : base(patente, tipo, horaEntrada, horaSalida)
        {


        }


    }
}
