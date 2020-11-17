using System;
using System.Collections.Generic;
using System.Text;

namespace Domaća_Zadaća_br._2
{
    class Episode
    {
        private Description description;
        private int views = 0;
        private double maxrat = 0;
        private double sumscore = 0;


        public Episode() { }
        public Episode(int views, double sumscore, double maxrat, Description description)
        {
            this.views = views;
            this.maxrat = maxrat;
            this.sumscore = sumscore;
            this.description = description;
        }


        public void AddView(double a)
        {
            if (a > maxrat)
            {
                maxrat = a;
                views++;
            }
        }

        public double GetAverageScore()
        {
            return sumscore;
        }
        public double GetMaxScore()
        {
            return maxrat;
        }
        public double GetViewerCount()
        {
            return views;
        }
        public override string ToString()
        {
            return $"{views},{sumscore},{maxrat},{description.Number},{description.Length},{description.naziv}";
        }
    }
}
