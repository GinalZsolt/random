using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomsorrend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] tomb = new int[20];
        static int[] tomb2 = new int[20];
        static bool[] tomb3=new bool[20];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 101);
                listBox1.Items.Add(tomb[i]);
            }
            for (int i = 0; i < tomb2.Length; i++)
            {
                tomb3[i] = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            bool tele = false;
            for(;tele==false;)
            {
                for (int i = 0; i < tomb.Length; i++)
                {
                    int x = r.Next(0, tomb2.Length);
                    if (tomb3[x] == false)
                    {
                        tomb2[x] = tomb[i];
                        tomb3[x] = true;
                    }

                }
                bool nemjo = false;
                for (int i = 0; i <tomb3.Length; i++)
                {
                    if (tomb3[i]==false)
                    {
                        nemjo = true;
                        break;
                    }
                }
                if (nemjo==false) tele = true;
             
            }
            for (int i = 0; i < tomb2.Length; i++)
            {
                listBox2.Items.Add(tomb2[i]);
            }
        }
    }
}
