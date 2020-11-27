using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;


namespace Data_Clustering_LIB
{
    public class IrisParser
    {
        public static List<double> GetSepalL(List<Iris> listOfIris)
        {
            List<double> listOfSepalL = new List<double>();
            foreach(Iris iris in listOfIris)
            {
                listOfSepalL.Add(iris.SepalL);
            }
            return listOfSepalL;
        }

        public static List<double> GetSepalW(List<Iris> listOfIris)
        {
            List<double> listOfSepalW = new List<double>();
            foreach (Iris iris in listOfIris)
            {
                listOfSepalW.Add(iris.SepalW);
            }
            return listOfSepalW;
        }

        public static List<double> GetPetalL(List<Iris> listOfIris)
        {
            List<double> listOfPetalL = new List<double>();
            foreach (Iris iris in listOfIris)
            {
                listOfPetalL.Add(iris.SepalL);
            }
            return listOfPetalL;
        }

        public static List<double> GetPetalW(List<Iris> listOfIris)
        {
            List<double> listOfPetalW = new List<double>();
            foreach (Iris iris in listOfIris)
            {
                listOfPetalW.Add(iris.SepalW);
            }
            return listOfPetalW;
        }

        public static List<int> GetSepalWidth(string filePath)
        {
            List<int> listInt = new List<int>();
            using (TextFieldParser text = new TextFieldParser(filePath))
            {
                text.CommentTokens = new string[] { "#" };
                text.SetDelimiters(new string[] { "," });
                text.HasFieldsEnclosedInQuotes = true;

                text.ReadLine();

                while (!text.EndOfData)
                {
                    string[] fields = text.ReadFields();
                    listInt.Add(int.Parse(fields[2]));
                }
                return listInt;
            }

        }

        public static List<int> GetPetalLength(string filePath)
        {
            List<int> listInt = new List<int>();
            using (TextFieldParser text = new TextFieldParser(filePath))
            {
                text.CommentTokens = new string[] { "#" };
                text.SetDelimiters(new string[] { "," });
                text.HasFieldsEnclosedInQuotes = true;

                text.ReadLine();

                while (!text.EndOfData)
                {
                    string[] fields = text.ReadFields();
                    listInt.Add(int.Parse(fields[2]));
                }
                return listInt;
            }
        }

        public static List<int> GetPetalWidth(string filePath)
        {
            List<int> listInt = new List<int>();
            using (TextFieldParser text = new TextFieldParser(filePath))
            {
                text.CommentTokens = new string[] { "#" };
                text.SetDelimiters(new string[] { "," });
                text.HasFieldsEnclosedInQuotes = true;

                text.ReadLine();

                while (!text.EndOfData)
                {
                    string[] fields = text.ReadFields();
                    listInt.Add(int.Parse(fields[2]));
                }
                return listInt;
            }
        }
    }
}
