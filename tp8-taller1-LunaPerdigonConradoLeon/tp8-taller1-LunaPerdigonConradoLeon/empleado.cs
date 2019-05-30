using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8_taller1_LunaPerdigonConradoLeon
{

    public enum elcargo
    {
        Auxiliar, Administrativo, Ingeniero, Especialista, Investigador
    }
    public enum elgenero
    {
        Masculino, Femenino
    }
    public enum elestadocivil
    {
        Soltero, Casado, Viudo, Otro
    }

    /*public struct fechas
    {
        int dia;
        int mes;
        int anio;

    }
    */


    public struct Empleado
    {

        private string nombre;
        string apellido;
        elestadocivil estadocivil;
        elgenero genero;
        elcargo cargo;
       /* fechas fechanacimiento;
        fechas fechaingreso;*/
        double sueldo;


       
        public Empleado(string _nombre, string _apellido, elestadocivil _estadocivil, double _sueldo, elgenero _genero, elcargo _cargo/*, fechas _fechanacimiento, fechas _fechaingreso*/)
        {
            nombre = _nombre;
            apellido = _apellido;
            estadocivil = _estadocivil;
            cargo = _cargo;
            genero = _genero;
            sueldo = _sueldo;
           /* fechanacimiento = _fechanacimiento;
            fechaingreso = _fechaingreso;*/

        }

     
        public void mostrarcontacto()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(estadocivil);
            Console.WriteLine(genero);
            Console.WriteLine(cargo);
            Console.WriteLine(sueldo);
            /*Console.WriteLine(@"{0}  / {1} / {2}", fechanacimiento.dia, fechanacimiento.mes, fechanacimiento.anio);
            Console.WriteLine(@"{0}  / {1}  / {2}", fechaingreso.dia, fechaingreso.mes, fechaingreso.anio);*/
            Console.WriteLine("--------------");
        }


        //el fin de la estructura
        //public int elanio_actual =2019;

       /* public int AniosTrabajados(int anio_actual)
        {
            return anio_actual -  fechaingreso.anio;

        }


        public int EdadEmpleado(int anio_actual)
        {
            return anio_actual - fechanacimiento.anio;
        }

        public int Antiguedad(int anio_actual)
        {
            return anio_actual - fechaingreso.anio;
        }*/

       /* public void AniosJubilacion(int anio_actual)
        {
            int aniosParajubilacion;

            if (genero == elgenero.Masculino)
            { //si es masculino
                aniosParajubilacion = 65 - EdadEmpleado(2019);
                Console.WriteLine("El empleado se jubilara  {0} anios", aniosParajubilacion);
            }

            if (genero == elgenero.Femenino)
            {//si es femenino
                aniosParajubilacion = 60 - EdadEmpleado(2019);
                Console.WriteLine("El empleado se jubilara  {0} anios", aniosParajubilacion);
            }
        }*/



    }

}

