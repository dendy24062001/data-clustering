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

        #region Constructor
        public Iris()
        {
            Id = 0;
            SepalL = 0.0;
            SepalW = 0.0;
            PetalL = 0.0;
            PetalW = 0.0;
        }
        public Iris(int idInput, double sepalLInput, double sepalWInput, double petalLInput, double petalWInput)
        {
            Id = idInput;
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
        #endregion
    }
}
