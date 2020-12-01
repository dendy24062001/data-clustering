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

        public double F1 { get => f1; set => f1 = value; }
        public double F2 { get => f2; set => f2 = value; }
        public double F3 { get => f3; set => f3 = value; }
        public double F4 { get => f4; set => f4 = value; }

        public Centroid()
        {
            F1 = Math.Round(new Random().NextDouble(), 2);
            F2 = Math.Round(new Random().NextDouble(), 2);
            F3 = Math.Round(new Random().NextDouble(), 2);
            F4 = Math.Round(new Random().NextDouble(), 2);
        }

        public static void HitungPosisiCentroid(Centroid centroid)
        {

        }

        
    }
}
