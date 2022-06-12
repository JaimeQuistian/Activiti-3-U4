using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A3_INT
{
    //Nombre de practica: VACUTEC_Actividad3
    //Tema de referencia: Herencia y Polimorfismo
    //Objetivo: DESARROLLAR UNA APLICACIÓN EN CONSOLE (.NET CORE), QUE IMPLEMENTE UNO DE LOS PILARES DEL PARADIGMA DE PROGRAMACIÓN ORIENTADA A OBJETOS, QUE ES
    //          HERENCIA Y POLIMORFISMO.
    //Materia: Programación Orientada a Objetos
    //Nombres alumnos: Daniela Ailyn Rodriguez Diaz | Ricardo Lenin Vazquez Arriaga | Jaime Emanuel Quistian Sanchez
    class Program
    {
        static void Main(string[] args)
        {
            //Se personaliza la consola en el cual se modifica las medidas de la ventana de esta, así también como el color, las letras y el fondo de la
            //consola.
            Console.WindowHeight = 20;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            //Se declaran miembros de tipo campo, que se utilizarán para darle funcionalidad al código.
            string nombrePersona, apellidoPaterno, apellidoMaterno, usuario = "", contrasena = "";
            DateTime fechaNacimiento;
            int dosis, tipoVacuna, opcionEntrada = 0, lugarVacuna;

            //Ciclo repetitivo while que evalua la opcion seleccionada por el usurario para saber si se desea ingresar a sistema o no.
            Console.WriteLine("Ingresando al sistema...\nSeleccione una opción\n\t1. Entrar\t2. Salir");
            opcionEntrada = Convert.ToInt32(Console.ReadLine());
            while (opcionEntrada == 1)
            {
                //Secuencia comparativa que se comparará la opcion del usuario hasta que sea correcto.
                Console.WriteLine("Ingrese su usuario: "); usuario = Console.ReadLine();
                if (usuario == "Jaime" || usuario == "Daniela" || usuario == "Lenin")
                {
                    Console.WriteLine("Ingresar la contraseña: "); contrasena = Console.ReadLine();
                    if (contrasena == "jaime1" || contrasena == "daniela1" || contrasena == "lenin1")
                    {
                        //Se mostrarán los siguientes mensajes para que el usuario ingrese y guarde los datos del paciente a registrar segun se le vayan
                        //solicitando.
                        Console.Clear();
                        Console.WriteLine("\t\t\tRegistro de vacunaciones\nIngresar los siguientes datos del paciente:");
                        Console.WriteLine("Nombre(s): "); nombrePersona = Console.ReadLine();
                        Console.WriteLine("Primer apellido: "); apellidoPaterno = Console.ReadLine();
                        Console.WriteLine("Segundo apellido: "); apellidoMaterno = Console.ReadLine();
                        Console.WriteLine("Fecha de Nacimiento: "); fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("\t\tLugar de vacunacion:\n\t1. Hospital general\t2. IMSS\n\t3. ISSSTE\t4. Unidad deportiva " +
                            "Los Sauces");
                        lugarVacuna = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t\tSeleccione la vacuna para el paciente\n\t 1. Pfizer\t 2. AstraZeneca\n\t " +
                            "3. Cansino\t 4. Sputink V");
                        tipoVacuna = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\t\tSeleccione la dosis a vacunar\n\t 1. Primera dosis\t 2. Segunda Dosis\n\t " +
                            "3. Tercera Dosis\t 4. Refuerzo");
                        dosis = Convert.ToInt32(Console.ReadLine());

                        //Secuencia comparativa if para que dependiendo del tipo de vacuno seleccionada instanciar el objeto necesario con sus datos
                        //correspondientes.
                        if (tipoVacuna==1)
                        {
                            //Instanciación de la clase "VacunaPfizer".
                            VacunaPfizer registroVacunacion = new VacunaPfizer(dosis, nombrePersona, apellidoPaterno, apellidoMaterno, fechaNacimiento, 
                                lugarVacuna);

                            //Mandar a llamarlos metodos "DatosPaciente, FechaDeVacunacion y EvaluacionDosis".
                            registroVacunacion.DatosPaciente();
                            registroVacunacion.FechaDeVacunacion();
                            Console.WriteLine("El paciente lleva mas de una dosis aplicada {0}",
                            registroVacunacion.EvaluacionDosis(dosis));
                        }else
                        if (tipoVacuna == 2)
                        {
                            //Instanciación de la clase "VacunaAstraZeneca".
                            VacunaAstraZeneca registroVacunacion = new VacunaAstraZeneca(dosis, nombrePersona, apellidoPaterno, apellidoMaterno, 
                                fechaNacimiento, lugarVacuna);

                            //Mandar a llamarlos metodos "DatosPaciente, FechaDeVacunacion y EvaluacionDosis".
                            registroVacunacion.DatosPaciente();
                            registroVacunacion.FechaDeVacunacion();
                            Console.WriteLine("El paciente lleva mas de una dosis aplicada {0}",
                            registroVacunacion.EvaluacionDosis(dosis));
                        }else
                        if (tipoVacuna == 3)
                        {
                            //Instanciación de la clase "VacunaCansino".
                            VacunaCansino registroVacunacion = new VacunaCansino(dosis, nombrePersona, apellidoPaterno, apellidoMaterno, fechaNacimiento, 
                                lugarVacuna);

                            //Mandar a llamarlos metodos "DatosPaciente, FechaDeVacunacion y EvaluacionDosis".
                            registroVacunacion.DatosPaciente();
                            registroVacunacion.FechaDeVacunacion();
                            Console.WriteLine("El paciente lleva mas de una dosis aplicada {0}",
                            registroVacunacion.EvaluacionDosis(dosis));
                        }else
                        if (tipoVacuna == 4)
                        {
                            //Instanciación de la clase "VacunaSputinkV".
                            VacunaSputinkV registroVacunacion = new VacunaSputinkV(dosis, nombrePersona, apellidoPaterno, apellidoMaterno, fechaNacimiento, 
                                lugarVacuna);

                            //Mandar a llamarlos metodos "DatosPaciente, FechaDeVacunacion y EvaluacionDosis".
                            registroVacunacion.DatosPaciente();
                            registroVacunacion.FechaDeVacunacion();
                            Console.WriteLine("El paciente lleva mas de una dosis aplicada {0}",
                            registroVacunacion.EvaluacionDosis(dosis));
                        }
                        else //Ultima comparativa que enviará el mensaje de que el tato ingresado no fue correcto.
                        {
                            Console.WriteLine("Dato ingresado incorrecto");
                        }

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta");
                        Console.WriteLine("Ingresar la contraseña: "); contrasena = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Usuario incorrecto");
                    Console.WriteLine("Ingrese su usuario: "); usuario = Console.ReadLine();
                }

                //Se pregunta al usuario si desea registrar un nuevo paciente, si la respuesta es si el ciclo se repite, sino se cierra el programa.
                Console.WriteLine("¿Desea registrar a un nuevo paciente?\n1. Si\n2. No");
                opcionEntrada = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            //Al finalizar los registros muetra un mensaje de despedida
            Console.WriteLine("Que tenga un buen día\n\n");

            Console.WriteLine("Nombres: Daniela Ailyn Rodriguez Diaz\n\tRicardo Lenin Vazquez Arriaga\n\tJaime Emanuel Quistian Sanchez");
            Console.ReadKey();
        }
    }
}
