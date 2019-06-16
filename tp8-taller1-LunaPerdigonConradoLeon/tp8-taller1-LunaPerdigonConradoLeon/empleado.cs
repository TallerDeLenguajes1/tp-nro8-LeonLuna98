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

    public struct fechas
    {
        public int dia;
        public int mes;
        public int anio;

    } 

    public class Empleado
    {
        string nombre;
        string apellido;
        elestadocivil estadocivil;
        elgenero genero;
        elcargo cargo;
        fechas fechanacimiento;
        fechas fechaingreso;
        double sueldo;      
       
        public Empleado(string _nombre, string _apellido, elestadocivil _estadocivil, double _sueldo, elgenero _genero, elcargo _cargo, fechas _fechanacimiento, fechas _fechaingreso)
        {
            nombre = _nombre;
            apellido = _apellido;
            estadocivil = _estadocivil;
            cargo = _cargo;
            genero = _genero;
            sueldo = _sueldo;
           fechanacimiento = _fechanacimiento;
            fechaingreso = _fechaingreso;

        }
  
        public void mostrarcontacto()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Estadocivil);
            Console.WriteLine(Genero);
            Console.WriteLine(Cargo);
            Console.WriteLine(Sueldo);
            Console.WriteLine(@"{0}  / {1} / {2}", Fechanacimiento.dia, Fechanacimiento.mes, Fechanacimiento.anio);
            Console.WriteLine(@"{0}  / {1}  / {2}", Fechaingreso.dia, Fechaingreso.mes, Fechaingreso.anio);
            Console.WriteLine("--------------");
        }

        public int elanio_actual =2019;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public elestadocivil Estadocivil
        {
            get
            {
                return estadocivil;
            }

            set
            {
                estadocivil = value;
            }
        }

        public elgenero Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public elcargo Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public fechas Fechanacimiento
        {
            get
            {
                return fechanacimiento;
            }

            set
            {
                fechanacimiento = value;
            }
        }

        public fechas Fechaingreso
        {
            get
            {
                return fechaingreso;
            }

            set
            {
                fechaingreso = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        public int AniosTrabajados(int anio_actual)
         {
             return anio_actual -  Fechaingreso.anio;
         }


         public int EdadEmpleado(int anio_actual)
         {
             return anio_actual - Fechanacimiento.anio;
         }

         public int Antiguedad(int anio_actual)
         {
             return anio_actual - Fechaingreso.anio;
         }

        public void AniosJubilacion(int anio_actual)
         {
             int aniosParajubilacion;

             if (Genero == elgenero.Masculino)
             { //si es masculino
                 aniosParajubilacion = 65 - EdadEmpleado(2019);
                 Console.WriteLine("El empleado se jubilara  {0} anios", aniosParajubilacion);
             }
             if (Genero == elgenero.Femenino)
             {//si es femenino
                 aniosParajubilacion = 60 - EdadEmpleado(2019);
                 Console.WriteLine("El empleado se jubilara  {0} anios", aniosParajubilacion);
             }
        }

    }

}

