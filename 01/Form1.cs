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

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);

                for (int i = 1; i <= n; i++)
                {
                    int pocet = i;
                    while (pocet > 0)
                    {
                        sw.Write('*');
                        pocet--;
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
    }
}
