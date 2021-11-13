using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2
{
    class CAlumno: CPersona
    {
        private string titulo;
        public CAlumno(string doc, string nom, string ape, uint leg, string titu) : base(doc, nom, ape, leg)
        {
            this.titulo = titu;
        }

        public override string DarDatos()
        {
            return base.DarDatos() + " Titulo:" + this.titulo;
        }

    }
}

