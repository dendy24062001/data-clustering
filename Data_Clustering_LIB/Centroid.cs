using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Clustering_LIB
{
    public class Centroid
    {
        private double f1;
        private double f2;
        private double f3;
        private double f4;
        Random random1;
        Random random2;
        Random random3;
        Random random4;

        public Centroid(double f1, double f2, double f3, double f4)
        {
            F1 = f1;
            F2 = f2;
            F3 = f3;
            F4 = f4;
        }
        public Centroid(Iris i)
        {
            F1 = i.SepalL;
            F2 = i.SepalW;
            F3 = i.PetalL;
            F4 = i.PetalW;
        }

        public double F1 { get => f1; set => f1 = value; }
        public double F2 { get => f2; set => f2 = value; }
        public double F3 { get => f3; set => f3 = value; }
        public double F4 { get => f4; set => f4 = value; }

        //public Centroid()
        //{
        //    random1 = new Random();
        //    random2 = new Random();
        //    random3 = new Random();
        //    random4 = new Random();

        //    //Random rnd = new Random();
        //    //decimal val;
        //    //int decimal_places = 2;
        //    //val = Math.Round(new decimal(rnd.NextDouble()), decimal_places);

        //    F1 = Math.Round(random1.NextDouble(), 2);
        //    F2 = Math.Round(random2.NextDouble(), 2);
        //    F3 = Math.Round(random3.NextDouble(), 2);
        //    F4 = Math.Round(random4.NextDouble(), 2);
        //}
        public void  HitungPosisiCentroid(Iris iris)
        {
            double result = (iris.PetalL + iris.PetalW + iris.SepalL + iris.SepalW) / 4;
           
        }
        public static double CalculateDistance (Iris f, Iris s)
        {
            //ini sama kek count distance di centroid mover
            double result = Math.Pow(f.PetalL - s.PetalL, 2) +
                Math.Pow(f.PetalW - s.PetalW, 2) + Math.Pow(f.SepalL - s.SepalL, 2) + Math.Pow(f.SepalW - s.SepalW, 2);
            return result;
        }

        
    }
}
