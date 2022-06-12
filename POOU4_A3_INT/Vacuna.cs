using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A3_INT
{
    //Se le asigna el operador : para permitir el paso de datos heredados de la clase Persona a la clase vacuna.
    class Vacuna : Persona 
    {
        //Se declaran miembros de tipo campo, que se utilizarán para darle funcionalidad al código.
        int lugarAplicaion;
        DateTime fechaVacunacion;

        //Se crea un constructor con parametros propios y heredados (string nombrePersona, string apellidoPrimero, string apellidoSegundo, DateTime
        //fechaNacimiento, int lugarAplicaion) para inicializar los datos de la vacuna.
        public Vacuna(string nombrePersona, string apellidoPrimero, string apellidoSegundo, DateTime fechaNacimiento, int lugarAplicaion)
            : base(nombrePersona, apellidoPrimero, apellidoSegundo, fechaNacimiento)
        {
            this.lugarAplicaion = lugarAplicaion;
        }

        //Sobrecarga del contructor sin parametros de entrada.
        public Vacuna() { }

        //Se crea la propiedad "FechaVacunacion" para darle permisos de escitura a la variable "fechaVacunacion".
        public DateTime FechaVacunacion
        {
            set { fechaVacunacion = value; }
        }

        //Se declara el siguiente metodo "EvaluacionDosis" con el parametro (dosis) de tipo bool para evaliar si el paciente
        //lleva mas de una dosis aplicada.
        public bool EvaluacionDosis(int dosis)
        {
            bool evaluacionDosis;
            evaluacionDosis = Convert.ToBoolean(dosis);
            if (dosis >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Se manda a llamar el metodo "DatosPaciente" de la clase "Persona" para sobreescribir sobre ella y actualizar la información con nuevos datos
        //ingresados.
        public override void DatosPaciente()
        {

            //Mandar a llamar los datos del metodo "DatosPaciente" de la clase "Persona".
            base.DatosPaciente();

            //Secuencia evaluativa que dependiendo de la opcion dada por el usuario en lugarAplicaion mostrará el uno de los siguientes mensajes.
            if (lugarAplicaion == 1)
            {
                Console.WriteLine(" Lugar de vacunacion: Hospital general");
            }
            if (lugarAplicaion == 2)
            {
                Console.WriteLine(" Lugar de vacunacion: IMSS");
            }
            if (lugarAplicaion == 3)
            {
                Console.WriteLine(" Lugar de vacunacion: ISSSTE");
            }
            if (lugarAplicaion == 4)
            {
                Console.WriteLine(" Lugar de vacunacion: Unidad depostiva Los Sauces");
            }
        }

        public virtual void FechaDeVacunacion()
        {
            string informacionFechaVacunacion;

            //Mostrar el siguiente mensaje en pantalla para pedirle al usuario que ingrese la fecha y hora de vacunación del paciente.
            Console.WriteLine(" Ingrese la fecha y hora de vacunación");

            //Guardar en una variable la respuesta del usuario
            fechaVacunacion = Convert.ToDateTime(Console.ReadLine());

            //Mandar a pantalla la fecha ingresada por el usuario
            informacionFechaVacunacion = string.Format(" Fecha vacunación: {0}", fechaVacunacion);
        }

    }
}
