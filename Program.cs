using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {

        public enum Menu
        {
            Consultar = 1, Agregar, Actualizar, Eliminar, Salir
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (men())
                {
                    case Menu.Consultar:
                        var lista = acciones.Consultar();
                        foreach (var y in lista)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine($"Nombre: {y.Nombre}");
                            Console.WriteLine($"Edad: {y.Edad}");
                            Console.WriteLine($"Matricula: {y.Matricula}");
                            Console.WriteLine("------------");
                        }
                        break;
                    case Menu.Agregar:
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula: ");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        acciones.Agregar(matricula,nombre,edad);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame matricula para actualizar: ");
                        int matri = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame nuevo nombre: ");
                        string Nombr = Console.ReadLine();
                        Console.WriteLine("Dame nueva edad: ");
                        int ed = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame nueva matricula: ");
                        int numMat = Convert.ToInt32(Console.ReadLine());

                        acciones.Actualizar(matri, Nombr, ed, numMat);
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Ingresa matricula a elmimnar: ");
                        int matr = Convert.ToInt32(Console.ReadLine());
                        acciones.Eliminar(matr);
                        break;
                    case Menu.Salir:
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }

            }


        }

        static Menu men()
        {
            Console.WriteLine("Escoge...");
            Console.WriteLine("1)Consultar");
            Console.WriteLine("2)Agregar");
            Console.WriteLine("3)Actualizar");
            Console.WriteLine("4)Eliminar");
            Console.WriteLine("5)Salir...");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;

        }
    }
}
