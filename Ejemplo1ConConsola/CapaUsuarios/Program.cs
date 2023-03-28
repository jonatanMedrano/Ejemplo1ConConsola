using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaNegocios;

namespace CapaUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Persona pers, persOtra;
            int d;
            string n;
            DateTime f;
            //Esto es para ingresar un dni.
            Console.Write("Dni: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            n = Console.ReadLine();
            Console.Write("Fecha nacimiento: ");
            f = DateTime.Parse(Console.ReadLine());
            pers = new Persona(d, n, f);
            Console.WriteLine("La edad de " + pers.Nombre + " es " + pers.edad());
            persOtra = new Persona();
            Console.Write("Dni: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            n = Console.ReadLine();
            Console.Write("Fecha nacimiento: ");
            f = DateTime.Parse(Console.ReadLine());
            persOtra.Dni = d;
            persOtra.Nombre = n;
            persOtra.FechaNac = f;
            Console.WriteLine("La edad de " + persOtra.Nombre + " es " + persOtra.edad());
        }
    }
}
