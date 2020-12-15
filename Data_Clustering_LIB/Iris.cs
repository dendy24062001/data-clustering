using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Clustering_LIB
{
    public class Iris
    {
        private int id;
        private double sepalL;
        private double sepalW;
        private double petalL;
        private double petalW;
        private Centroid centroid;
        private double distanceSquare;

        private string f1;
        private string f2;
        private string f3;
        private string f4;

        #region Constructor
        public Iris()
        {

            SepalL = 0.0;
            SepalW = 0.0;
            PetalL = 0.0;
            PetalW = 0.0;
        }
        public Iris(double sepalLInput, double sepalWInput, double petalLInput, double petalWInput)
        {
            SepalL = sepalLInput;
            SepalW = sepalWInput;
            PetalL = petalLInput;
            PetalW = petalWInput;
        }

        public Iris(string f1, string f2, string f3, string f4)
        {
            F1 = f1;
            F2 = f2;
            F3 = f3;
            F4 = f4;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public double SepalL { get => sepalL; set => sepalL = value; }
        public double SepalW { get => sepalW; set => sepalW = value; }
        public double PetalL { get => petalL; set => petalL = value; }
        public double PetalW { get => petalW; set => petalW = value; }

        public double DistanceSquare { get => distanceSquare; set => distanceSquare = value; }
        public Centroid Centroid { get => centroid; set => centroid = value; }
        public string F1 { get => f1; set => f1 = value; }
        public string F2 { get => f2; set => f2 = value; }
        public string F3 { get => f3; set => f3 = value; }
        public string F4 { get => f4; set => f4 = value; }
        #endregion

        #region Method
        public void calcDistance(Iris clusterInput)
        {
            /*perhitungan distance square untuk mencari cluster*/
            double sLength, sWidth, pLength, pWidth;
            sLength = Math.Pow((SepalL - clusterInput.SepalL), 2.0);
            sWidth = Math.Pow((SepalW - clusterInput.SepalW), 2.0);
            pLength = Math.Pow((PetalL - clusterInput.PetalL), 2.0);
            pWidth = Math.Pow((PetalW - clusterInput.PetalW), 2.0);

            double newDistSq = sLength + sWidth + pLength + pWidth;

            /*jika nilai distance square baru bukan 0 ataupun lebih kecil
              maka nilai baru akan dimasukkan ke distance square*/
            if (newDistSq != 0 || distanceSquare > newDistSq)
            {
                DistanceSquare = newDistSq;
            }
        }
        #endregion
    }
}
