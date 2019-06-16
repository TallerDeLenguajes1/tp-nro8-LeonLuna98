using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8_taller1_LunaPerdigonConradoLeon
{
    class Program
    {
        static void Main(string[] args)
        {//ESTE ES EL QUE SIRVE
            
            Empleado miempleado = cargardatos();
         
            //miempleado.cargardatos();
            miempleado.mostrarcontacto();
            /*
            Empleado miempleado = new Empleado("Juan","Lopez");
            miempleado.nombre=  "Jorge";*/


            Console.WriteLine(Directory.GetCurrentDirectory());
            string rutadelarchivo = @"..\..\ListaDeEmpleados.csv";
            string losempleados = File.ReadAllText(rutadelarchivo);

            Console.WriteLine("Lista de empleados {0}",losempleados);


            List<string> lalista = File.ReadAllLines(@"..\..\ListaDeEmpleados.csv").ToList();//Mejor un arreglo(?
            System.Console.WriteLine();

            //Que muestre los valores de la lista
            foreach (string linea in lalista)
            {
                var valores= linea.Split(';');
                Console.WriteLine("Nombre: " + valores[0] + " Apellido: " + valores[1] + " Estado Civil: " + valores[3] + " Sueldo: " + valores[4] + " Genero: " + valores[5] );

            }

            string[] discos = System.IO.Directory.GetLogicalDrives();
            foreach(string eldisco in discos)
            {

                Console.WriteLine("Disponible el disco:" + eldisco);


            }

            Console.WriteLine("En que disco desea guardar? ");
            string discoelegido = Console.ReadLine();
            //File.Exists("C:/BackUpAgenda.bk ");
            if (discoelegido.Equals(discos[0].ToLower()))
            {
                if (File.Exists(discos[0]))
                {
                    //File.Copy("archivoorigonal", "archivodestino.nuevaextension")
                    File.Copy(rutadelarchivo, @"C:\BackUpAgenda.csv");//Suponiendo que es el C

                    System.IO.File.Move(@"C:\BackUpAgenda.csv", @"C:\BackUpAgenda.bk");
                }
                else
                {
                    string elbackup = @"C:\ BackUpfile.csv";
                    FileStream backup = File.Create(elbackup);
                }
            }
        }

        public static Empleado cargardatos()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            string nombre = "jaimito";
            string apellido = "lopez";
            int opcion = rnd.Next(1, 3);
            elgenero generoX;
            switch (opcion)
            {
                case 1:
                    generoX = elgenero.Masculino;
                    break;
                case 2:
                    generoX = elgenero.Femenino;
                    break;
                default:
                    generoX = elgenero.Masculino;
                    break;
            }

            int opcion1 = rnd1.Next(1, 6);
            elcargo cargox;
            switch (opcion1)
            {
                case 1:
                    cargox = elcargo.Administrativo;
                    break;
                case 2:
                    cargox = elcargo.Auxiliar;
                    break;
                case 3:
                    cargox = elcargo.Especialista;
                    break;
                case 4:
                    cargox = elcargo.Ingeniero;
                    break;
                case 5:
                    cargox = elcargo.Investigador;
                    break;
                default:
                    cargox = elcargo.Auxiliar;
                    break;

            }
            double sueldo = rnd2.Next(5000, 10000);
            Random rnd3 = new Random();
            int opcion3 = rnd3.Next(1, 5);
            elestadocivil estadocivilx;
            switch (opcion3)
            {
                case 1:
                    estadocivilx = elestadocivil.Soltero;
                    break;
                case 2:
                    estadocivilx = elestadocivil.Casado;
                    break;
                case 3:
                    estadocivilx = elestadocivil.Viudo;
                    break;
                case 4:
                    estadocivilx = elestadocivil.Otro;
                    break;
                default:
                    estadocivilx = elestadocivil.Soltero;
                    break;
            }

            fechas fechanac;
            fechanac.dia = rnd1.Next(1, 31);
            fechanac.mes = rnd1.Next(1, 12);
            fechanac.anio = rnd1.Next(1965, 1985);
            fechas fechaing;

            fechaing.dia = rnd1.Next(1, 31);
            fechaing.mes = rnd1.Next(1, 12);
            fechaing.anio = rnd1.Next(1985, 2000);



            Empleado emp = new Empleado(nombre, apellido, estadocivilx, sueldo, generoX, cargox, fechanac, fechaing);
            return emp;
        }
    }
}
