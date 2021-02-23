using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Parcial1PROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Estado del alumno según sus notas.";

            Double nota1, nota2, prom, nota3, totalmult;

            Console.Write("Ingrese su primera nota: ");
            nota1 = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese su segunda nota: ");
            nota2 = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese su tercera nota: ");
            nota3 = Double.Parse(Console.ReadLine());


            prom = ((nota1 + nota2 + nota3) / 3);

            if (prom >= 7) 
            {
                Console.WriteLine("Alumno promocionado");
            }
            else if (prom >= 4)
            {
                Console.WriteLine("Alumno regular.");
            }
            else
            {
                Console.WriteLine("Alumno reprobado.");
            }

            Console.ReadKey();

        }
    }
}
