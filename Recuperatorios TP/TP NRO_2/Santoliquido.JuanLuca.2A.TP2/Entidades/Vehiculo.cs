using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades
{
    public abstract class Vehiculo
    {
        private string _patente;
        private EPrecios _tipo;
        private DateTime _horaEntrada;
        private DateTime _horaSalida;


        public string Patente
        {
            get
            {
                return this._patente;
            }

            set
            {
                this._patente = value;
            }
        }

        
        public EPrecios Tipo
        {

            get
            {
                return this._tipo;
            }

            set
            {
                this._tipo = value;
            }
        }
        
        

        public DateTime HoraEntrada
        {
            get
            {
                return this._horaEntrada;
            }

            set
            {
                this._horaEntrada = value;
            }
        }

        public DateTime HoraSalida
        {
            get
            {
                return this._horaSalida;
            }

            set
            {
                this._horaSalida = value;
            }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Vehiculo()
        {

            this._patente = "";
            this._tipo = EPrecios.Auto;
            this._horaEntrada = DateTime.Now;
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        public Vehiculo(string patente, EPrecios tipo, DateTime horaEntrada) : this()
        {

            this._patente = patente;
            this._tipo = tipo;
            this._horaEntrada = horaEntrada;

        }
        public Vehiculo(string patente, EPrecios tipo, DateTime horaEntrada, DateTime horaSalida) : this(patente,tipo,horaEntrada)
        {

            this._horaSalida = horaSalida;

        }



       

    }
}
