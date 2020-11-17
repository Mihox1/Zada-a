using System;
using System.Collections.Generic;
using System.Text;

namespace Domaća_Zadaća_br._2
{
    class TvUtilities
    {
        public static Episode Parse(string episode)
        {

            string[] Prase = episode.Split(',');
            int viewers = int.Parse(Prase[0]);
            double sumscore = double.Parse(Prase[1]);
            double maxrating = double.Parse(Prase[2]);
            int numbr = int.Parse(Prase[3]);
            TimeSpan duration = TimeSpan.Parse(Prase[4]);
            string movieName = Prase[5];
            Description tempdesc = new Description(numbr, duration, movieName);
            return new Episode(viewers, sumscore, maxrating, tempdesc);
        }
        public static void Sort(Episode[] episodes)
        {
            for (int i = 0; i < episodes.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (episodes[j - 1].GetAverageScore() < episodes[j].GetAverageScore())
                    {
                        Episode temp = new Episode();
                        temp = episodes[j - 1];
                        episodes[j - 1] = episodes[j];
                        episodes[j] = temp;
                    }
                }
            }

        }
        public static double GenerateRandomScore(int minimum, int maximum)
        {
            Random random = new Random();
            double randscore = (random.NextDouble() * (maximum - minimum)) + minimum;
            return randscore;
        }
    }
}
