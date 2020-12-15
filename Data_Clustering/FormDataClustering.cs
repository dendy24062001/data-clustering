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
        string line = "";


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
            line = "";
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
                line += CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3).ToString();
                line += "\n";
            }
            MessageBox.Show(irisC1.Count.ToString(), irisC2.Count.ToString() + " " + irisC3.Count.ToString());
            foreach (Iris i in listOfIris)
            {
                if (centroid1 == i.Centroid)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Setosa");
                }
                else if (centroid2 == i.Centroid)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Versicolor");
                }
                else if (centroid3 == i.Centroid)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Virginica");
                }
            }
        }

        private void buttonCoba_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            double rand1 = 0, rand2 = 0, rand3 = 0, rand4 = 0;

            rand1 = random.NextDouble();
            rand2 = random.NextDouble();
            rand3 = random.NextDouble();
            rand4 = random.NextDouble();

            MessageBox.Show($"F1 : {rand1}, F2 : {rand2}, F3 : {rand3}, F4 : {rand4}");
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

        /*private void Try()
        {
            List<Iris> listSetosa = new List<Iris>();
            List<Iris> listVersicolor = new List<Iris>();
            List<Iris> listVirginica = new List<Iris>();

            Random random = new Random();

            Centroid IrisSetosa = new Centroid("Setosa", random);
            Centroid IrisVersicolor = new Centroid("Versicolor", random);
            Centroid IrisVirginica = new Centroid("Virginica", random);

            foreach (Iris iris in listOfIris)
            {
                iris.Centroid = CentroidMover.CountDistAndAssignCentroid(iris, IrisSetosa, IrisVersicolor, IrisVirginica);
                dataGridViewDataCluster.Rows.Add(
                    iris.SepalL,
                    iris.SepalW,
                    iris.PetalL,
                    iris.PetalW,
                    iris.Centroid.Name);
            }

            foreach(Iris iris in listOfIris)
            {
                if(iris.Centroid.Name == IrisSetosa.Name)
                {
                    listSetosa.Add(iris);
                }
                else if(iris.Centroid.Name == IrisVersicolor.Name)
                {
                    listVersicolor.Add(iris);
                }
                else
                {
                    listVirginica.Add(iris);
                }
            }*/

            

            /*
            listBoxDisplay.Items.Add($"Setosa : F1 : {IrisSetosa.F1, 2}, F2 : {IrisSetosa.F2}, F3 : {IrisSetosa.F3}, F4 : {IrisSetosa.F4}");
            listBoxDisplay.Items.Add($"Versicolor : F1 : {IrisVersicolor.F1}, F2 : {IrisVersicolor.F2}, F3 : {IrisVersicolor.F3}, F4 : {IrisVersicolor.F4}");
            listBoxDisplay.Items.Add($"Virginica : F1 : {IrisVirginica.F1}, F2 : {IrisVirginica.F2}, F3 : {IrisVirginica.F3}, F4 : {IrisVirginica.F4}");
            


        }*/

        private void buttonDetermine_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //Iris cluster;

            //List<Iris> listOfCluster = new List<Iris>();

            //double max;
            //int detRandom, clusterNumb;
            //detRandom = random.Next(0, listOfIris.Count - 1);
            //clusterNumb = (int)numericUpDownClusterNumber.Value;

            //cluster = listOfIris[detRandom];
            //listOfCluster.Add(cluster);
            //foreach(Iris iris in listOfIris)
            //{
            //    iris.calcDistance(cluster);               
            //}

            //for(int i = 1; i < clusterNumb; i++)
            //{
            //    max = listOfIris[0].DistanceSquare;
            //    for (int j = 1; j < listOfIris.Count; j++)
            //    {
            //        if (max < listOfIris[i].DistanceSquare)
            //        {
            //            cluster = listOfIris[i];
            //        }
            //    }
            //    listOfCluster.Add(cluster);
            //    foreach (Iris iris in listOfIris)
            //    {
            //        iris.calcDistance(cluster);
            //    }
            //}
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
            line = "";
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
                        MessageBox.Show(iteration.ToString());
                    }

                    else if (sseOld == sseNew)
                    {
                        stop = true;
                        MessageBox.Show(iteration.ToString());
                    }

                    else
                    {
                        centroid1 = c1New;
                        centroid2 = c2New;
                        centroid3 = c3New;
                    }
                
                iteration++;
                        listBoxDisplay.Items.Add(CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3));
                line += CentroidMover.CalcSSE(listOfIris, centroid1, centroid2, centroid3).ToString();
                line += "\n";
            }
            dataGridViewDataCluster.Rows.Clear();
            foreach (Iris i in listOfIris)
            {
                if (centroid1 == i.Centroid)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Setosa");
                }
                else if (centroid2 == i.Centroid)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Versicolor");
                }
                else if (centroid3 == i.Centroid)
                {
                    dataGridViewDataCluster.Rows.Add(i.SepalL, i.SepalW, i.PetalL, i.PetalW, "Virginica");
                }
            }
            MessageBox.Show(irisC1.Count.ToString(), irisC2.Count.ToString() +" "+ irisC3.Count.ToString());
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save List";
            saveFileDialog.FileName = "Hasil.txt";
            saveFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(file, line);
                file.Close();
            }
        }
    }
}
