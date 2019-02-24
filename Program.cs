using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            
            
            for (; ; )
            {
                Greeting();
                Age();
                Settings();

            }


        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("minLong = " + minLong);
            Console.WriteLine("maxLong = " + maxLong);
        }

        // <summary>
        // Wita użytkownika po wprowadzeniu imienia
        // </summary>
        private static void Greeting()
        {
            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }

        // <summary>
        // Wypisujemy dane wprowadzone przez użytkownika
        // </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int wiek;
            bool result = int.TryParse(Console.ReadLine(), out wiek);

            if(wiek >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś pełnoletni ! ");
            }
            else if (result == false)
            {
                System.Console.WriteLine("Wprowadziłeś znaki zamiast liczb");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nie jesteś pełnoletni !");
            }
        }

        // <summary>
        //  Ustawienia 
        // </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}
