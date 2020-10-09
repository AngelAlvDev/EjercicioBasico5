using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico5
{
    class EjercicioBasico5
    {
        static void Main(string[] args)
        {
            Int32 primer_numero = -1;
            Int32 segundo_numero = 0;
            Boolean acierto = false;
            while ((primer_numero < 0) || (primer_numero > 20))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Jugador 1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Introduzca un número a adivinar entre 0 y 20: ");
                primer_numero = Convert.ToInt32(Console.ReadLine());
                if(primer_numero < 0 || primer_numero > 20)
                {
                    Console.WriteLine("El número introducido no es válido. Intente de nuevo");
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Jugador 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Turno de adivinar: ");

            while ( !acierto)
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
