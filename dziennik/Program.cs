using System;
using System.Collections.Generic;
using System.Linq;

namespace dziennik
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            // diary.addRating(5);
            // diary.addRating(8.5f);
            // diary.addRating(10);
            // diary.addRating(3);
            // diary.addRating(5.5f);

            // float avg = diary.calculateAvg();
            // float min = diary.divMinRating();
            // float max = diary.divMaxRating();

            for (; ;)
            {
                Console.WriteLine("Podaj ocene z zakresu 1 do 10");

                float rating;

                bool result = float.TryParse(Console.ReadLine(), out rating);
                
                if( rating == 11 )
                {
                    break;
                }

                if (result)
                {
                    if( rating > 0 && rating <= 10)
                    {
                        diary.addRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Podaj liczbe z zakresu od 1 do 10");
                    }  
                }
            }

            Console.WriteLine("Srednia ocen to : " + diary.calculateAvg());
            Console.WriteLine("Najwyzsza ocena to : " + diary.divMaxRating());
            Console.WriteLine("Najnizsza ocena to : " + diary.divMinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
        }
    }
}
