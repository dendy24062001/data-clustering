using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Clustering_LIB
{
    public class Centroid
    {
        private string name;
        private double f1;
        private double f2;
        private double f3;
        private double f4;

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

        public Centroid()
        {
            Random random = new Random();

            F1 = random.NextDouble();
            F2 = random.NextDouble();
            F3 = random.NextDouble();
            F4 = random.NextDouble();
        }

        public Centroid(string name)
        {
            Random random = new Random(456);

            Name = name;

            F1 = random.NextDouble();
            F2 = random.NextDouble();
            F3 = random.NextDouble();
            F4 = random.NextDouble();
        }

        public Centroid(string name, Random random)
        {
            Name = name;
            double f1 = random.NextDouble();
            double f2 = random.NextDouble();
            double f3 = random.NextDouble();
            double f4 = random.NextDouble();

            F1 = Math.Round(f1, 2);
            F2 = Math.Round(f2, 2);
            F3 = Math.Round(f3, 2);
            F4 = Math.Round(f4, 2);
        }

        public string Name { get => name; set => name = value; }
        public double F1 { get => f1; set => f1 = value; }
        public double F2 { get => f2; set => f2 = value; }
        public double F3 { get => f3; set => f3 = value; }
        public double F4 { get => f4; set => f4 = value; }
        

        public void CentroidPosition(List<Iris> irises)
        {
            int divider = irises.Count;

            double f1 = 0, f2 = 0, f3 = 0, f4 = 0;

            foreach(Iris iris in irises)
            {
                f1 += iris.SepalL;
                f2 += iris.SepalW;
                f3 += iris.PetalL;
                f4 += iris.PetalW;
            }

            F1 = f1 / divider;
            F2 = f2 / divider;
            F3 = f3 / divider;
            F4 = f4 / divider;
        }

        public void  HitungPosisiCentroid(Iris iris)
        {
            double result = (iris.PetalL + iris.PetalW + iris.SepalL + iris.SepalW) / 4;
           
        }
        public static double CalculateDistanceIris (Iris f, Iris s)
        {
            //ini sama kek count distance di centroid mover
            double result = Math.Pow(f.PetalL - s.PetalL, 2) +
                Math.Pow(f.PetalW - s.PetalW, 2) + Math.Pow(f.SepalL - s.SepalL, 2) + Math.Pow(f.SepalW - s.SepalW, 2);
            return result;
        }
        public static double CalculateDistanceCentroid(Centroid c1, Centroid c2)
        {
            //ini sama kek count distance di centroid mover
            double result = Math.Pow(c1.F1 - c2.F1, 2) +
                Math.Pow(c1.F2 - c2.F2, 2) + Math.Pow(c1.F3 - c2.F3, 2) + Math.Pow(c1.F4 - c2.F4, 2);
            return result;
        }

    }
}
