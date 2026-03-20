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

namespace _06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("..\\..\\knihy.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\starsi.txt"))
            {
                foreach (string s in listBox1.Items)
                {
                    string[] casti = s.Split(';');
                    string datum = casti[4];
                    string[] d = datum.Split('.');
                    int rok = int.Parse(d[2]);
                    if (rok < 1950)
                    {
                        sw.WriteLine(s);
                        listBox2.Items.Add(s);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\mladsi.txt"))
            {
                foreach (string s in listBox1.Items)
                {
                    string[] casti = s.Split(';');
                    string datum = casti[4];
                    string[] d = datum.Split('.');
                    int rok = int.Parse(d[2]);
                    if (rok > 1950)
                    {
                        sw.WriteLine(s);
                        listBox3.Items.Add(s);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            string autor = textBox1.Text;
            foreach (string s in listBox1.Items)
            {
                string[] casti = s.Split(';');
                string a = casti[1];
                if (a == autor)
                {
                    listBox4.Items.Add(s);
                    break;
                }
            }
        }
    }
}
