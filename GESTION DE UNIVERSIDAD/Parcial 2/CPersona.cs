using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2
{
    class CPersona 
    {
        
        private uint legajo;
        private string dni;
        private string nombre;
        private string apellido;

        public CPersona(string doc, string nom, string ape, uint leg)
        {
            this.dni = doc;
            this.nombre = nom;
            this.apellido = ape;
            this.legajo = leg;
        }

        public string getDni()
        {
            return this.dni;
        }

        public uint getLegajo()
        {
            return this.legajo;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public virtual string DarDatos()
        {
            return " Nombre: " + this.nombre + " Apellido: " + this.apellido + " Documento: " + this.dni + " Legajo: " + this.legajo; 
        }


    }
}