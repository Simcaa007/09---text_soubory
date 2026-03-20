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

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("..\\..\\Text.txt"))
            {
                string text = sr.ReadToEnd();
                int pozice = 1;
                foreach (char ch in  text)
                {
                    if (ch == '?')
                    {
                        MessageBox.Show($"Byl nalezen otaznik a to jako {pozice} znak");
                    }
                    pozice++;
                }
            }
        }
    }
}
