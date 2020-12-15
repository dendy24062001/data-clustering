using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Clustering_LIB;
using Microsoft.VisualBasic.FileIO;

namespace Data_Clustering
{
    public partial class FormDataClustering : Form
    {
        List<Iris> listOfIris = new List<Iris>();
        List<double> listOfSepalL;
        List<double> listOfSepalW;
        List<double> listOfPetalL;
        List<double> listOfPetalW;
        List<string> listString = new List<string>();
        List<double> listDouble = new List<double>();
        OpenFileDialog open;
        Centroid centroid3;
        Centroid centroid2;
        Centroid centroid1;
        List<double> listSSE;


        public FormDataClustering()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfIris = new List<Iris>();
            open = new OpenFileDialog
            {
                //InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Comma Separated|*.csv"
            };

            open.ShowDialog();

            try
            {
                if (open.FileName != "")
                {
                    CsvParse(open.FileName);
                }
                else
                {
                    MessageBox.Show("File Kosong", "Error");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Terjadi sebuah kesalahan. Pesan Error: " + error, "Error");
            }
        }

        private void CsvParse(string pathFile)
        {
            using (TextFieldParser csvParser = new TextFieldParser(pathFile))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                

                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    // Iris iris = new Iris(
                    //     Convert.ToDouble(fields[1]),
                    //     Convert.ToDouble(fields[2]),
                    //     Convert.ToDouble(fields[3]),
                    //     Convert.ToDouble(fields[4]));



                    Iris iris = new Iris(
                         double.Parse(fields[1]),
                         double.Parse(fields[2]),
                         double.Parse(fields[3]),
                         double.Parse(fields[4]));

                    // Iris iris = new Iris(
                    //     fields[1],
                    //     fields[2],
                    //     fields[3],
                    //     fields[4]);

                    //Iris iris = new Iris(
                    //    double.Parse(fields[1].Replace('.', ',')),
                    //    double.Parse(fields[2].Replace('.', ',')),
                    //    double.Parse(fields[3].Replace('.', ',')),
                    //    double.Parse(fields[4].Replace('.', ',')));


                    listOfIris.Add(iris);

                    listString.Add(fields[1]);
                }
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            
            //button untuk menampilkan dataset Iris kedalam DataGridView
            //try
            //{
            //    dataGridViewDataCluster.DataSource = null;
            //    if (open.FileName != "")
            //    {
            //        if (listOfIris.Count > 0)
            //        {
            //            dataGridViewDataCluster.DataSource = listOfIris;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("File Kosong", "Error");
            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Tidak Bisa Menampilkan File. Pesan Error: " + error, "Error");
            //}
        }

        #region properti
        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfSepalL = IrisParser.GetSepalL(listOfIris);

            listBoxDisplay.Items.Clear();
            listBoxDisplay.Items.Add("Sepal Length");
            for (int i = 0; i < listOfSepalL.Count; i++)
            {
                listBoxDisplay.Items.Add($"{listOfSepalL[i]}");
            }
        }

        private void widthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfSepalW = IrisParser.GetSepalW(listOfIris);

            listBoxDisplay.Items.Clear();
            listBoxDisplay.Items.Add("Sepal Width");
            for (int i = 0; i < listOfSepalW.Count; i++)
            {
                listBoxDisplay.Items.Add($"{listOfSepalW[i]}");
            }
        }

        private void lengthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listOfPetalL = IrisParser.GetPetalL(listOfIris);

            listBoxDisplay.Items.Clear();
            listBoxDisplay.Items.Add("Petal Length");
            for (int i = 0; i < listOfPetalL.Count; i++)
            {
                listBoxDisplay.Items.Add($"{listOfPetalL[i]}");
            }
        }

        private void widthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listOfPetalW = IrisParser.GetPetalW(listOfIris);

            listBoxDisplay.Items.Clear();
            listBoxDisplay.Items.Add("Petal Width");
            for (int i = 0; i < listOfPetalW.Count; i++)
            {
                listBoxDisplay.Items.Add($"{listOfPetalW[i]}");
            }
        }

        private void FormDataClustering_Load(object sender, EventArgs e)
        {
            buttonAutoRun.Visible = false;
            buttonRun.Visible = false;
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            listSSE = new List<double>();
            int iteration = 0;
            List<Iris> irisC1 = new List<Iris>();
            List<Iris> irisC2 = new List<Iris>();
            List<Iris> irisC3 = new List<Iris>();
            while (iteration < numericUpDownClusterNumber.Value)
            {
                irisC1 = new List<Iris>();
                irisC2 = new List<Iris>();
                irisC3 = new List<Iris>();
                foreach (Iris i in listOfIris)
                {
                    i.Centroid = CentroidMover.CountDistAndAssignCentroid(i, centroid1, centroid2, centroid3);
                    if (i.Centroid == centroid1)
                        irisC1.Add(i);
                    else if (i.Centroid == centroid2)
                        irisC2.Add(i);
                    else if (i.Centroid == centroid3)
                        irisC3.Add(i);
                }
                centroid1 = Centroid.HitungPosisiCentroid(irisC1, "Setosa");
                centroid2 = Centroid.HitungPosisiCentroid(irisC2, "Versicolor");
                centroid3 = Centroid.HitungPosisiCentroid(irisC3, "Virginica");
                iteration++;
                listBoxDisplay.Items.Add(CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3));
                listSSE.Add( CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3));
               
            }
            dataGridViewDataCluster.Rows.Clear();
            foreach (Iris i in listOfIris)
            {
                if (centroid1.Name == i.Centroid.Name)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Setosa");
                }
                else if (centroid2.Name == i.Centroid.Name)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Versicolor");
                }
                else if (centroid3.Name == i.Centroid.Name)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Virginica");
                }
            }
            MessageBox.Show("Setosa : " + irisC1.Count.ToString() + "\nVersicolor : " + irisC2.Count.ToString() + "\nVirginica : " + irisC3.Count.ToString(), "Setosa, VersiColor, and Virginica Amount :"); 
        }

      

        private void buttonCoba_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\Users\Golden\Documents\PBD\data-clustering\Iris Dataset\Iris.csv";
            CsvParse(path);
           if(listOfIris.Count > 0)
            {
                MessageBox.Show(listOfIris.Count.ToString());
            }

        }

       

        private void buttonDetermine_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int f = 0;
            f = rnd.Next(1, listOfIris.Count - 1);

            //get the highest distance and set it as 2nd point
            double outResult = 0;
            int sIndex = 0;
            for (int i = 0; i < listOfIris.Count; i++)
            {
                    double result = Centroid.CalculateDistanceIris(listOfIris[f], listOfIris[i]);
                    if (outResult < result)
                    {
                        outResult = result;
                        sIndex = i;
                    }
            }
            //find the 3rd centroid based on the average
            double f3 = (listOfIris[f].PetalL + listOfIris[sIndex].PetalL) / 2;
            double f4 = (listOfIris[f].PetalW + listOfIris[sIndex].PetalW) / 2;
            double f1 = (listOfIris[f].SepalL + listOfIris[sIndex].SepalL) / 2;
            double f2 = (listOfIris[f].SepalW + listOfIris[sIndex].SepalW) / 2;

            centroid1 = new Centroid(listOfIris[f].SepalL, listOfIris[f].SepalW, listOfIris[f].PetalL, listOfIris[f].PetalW, "Setosa");
            centroid2 = new Centroid(listOfIris[sIndex].SepalL, listOfIris[sIndex].SepalW, listOfIris[sIndex].PetalL, listOfIris[sIndex].PetalW, "Versicolor");
            centroid3 = new Centroid(f1, f2, f3, f4, "Virginica");
            buttonAutoRun.Visible = true;
            buttonRun.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listSSE = new List<double>();
            int iteration = 0;
            bool stop = false;
            Centroid c1New;
            Centroid c2New;
            Centroid c3New;
            List<Iris> irisC1 = new List<Iris>();
            List<Iris> irisC2 = new List<Iris>();
            List<Iris> irisC3 = new List<Iris>();
            
            while (stop == false)
            {
                irisC1 = new List<Iris>();
                irisC2 = new List<Iris>();
                irisC3 = new List<Iris>();
                double sseOld = 0;
                foreach (Iris i in listOfIris)
                {
                    if(iteration != 0)
                         sseOld = CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3);
                    i.Centroid = CentroidMover.CountDistAndAssignCentroid(i, centroid1, centroid2, centroid3);
                    if (i.Centroid == centroid1)
                    {
                        irisC1.Add(i);
                    }
                    else if (i.Centroid == centroid2)
                    {
                        irisC2.Add(i);
                    }
                    else if (i.Centroid == centroid3)
                    {
                        irisC3.Add(i);
                    }
                }
                
                    c1New = Centroid.HitungPosisiCentroid(irisC1, "Setosa");
                    c2New = Centroid.HitungPosisiCentroid(irisC2, "Versicolor");
                    c3New = Centroid.HitungPosisiCentroid(irisC3, "Virginica");
                    double sseNew = CentroidMover.CalcSSE(listOfIris, c1New, c2New, c3New);
                    if (c1New == centroid1 && c2New == centroid2 && c3New == centroid3)
                    {
                        stop = true;
                        MessageBox.Show("Your Dataset is finished after  " + iteration.ToString() + " of iteration");
                    }

                    else if (sseOld == sseNew)
                    {
                        stop = true;
                        MessageBox.Show("Your Dataset is finished after  " + iteration.ToString() + " of iteration");
                    }

                    else
                    {
                        centroid1 = c1New;
                        centroid2 = c2New;
                        centroid3 = c3New;
                    }
                
                iteration++;
                        listBoxDisplay.Items.Add(CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3));
                listSSE.Add(CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3));
              
            }
            dataGridViewDataCluster.Rows.Clear();
            foreach (Iris i in listOfIris)
            {
                if (centroid1.Name == i.Centroid.Name)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Setosa");
                }
                else if (centroid2.Name == i.Centroid.Name)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Versicolor");
                }
                else if (centroid3.Name == i.Centroid.Name)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Virginica");
                }
            }
            MessageBox.Show("Setosa : " + irisC1.Count.ToString() + "\nVersicolor : " + irisC2.Count.ToString() + "\nVirginica : " + irisC3.Count.ToString(), "Setosa, VersiColor, and Virginica Amount :");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFile.FileName, FileMode.Create))
                using(StreamWriter file = new StreamWriter(s))
                {
                    foreach(double angka in listSSE)
                    {
                        i++;
                        file.WriteLine($"{angka}, Iterasi ke-{i}");
                    }

                    double smallest = Smallest(listSSE);

                    file.WriteLine($"SSE Terkecil {smallest}");

                }
            }
        }

      

        private double Smallest(List<double> sse)
        {
            double small = sse[0];

            foreach(double number in sse)
            {
                if (number < small)
                {
                    small = number;
                }
            }

            return small;
        }
    }
}
