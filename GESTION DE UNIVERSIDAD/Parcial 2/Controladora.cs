using System;
using System.Collections;
namespace Parcial_2
{
    public class Controladora
    {
        public static void Main()
        {
            char opcion;
            Universidad uni = new Universidad();
            do
            {
                char.TryParse(CInterfaz.DAR().ToUpper(), out opcion);
                string doc, nom, ape, titulo,datos,cod;
                uint leg;
                switch (opcion)
                {
                    case 'Q': // Docente
                        doc = CInterfaz.PEDIR_DATOS("DOCUMENTO");
                        ape = CInterfaz.PEDIR_DATOS("APELLIDO");
                        nom = CInterfaz.PEDIR_DATOS("NOMBRE");
                        leg = uint.Parse(CInterfaz.PEDIR_DATOS("LEGAJO"));
                        string POCI = CInterfaz.PEDIR_DATOS("\n [1]Profesor Titular \n [2] Profesor Adjunto \n [3]Jefe de Trabajos Prácticos \n [4]Ayudante de Trabajos Prácticos");
                        CCargo POCIN = CCargo.Profesor_Titular;
                        switch (POCI)
                        {
                            case "1":
                                POCIN = CCargo.Profesor_Titular;
                                break;
                            case "2":
                                POCIN = CCargo.Profesor_Adjunto;
                                break;
                            case "3":
                                POCIN = CCargo.Jefe_TP;
                                break;
                            case "4":
                                POCIN = CCargo.Ayudante_TP;
                                break;
                        }
                        if (uni.registrarDocente(doc, ape, nom, leg, POCIN) == true) CInterfaz.MostrarInfo("Proceso Exitoso");
                        else CInterfaz.MostrarInfo("Ocurrio un error");
                        break;
                    case 'E': 
                        doc = CInterfaz.PEDIR_DATOS("DOCUMENTO");
                        ape = CInterfaz.PEDIR_DATOS("APELLIDO");
                        nom = CInterfaz.PEDIR_DATOS("NOMBRE");
                        leg = uint.Parse(CInterfaz.PEDIR_DATOS("LEGAJO"));
                        titulo = CInterfaz.PEDIR_DATOS("TITULO");


                        if (uni.registrarAlumno(doc, ape, nom, leg, titulo) == true) CInterfaz.MostrarInfo("Proceso Exitoso");
                        else CInterfaz.MostrarInfo("Ocurrio un error");
                        break;
                    case 'K': 
                        datos = uni.MostrarAlumnos();
                        CInterfaz.MostrarInfo(datos);
                        if(datos == null) CInterfaz.MostrarInfo("No hay contenido para mostrar");
                        break;
                    case 'N':
                        datos = uni.MostrarDocentes();
                        CInterfaz.MostrarInfo(datos);
                        if (datos == null) CInterfaz.MostrarInfo("No hay contenido para mostrar");
                        break;

                    case 'Y':
                        datos = uni.ListarComisiones();
                        CInterfaz.MostrarInfo(datos);
                    break;

                    case 'R':
                        cod = CInterfaz.PEDIR_DATOS("CODIGO");
                        leg = uint.Parse(CInterfaz.PEDIR_DATOS("LEGAJO"));
                        if(uni.AsignarAlumno(leg,cod) == true) CInterfaz.MostrarInfo("Alumno Asignado.");
                        else CInterfaz.MostrarInfo("Error");
                        break;


                    case 'U':
                        cod = CInterfaz.PEDIR_DATOS("CODIGO");
                        datos = uni.ListarDocentesComision(cod);
                        CInterfaz.MostrarInfo(datos);
                        break;

                    case 'C':
                        cod = CInterfaz.PEDIR_DATOS("CODIGO");
                        datos = uni.ListarAlumnosComision(cod);
                        CInterfaz.MostrarInfo(datos);
                        break;

                    case 'V':
                        leg = uint.Parse(CInterfaz.PEDIR_DATOS("LEGAJO"));
                        if(uni.EliminarTotal(leg) == true) CInterfaz.MostrarInfo("Removido de la universidad");
                        else CInterfaz.MostrarInfo("Error");
                        break;

                    case 'P':
                        leg = uint.Parse(CInterfaz.PEDIR_DATOS("LEGAJO"));
                        cod = CInterfaz.PEDIR_DATOS("CODIGO");
                        if (uni.EliminarDeComision(cod, leg) == true) CInterfaz.MostrarInfo("Desvinculado");
                        else CInterfaz.MostrarInfo("Error");
                     break;


                    case 'L':
                        leg = uint.Parse(CInterfaz.PEDIR_DATOS("LEGAJO"));
                        CInterfaz.MostrarInfo(uni.DatosDeUnlegajo(leg));
                        break;

                    case 'W':
                        cod = CInterfaz.PEDIR_DATOS("CODIGO");
                        string T = CInterfaz.PEDIR_DATOS("\n [1]Noche \n [2] Maniana \n [3]Tarde");
                        CTurno TURNO = CTurno.Mañana;
                        switch (T)
                        {
                            case "1":
                                TURNO = CTurno.Noche;
                                break;
                            case "2":
                                TURNO = CTurno.Mañana;
                                break;
                            case "3":
                                TURNO = CTurno.Tarde;
                                break;
                        }
                        if(uni.RegistrarComision(cod,TURNO) == true) CInterfaz.MostrarInfo("Comision creada.");
                        else CInterfaz.MostrarInfo("Error en crear la comision.");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}


