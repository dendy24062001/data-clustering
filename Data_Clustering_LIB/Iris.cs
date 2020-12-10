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
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public double SepalL { get => sepalL; set => sepalL = value; }
        public double SepalW { get => sepalW; set => sepalW = value; }
        public double PetalL { get => petalL; set => petalL = value; }
        public double PetalW { get => petalW; set => petalW = value; }
        public Centroid Centroid { get => centroid; set => centroid = value; }
        #endregion
    }
}
