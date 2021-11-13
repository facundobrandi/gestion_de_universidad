using System;
using System.Collections;
using System.Text;

namespace Parcial_2
{
    class CListadoPersonas
    {
        private ArrayList Listado;


        public CListadoPersonas()
        {
            this.Listado = new ArrayList();
        }

        public CPersona buscar(uint leg)
        {
            foreach (CPersona x in Listado)
            {
                if (x.getLegajo() == leg) return x;
            }

            return null;
        }

        public bool registrarDocente(string doc, string nom, string ape, uint legajo, CCargo cargo)
        {
            if (this.buscar(legajo) == null)
            {
                this.Listado.Add(new CDocente(doc, nom, ape, legajo, cargo));
                return true;
            }

            return false;
        }

        public bool registrarAlumno(string doc, string nom, string ape, uint legajo, string titulo)
        {
            if (this.buscar(legajo) == null)
            {
                this.Listado.Add(new CAlumno(doc, nom, ape, legajo, titulo));
                return true;
            }

            return false;
        }

        public bool registrarPersona(CPersona persona)
        {
            if(this.buscar(persona.getLegajo()) == null)
            {
                Listado.Add(persona);
                return true;
            }
            return false;
        }

  
        public string verDocentes()
        {
            string datos = null;
            foreach (CPersona item in Listado)
            {
                if(item is CDocente)
                {
                    datos += item.DarDatos() + "\n";
                }
            }

            return datos;
        }

        public string verAlumnos()
        {
            string datos = null;
            foreach (CPersona item in Listado)
            {
                if (item is CAlumno)
                {
                    datos += item.DarDatos() + "\n";
                }
            }
            return datos;
        }


        public bool remover(uint leg)
        {
            CPersona aux = this.buscar(leg);
            if (aux != null)
            {
                Listado.Remove(aux);
                return true;
            }
            return false;
        }

    }
}
