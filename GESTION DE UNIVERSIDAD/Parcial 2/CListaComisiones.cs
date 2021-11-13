using System;
using System.Collections;
using System.Text;

namespace Parcial_2
{
    class CListaComisiones
    {
        private ArrayList Lista;


        public CListaComisiones()
        {
            this.Lista = new ArrayList();
        }

        public CComision buscar(string codigo)
        {
            foreach(CComision key in Lista)
            {
                if (key.getCodigo == codigo) return key;
            }
            return null;
        }

        public bool registrar(string cod, CTurno turno)
        {
            if (this.buscar(cod) == null)
            {
                this.Lista.Add(new CComision(cod, turno));
                return true;
            }
            return false;
        }

        public bool asignar(string cod, CPersona per)
        {
            CComision aux = this.buscar(cod);
            if (aux != null)
            {
                return aux.asignar(per);
            }
            return false;
        }

        public string ListarAlumnos(string cod)
        {
            CComision aux = this.buscar(cod);
            if (aux != null)
            {
                return aux.listarAlumnos();
            }
            return "No hay Alumnos";
        }

        public string ListarDocentes(string cod)
        {
            CComision aux = this.buscar(cod);
            if (aux != null)
            {
                return aux.listarDocentes();
            }
            return "No hay Docentes";
        }

        public string Listar()
        {
            this.Lista.Sort();
            if(this.Lista.Count != 0)
            {
                string datos = null;
                foreach (CComision key in Lista)
                {
                    datos += key.DarDatos();
                }
                return datos;
            }

            return "No se registraron Comisiones";
        }


        public bool removerTodos(uint leg)
        {
            bool band = false;
            foreach (CComision com in this.Lista)
            {
                if (com.Eliminar(leg) == true) band = true;
            }
            return band;
        }


        public bool remover(string cod, uint legajo)
        {
            CComision aux = this.buscar(cod);
            if(aux != null)
            {
                aux.Eliminar(legajo);
                return true;
            }
            return false;
        }

        public string Informe(uint legajo)
        {
            string datos = null;
            foreach (CComision com in this.Lista)
            {
                if (com.BuscarSiPetertenece(legajo) == true)
                {
                    return datos += com.DarDatos() + " \n";
                }
            }
            return "No esta en ninguna Comision.";
        }

    }

}
