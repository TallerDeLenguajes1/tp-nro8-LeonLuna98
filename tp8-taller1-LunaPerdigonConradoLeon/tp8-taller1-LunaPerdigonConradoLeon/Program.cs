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
            
            //Empleado miempleado = cargardatos();

            //miempleado.mostrarcontacto();
          
            Console.WriteLine(Directory.GetCurrentDirectory());
            string rutadelarchivo = @"..\..\ListaDeEmpleados.csv";
            try{
                string losempleados = File.ReadAllText(rutadelarchivo);
                Console.WriteLine("Lista de empleados {0}",losempleados);
            }
            catch (Exception ex){
                Console.WriteLine("CERRA EL EXEL!!!");
            }
                  

            List<string> lalista = File.ReadAllLines(@"..\..\ListaDeEmpleados.csv", Encoding.ASCII).ToList();//Mejor un arreglo(?
            System.Console.WriteLine();

            //lalista.RemoveAt(0); //REMUEVE LA PRIMERA LINEA

            Empleado nuevoemp = cargardatos();
            string aux = "";
            aux = aux + nuevoemp.Nombre.ToString() + ";";
            aux = aux + nuevoemp.Apellido.ToString() + ";";
            aux = aux + nuevoemp.Estadocivil.ToString() + ";";
            aux = aux + nuevoemp.Sueldo.ToString() + ";";
            aux = aux + nuevoemp.Genero.ToString() + ";";
            aux = aux + nuevoemp.Cargo.ToString();

            // aux = nuevoemp.Nombre.ToString() + ";" + nuevoemp.Apellido.ToString() + ";"+ 
            lalista.Add(aux);

            //Que muestre los valores de la lista
            foreach (string linea in lalista)
            {
                var valores= linea.Split(';');
                Console.WriteLine("Nombre: " + valores[0] + " Apellido: " + valores[1] + " Estado Civil: " + valores[2] + " Sueldo: " + valores[3] + " Genero: " + valores[4] +"Cargo: " + valores[5] );

            }

            File.WriteAllLines(rutadelarchivo, lalista.ToArray());

            //Que muestre los discos disponibles
            string[] discos = System.IO.Directory.GetLogicalDrives();
            foreach(string eldisco in discos)
            {

                Console.WriteLine("Disponible el disco:" + eldisco);
            }

            Console.WriteLine(@"En que disco desea guardar? (COPIE TEXTUALMENTE EL DISCO EJ: E:\)");//YA ANDA
            string discoelegido = Console.ReadLine();
            foreach (string eldiscoelegido in discos)
            {

                try{
               
                    if (Equals(eldiscoelegido.ToLower(),discoelegido.ToLower()))
                    {
                        if (Directory.Exists(eldiscoelegido)){
                                string elbackup = eldiscoelegido + @"\ BackUp";
                                Directory.CreateDirectory(elbackup);
                                //File.Copy("archivoorigonal", "archivodestino.nuevaextension")
                                string fecha = DateTime.Now.ToString(@"hh\mm\Ss");
                               
                                fecha= fecha.Replace(':', '-');
                                fecha = fecha.Replace( '\\', '_');
                                string nombreArchivo = @"\BackUpAgenda" + fecha + ".bk";
                                File.Copy(rutadelarchivo, elbackup + nombreArchivo);

                              //File.Move(rutadelarchivo, elbackup + ".bk");
                                Console.WriteLine("Se guardo exitosamente!");               

                        }
                        else{
                        string elbackup = eldiscoelegido + @"\ BackUp";
                        Directory.CreateDirectory(elbackup);
                            Console.WriteLine("La carpeta no existe, creando una...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: PROBLEMAS AL BUSCAR LA CARPETA ");
                }            
            }
            Console.ReadKey();
        }

        public static Empleado cargardatos()
        {
            string[] losnombresm = { "Matias", "Luciano", "Facundo", "Angel", "Ismael", "Santiago" };
            string[] losnombresf = { "Luciana", "Miriam", "Jazmin", "Leona", "Luz", "Abril" };
            string[] losapellidos = { "Lopez", "Martinez", "Avellaneda", "Tula", "Castania","Luna" };
            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
           
            string nombre;
          
            string apellido;
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

            if (generoX == elgenero.Masculino){
                nombre = losnombresm[rnd1.Next(0,6)];
            }
            else {
                nombre = losnombresf[rnd1.Next(0, 6)];
            }

            apellido = losapellidos[rnd1.Next(0, 6)];
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
