using System;
using System.Collections.Generic;
using System.Linq;

namespace dziennik
{
    public class Diary
    {
        // Stan (zmienne - pola)
        List<float> ratings = new List<float>();

        // Zachowania

        public void addRating(float rating)
        {
            ratings.Add(rating);
        }

        public float calculateAvg()
        {
            float sum = 0, avg = 0;

            foreach( var rating in ratings)
            {
                sum += rating;
                
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float divMaxRating()
        {
            return ratings.Max();
        }

        public float divMinRating()
        {
            return ratings.Min();
        }
    }
}