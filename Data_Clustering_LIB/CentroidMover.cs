using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Clustering_LIB
{
    public class CentroidMover
    {

        public static Centroid CountDistAndAssignCentroid(Iris iris, Centroid irisSetosa, Centroid irisVersicolor, Centroid irisVerginica)
        {
            bool status = true;
            double dist1 = 0, dist2 = 0, dist3 = 0;

            dist1 = CountDist(iris, irisSetosa);
            dist2 = CountDist(iris, irisVersicolor);
            dist3 = CountDist(iris, irisVerginica);

            if(dist1 < dist2 && dist1 < dist3) 
            {
                return irisSetosa;
            }
            else if (dist2 < dist1 && dist2 < dist3)
            {
                return irisVersicolor;
            }
            else
            {
                return irisVerginica;
            }
            
        }

        private static double CountDist(Iris iris, Centroid centroid)
        {
            double distance = Math.Sqrt(Math.Pow((iris.SepalL - centroid.F1), 2) + Math.Pow((iris.SepalW - centroid.F2), 2) + Math.Pow((iris.PetalL - centroid.F3), 2) + Math.Pow((iris.PetalW - centroid.F4), 2));
            return distance;
        }
    }
}
