using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2
{
    class CDocente : CPersona
    {
        private CCargo cargo;
        public CDocente(string doc, string nom, string ape, uint leg , CCargo car) : base(doc, nom, ape, leg)
        {
            this.cargo = car;
        }

        public override string DarDatos()
        {
            return base.DarDatos() + " Cargo: " + this.cargo;
        }

    }

}
