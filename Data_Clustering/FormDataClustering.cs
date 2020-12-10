using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Clustering_LIB;
using Microsoft.VisualBasic.FileIO;

namespace Data_Clustering
{
    public partial class FormDataClustering : Form
    {
        List<Iris> listOfIris;
        List<double> listOfSepalL;
        List<double> listOfSepalW;
        List<double> listOfPetalL;
        List<double> listOfPetalW;
        OpenFileDialog open;


        public FormDataClustering()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfIris = new List<Iris>();
            open = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Comma Separated|*.csv"
            };

            open.ShowDialog();

            try
            {
                if (open.FileName != "")
                {
                    using (TextFieldParser csvParser = new TextFieldParser(open.FileName))
                    {
                        csvParser.CommentTokens = new string[] { "#" };
                        csvParser.SetDelimiters(new string[] { "," });
                        csvParser.HasFieldsEnclosedInQuotes = true;
                        csvParser.ReadLine();
                        while (!csvParser.EndOfData)
                        {
                            string[] fields = csvParser.ReadFields();
                            Iris iris = new Iris(double.Parse(fields[1]), double.Parse(fields[2]), double.Parse(fields[3]), double.Parse(fields[4]));
                            listOfIris.Add(iris);
                        }
                    }
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Centroid centroid = new Centroid();

            //Random data1 = new Random();
            //Random data2 = new Random();
            //Random data3 = new Random();
            //Random data4 = new Random();
            //int decimal_place = 2;
            //centroid.F1 = Math.Round(data1.NextDouble(), decimal_place);
            //centroid.F2 = Math.Round(data2.NextDouble(), decimal_place);
            //centroid.F3 = Math.Round(data3.NextDouble(), decimal_place);
            //centroid.F4 = Math.Round(data4.NextDouble(), decimal_place);


            //listBoxDisplay.Items.Add("F1 = " + centroid.F1.ToString());
            //listBoxDisplay.Items.Add("F2 = " + centroid.F2.ToString());
            //listBoxDisplay.Items.Add("F3 = " + centroid.F3.ToString());

            //listBoxDisplay.Items.Add("F4 = " + centroid.F4.ToString());


            //assign 1 random centroid first
            Random rnd = new Random();
            int f = rnd.Next(0, listOfIris.Count);
            //get the highest distance and set it as 2nd point
            double outResult = 0;
            int sIndex = 0;
            for (int i = 0; i < listOfIris.Count; i++)
            {
                if (i != f)
                {
                    double result = Centroid.CalculateDistance(listOfIris[f], listOfIris[i]);
                    if (outResult < result)
                    {
                        outResult = result;
                        sIndex = i;
                    }
                }
            }
            //find the 3rd centroid based on the average
            double f1 = (listOfIris[f].PetalL + listOfIris[sIndex].PetalL) / 2;
            double f2 = (listOfIris[f].PetalW + listOfIris[sIndex].PetalW) / 2;
            double f3 = (listOfIris[f].SepalL + listOfIris[sIndex].SepalL) / 2;
            double f4 = (listOfIris[f].SepalW + listOfIris[sIndex].SepalL) / 2;
            Centroid centroid1 = new Centroid(listOfIris[f]);
            Centroid centroid2 = new Centroid(listOfIris[sIndex]);
            Centroid centroid3 = new Centroid(f1, f2, f3, f4);
            //nanti itu codingannya dia milih 2 titik data terjauh
            //trus centroid 3 nya nanti baru tengahnya antara 2 itu harusnya bisa 
        }
    }
}
