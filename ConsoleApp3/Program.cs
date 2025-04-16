using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, promedio;

            Console.WriteLine("ingrese primera nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese tercera nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cuarta nota: ");
            nota4 = float.Parse(Console.ReadLine());

            promedio = (float)((nota1 * 0.10 + nota2 * 0.20 + nota3 * 0.30 + nota4 * 0.40));

            Console.WriteLine("promedio: " + promedio);

            if (promedio >= 11.5)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("el alumno aprobo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("el alumno reprobo");

            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
