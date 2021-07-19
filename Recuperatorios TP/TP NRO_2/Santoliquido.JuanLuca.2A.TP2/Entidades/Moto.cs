using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Moto : Vehiculo
    {



        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Moto() : base()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        public Moto(string patente, EPrecios tipo, DateTime horaEntrada) : base(patente, tipo, horaEntrada)
        {


        }

        public Moto(string patente, EPrecios tipo, DateTime horaEntrada, DateTime horaSalida) : base(patente, tipo, horaEntrada, horaSalida)
        {


        }


    }
}
