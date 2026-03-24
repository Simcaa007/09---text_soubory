using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }


                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(openFileDialog1.FileName);
            int celkem = 0;
            foreach (string s in listBox1.Items)
            {
                string[] cisla = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int soucet = 0;
                foreach (string c in cisla)
                {
                    int cislo = int.Parse(c);
                    soucet += cislo;
                }
                listBox2.Items.Add(s + " soucet je: " +  soucet);
                sw.WriteLine(s + " soucet je: " + soucet);
                celkem += soucet;
            }

            listBox2.Items.Add("Celkem soucet je: " + celkem);
            sw.WriteLine("Celkem soucet je: " + celkem);

            sw.Close();
        }
    }
}
