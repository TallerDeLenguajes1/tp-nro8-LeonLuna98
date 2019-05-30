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
        {

           
            /*
            Empleado miempleado = new Empleado("Juan","Lopez");
            miempleado.nombre=  "Jorge";*/

            string rutadelarchivo = @"./tp8-taller1-LunaPerdigonConradoLeon/ListaDeEmpleados.csv";
            string losempleados = File.ReadAllText(rutadelarchivo);

            Console.WriteLine("Lista de empleados {0}",losempleados);


            List<string> lalista = File.ReadAllLines(@".\tp8-taller1-LunaPerdigonConradoLeon\ListaDeEmpleados.csv").ToList();//Mejor un arreglo(?
            System.Console.WriteLine();

            //Que muestre los valores de la lista
            foreach (string linea in lalista)
            {
                var valores= linea.Split(';');
                Console.WriteLine("Nombre: " + valores[0] + "Apellido:" + valores[1] + "Estado Civil: " + valores[3] + "Sueldo: " + valores[4] + "Genero:" + valores[5] );

            }

            string[] discos = System.IO.Directory.GetLogicalDrives();
            foreach(string eldisco in discos)
            {

                Console.WriteLine("Disponible el disco:" + eldisco);


            }

            Console.WriteLine("En que disco desea guardar? ");
            string discoelegido = Console.ReadLine();
            //File.Exists("C:/BackUpAgenda.bk ");
            if (discoelegido.Equals(discos[0]))
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
    }
}
