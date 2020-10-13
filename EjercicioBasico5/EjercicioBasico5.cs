using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico5
{
    class EjercicioBasico5
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Int32 primer_numero = rnd.Next(21);
            Int32 segundo_numero = 0;
            Boolean acierto = false;
            Int16 intentos = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Jugador");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Turno de adivinar: ");

            while (!acierto && intentos < 5)
            {
                Console.Write("Introduzca un número: ");
                segundo_numero = Convert.ToInt32(Console.ReadLine());
                if (primer_numero != segundo_numero)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (primer_numero > segundo_numero)
                    {
                        Console.WriteLine("El número buscado es mayor que " + segundo_numero);
                    }
                    else
                    {
                        Console.WriteLine("El número buscado es menor que " + segundo_numero);
                    }
                    intentos++;
                    if(intentos == 5)
                    {
                        Console.WriteLine("Has perdido. El número buscado es: " + primer_numero);
                    }
                }
                else
                {
                    acierto = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Has acertado. El número buscado era " + primer_numero);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
