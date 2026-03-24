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

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        listBox1.Items.Add(sr.ReadLine());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(openFileDialog1.FileName, false);
            sw.Write("");
            listBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                foreach (string s in listBox1.Items)
                {
                    listBox2.Items.Add(s.ToLower());
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (string s in listBox1.Items)
                {
                    listBox2.Items.Add(s.ToUpper());
                }
            }

            foreach (string s in listBox2.Items)
            {
                sw.WriteLine(s.ToString());
            }
            sw.Close();
        }
    }
}
