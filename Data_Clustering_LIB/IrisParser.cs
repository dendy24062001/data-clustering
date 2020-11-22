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

        public static List<int> GetSepalLength(string filePath)
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
                    listInt.Add(int.Parse(fields[1]));
                }
                return listInt;
            }
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
