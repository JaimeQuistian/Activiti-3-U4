using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A3_INT
{
    //Se le asigna el operador : para permitir el paso de datos heredados de la clase Persona a la clase VacunaPfizer.
    class VacunaPfizer : Vacuna
    {
        //Se declaran miembros de tipo campo, que se utilizarán para darle funcionalidad al código.
        int dosis;

        //Se crea un constructor con parametros propios y heredados (int dosis,string nombrePersona,string apellidoPrimero, string apellidoSegundo,
        //DateTime fechaNacimiento, int lugarAplicaion para inicializar los datos de la vacuna.
        public VacunaPfizer(int dosis,string nombrePersona,string apellidoPrimero, string apellidoSegundo, DateTime fechaNacimiento, 
            int lugarAplicaion)
            :base(nombrePersona, apellidoPrimero, apellidoSegundo, fechaNacimiento, lugarAplicaion)
        {
            this.dosis = dosis;
        }

        //Sobrecarga del contructor sin parametros de entrada.
        public VacunaPfizer() { }

        //Se manda a llamar el metodo "DatosPaciente" de la clase "Persona" para sobreescribir sobre ella y actualizar la información con nuevos datos
        //ingresados.
        public override void FechaDeVacunacion()
        {
            string informacionVacuna = "";

            //Mandar a llamar los datos del metodo "FechaDeVacunacion" de la clase "Vacuna".
            base.FechaDeVacunacion();

            //Secuencia evaluativa que dependiendo de la opcion dada por el usuario en dosis mostrará el uno de los siguientes mensajes con los datos de
            //Primera, Segunda, Tercera o Dosis de refuerzo.
            switch (dosis)
            {
                case 1:
                    informacionVacuna = string.Format(" Primera Dosis\n Nombre vacuna: Pfizer\n");
                    break;
                case 2:
                    informacionVacuna = string.Format(" Segunda Dosis\n Nombre vacuna: Pfizer\n");
                    break;
                case 3:
                    informacionVacuna = string.Format(" Tercera Dosis\n Nombre vacuna: Pfizer\n");
                    break;
                case 4:
                    informacionVacuna = string.Format(" Dosis de Referzo\n Nombre vacuna: Pfizer\n");
                    break;
                default:
                    informacionVacuna = String.Format(" Favor de ingresar un dato correcto");
                    break;
            }

            //Mostrar el mensaje de informacionVacuna con los datos que le fueron asignados anteriormente debido a su pocición
            //en el Switch y en el if anidado dentro del switch.
            Console.WriteLine(informacionVacuna);
 
        }
    }
}
