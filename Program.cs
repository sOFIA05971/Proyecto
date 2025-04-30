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
            Consultar = 1, Agregar, Actualizar, Eliminar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (switch_on)
                {
                    default:
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
            Menu=(Menu)Convert.ToInt32(Console.ReadLine());

        }
    }
}
