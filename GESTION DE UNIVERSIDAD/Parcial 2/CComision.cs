using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2
{
    class CComision : IComparable
    {
        private string codigo;
        private CTurno turno;
        private CListadoPersonas Lista;

        public CComision(string cod, CTurno tur)
        {
            this.codigo = cod;
            this.turno = tur;
            this.Lista = new CListadoPersonas();
        }

        public string getCodigo
        {
            get { return this.codigo; }
        }

        public bool asignar(CPersona per)
        {
            if (this.Lista.registrarPersona(per) == true) return true;
            return false;
        }

        public virtual string DarDatos()
        {
            return " Codigo: " + this.codigo + " Turno: " + this.turno + "\n ";
        }

        public string listarAlumnos()
        {
            string datos = null;
            return datos = Lista.verAlumnos();
        }

        public string listarDocentes()
        {
            string datos = null;
            return datos = Lista.verDocentes();
        }

        public bool Eliminar(uint leg)
        {
            CPersona aux = this.Lista.buscar(leg);
            if (aux != null)
            {
                this.Lista.remover(leg);
                return true;
            }
            return false;
        }

        public bool BuscarSiPetertenece(uint leg)
        {
          if(Lista.buscar(leg) != null)
            {
                return true;
            }
            return false;
        }

        public int CompareTo(object com)
        {
            return this.codigo.CompareTo(((CComision)com).getCodigo);
        }

    }
}

