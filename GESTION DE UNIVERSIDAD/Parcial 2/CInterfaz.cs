using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string DAR()
        {
            Console.Clear();
            Console.WriteLine("     ################################");
            Console.Write("     #SISTEMA DE GESTION UNIVERSIDAD  #");
            Console.WriteLine("\n    ################################\n\n\n ");
            Console.WriteLine(" [Q] INGRESAR UN DOCENTE \n");
            Console.WriteLine(" [W] INGRESAR UN COMISIONES \n");
            Console.WriteLine(" [E] INGRESAR UN ALUMNO \n");
            Console.WriteLine(" [R] VINCULAR PERSONA A UNA COMISION \n");
            Console.WriteLine(" [Y] MOSTRAR COMISIONES \n");
            Console.WriteLine(" [N] MOSTRAR DOCENTES \n");
            Console.WriteLine(" [K] MOSTRAR ALUMNOS \n");
            Console.WriteLine(" [U] MOSTRAR DOCENTES DE UNA COMISION \n");
            Console.WriteLine(" [P] DESVINCULAR UNA PERSONA DE UNA COMISION \n");
            Console.WriteLine(" [V] BORRAR DATOS DE UNA PERSONA DE LA UNIVERSIDAD\n");
            Console.WriteLine(" [Z] MOSTRAR DOCENTES DE UNA COMISION \n");
            Console.WriteLine(" [C] MOSTRAR ALUMNOS DE UNA COMISION \n");
            Console.WriteLine(" [U] BUSCAR DOCENTE O ALUMNO \n");
            Console.WriteLine(" [S] SALIR DE LA APLICACION \n\n");
            return CInterfaz.PEDIR_DATOS("SU OPCION");
        }

        public static string PEDIR_DATOS(string DATO)
        {
            Console.Write(" INGRESE " + DATO + ":");
            string INGRESO = Console.ReadLine();
            while( INGRESO == "")
            {
                Console.WriteLine("ES NECESARIO INGRESAR UN DATO");
                INGRESO = Console.ReadLine();
            }
            Console.Clear();
            return INGRESO.Trim();
        }

        public static void MostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("[PULSE ENTER]");
            Console.ReadLine();
            Console.Clear();
        }


    }
}
