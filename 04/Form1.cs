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

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("..\\..\\matematika.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\matematika.txt"))
            {
                sw.Write("");
                foreach (string s in listBox1.Items)
                {
                    string[] pr = s.Split(' ');
                    switch (pr[1])
                    {
                        case "+": {
                                int c1 = int.Parse(pr[0]);
                                int c2 = int.Parse(pr[2]);
                                int vys = c1 + c2;
                                string v = ($"{pr[0]} {pr[1]} {pr[2]} {pr[3]} {vys}");
                                sw.WriteLine(v);
                                listBox2.Items.Add(v);
                            } break;

                        case "-":
                            {
                                int c1 = int.Parse(pr[0]);
                                int c2 = int.Parse(pr[2]);
                                int vys = c1 - c2;
                                string v = ($"{pr[0]} {pr[1]} {pr[2]} {pr[3]} {vys}");
                                sw.WriteLine(v);
                                listBox2.Items.Add(v);
                            }
                            break;

                        case "*":
                            {
                                int c1 = int.Parse(pr[0]);
                                int c2 = int.Parse(pr[2]);
                                int vys = c1 * c2;
                                string v = ($"{pr[0]} {pr[1]} {pr[2]} {pr[3]} {vys}");
                                sw.WriteLine(v);
                                listBox2.Items.Add(v);
                            }
                            break;

                        case "/":
                            {
                                int c1 = int.Parse(pr[0]);
                                int c2 = int.Parse(pr[2]);
                                int vys = c1 / c2;
                                string v = ($"{pr[0]} {pr[1]} {pr[2]} {pr[3]} {vys}");
                                sw.WriteLine(v);
                                listBox2.Items.Add(v);
                            }
                            break;
                    }
                }
            }
        }
    }
}
