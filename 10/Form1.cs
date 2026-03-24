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

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pocetSlov;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string radek = sr.ReadLine();
                        listBox1.Items.Add(radek);  
                        string[] slova = radek.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        pocetSlov += slova.Length;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter(openFileDialog1.FileName, true))
            {
                sw.WriteLine(pocetSlov);
            }

            using(StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                while (!sr.EndOfStream)
                {
                    listBox2.Items.Add(sr.ReadLine());
                }
            }
        }
    }
}
