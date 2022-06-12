using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A3_INT
{
    class Persona
    {
        //Se declaran miembros de tipo campo, que se utilizarán para darle funcionalidad al código.
        string nombrePersona, apellidoPrimero, apellidoSegundo, curp;
        DateTime fechaNacimiento;

        //Se crea un constructor con parametros (string nombrePersona, string apellidoPrimero, string apellidoSegundo, DateTime fechaNacimiento), para
        //inicializar los datos del paciente
        public Persona(string nombrePersona, string apellidoPrimero, string apellidoSegundo, DateTime fechaNacimiento)
        {
            this.nombrePersona = nombrePersona;
            this.apellidoPrimero = apellidoPrimero;
            this.apellidoSegundo = apellidoSegundo;
            this.fechaNacimiento = fechaNacimiento;
            curp = ((apellidoPrimero).Substring(0, 2)) + "" + ((apellidoSegundo).Substring(0, 1)) + "" +
                ((nombrePersona).Substring(0, 1)) + "" + ((fechaNacimiento.Year) + "" +
                (Convert.ToString(fechaNacimiento).Substring(3, 2)) + "" + (Convert.ToString(fechaNacimiento).Substring(0, 2)))
                .Substring(2, 6);
        }

        //Sobrecarga del contructor sin parametros de entrada
        public Persona() { }

        //Sobrecarga del contructor con los parametros (string nombrePersona, string apellidoPrimero,  DateTime fechaNacimiento)
        public Persona(string nombrePersona, string apellidoPrimero, DateTime fechaNacimiento)
        {
            this.nombrePersona = nombrePersona;
            this.apellidoPrimero = apellidoPrimero;
        }

        //Se declara el siguiente metodo "DatosPaciente" de tipo void para mostrar los datos del paciente, se le asigna el keyword vistual para permitr la
        //sobreescritura del mismo.
        public virtual void DatosPaciente()
        {
            string datosPersona;
            datosPersona = String.Format("\n\n\t\tDatos personales registrados\n Paciente: {0} {1} {2}\n CURP {3}\n Edad: {4}",
            nombrePersona, apellidoPrimero, apellidoSegundo, curp, Edad(fechaNacimiento));
            Console.WriteLine(datosPersona);
        }

        //Se declara el siguiente metodo "Edad" con el parametro (fechaNacimiento) de tipo int para calcular la edad del paciente.
        public int Edad(DateTime fechaNacimiento)
        {
            int edad = ((DateTime.Now - fechaNacimiento).Days) / 365;
            return edad;
        }
    }
}
