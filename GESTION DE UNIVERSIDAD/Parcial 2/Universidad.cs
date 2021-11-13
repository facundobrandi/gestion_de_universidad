using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_2
{
    class Universidad
    {
        private CListadoPersonas ListadoDePersonas = new CListadoPersonas();
        private CListaComisiones ListadoComisiones = new CListaComisiones();

        public bool registrarAlumno(string doc, string ape, string nom, uint legajo, string titulo)
        {
            return this.ListadoDePersonas.registrarAlumno(doc, nom, ape, legajo, titulo);
        }

        public bool registrarDocente(string doc, string ape, string nom, uint legajo, CCargo cargo)
        {
            return this.ListadoDePersonas.registrarDocente(doc, nom, ape, legajo, cargo);
        }

        public string MostrarAlumnos()
        {
            return this.ListadoDePersonas.verAlumnos();

        }
        public string MostrarDocentes()
        {
            return this.ListadoDePersonas.verDocentes();
        }

        public bool RegistrarComision(string cod, CTurno tur)
        {
            return this.ListadoComisiones.registrar(cod,tur);
        }

        public string ListarComisiones()
        {
            return this.ListadoComisiones.Listar();
        }

        public bool AsignarAlumno(uint legajo, string cod)
        {
            CPersona aux = this.ListadoDePersonas.buscar(legajo);
            if(aux != null)
            {
                return this.ListadoComisiones.asignar(cod, aux);
            }
            return false;
        }

        public bool AsignarDocente(uint legajo, string cod)
        {
            CPersona aux = this.ListadoDePersonas.buscar(legajo);
            if (aux != null)
            {
                return this.ListadoComisiones.asignar(cod, aux);
            }
            return false;
        }

        public string ListarDocentesComision(string cod)
        {
            return this.ListadoComisiones.ListarDocentes(cod);
        }

        public string ListarAlumnosComision(string cod)
        {
            return this.ListadoComisiones.ListarAlumnos(cod);
        }

        public bool EliminarTotal(uint leg)
        {
            this.ListadoDePersonas.remover(leg);
            return this.ListadoComisiones.removerTodos(leg);
        }

        public bool EliminarDeComision(string cod,uint leg)
        {
           return this.ListadoComisiones.remover(cod, leg);
        }

        public string DatosDeUnlegajo(uint leg)
        {
   
            CPersona AUX = this.ListadoDePersonas.buscar(leg);

            if(AUX != null)
            {
                string datosComisiones = this.ListadoComisiones.Informe(leg);
                string datosPersonales = AUX.DarDatos();
                if (AUX is CDocente)
                {
                    return "Datos Personales: \n\n\n" + datosPersonales + "\n\n\n Comisiones a la cuales pertenece: \n" + datosComisiones + " Es un docente";
                }
                return "Datos Personales: \n\n\n" + datosPersonales + "\n\n\n Comisiones a la cuales pertenece: \n" + datosComisiones + "Es un Alumno";
            }
            else return "No existe legajo ingresado."; 
   
        }



    }
}

