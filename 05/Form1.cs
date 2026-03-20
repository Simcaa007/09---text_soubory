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

namespace _05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader("..\\..\\cislo.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soucet = 0;
            int pocetSudych = 0;
            int pocetLichych = 0;

            foreach(string s in listBox1.Items)
            {
                int c = int.Parse(s);
                if (c % 2 == 0)
                {
                    pocetSudych++;
                }
                else
                {
                    pocetLichych++;
                }
                soucet += c;
            }

            using(StreamWriter sw = new StreamWriter("..\\..\\cislo.txt", true))
            {
                sw.WriteLine("");
                sw.WriteLine("soucet: " + soucet);
                sw.WriteLine("pocet lichych: " + pocetLichych);
                sw.WriteLine("pocet sudych: " + pocetSudych);
            }

            using (StreamReader sr = new StreamReader("..\\..\\cislo.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox2.Items.Add(sr.ReadLine());
                }
            }
        }
    }
}
