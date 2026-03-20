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

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocet = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (!sr.EndOfStream)
                {
                    string radek = sr.ReadLine();
                    if ((radek[0] >= 'A' && radek[0] <= 'Z') && radek[radek.Length - 1] == '.')
                    {
                        pocet++;
                    }
                }
            }
            MessageBox.Show(pocet.ToString());
        }
    }
}
