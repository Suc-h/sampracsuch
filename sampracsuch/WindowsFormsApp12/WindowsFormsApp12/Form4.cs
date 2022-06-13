using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int NSD(int x, int y)
        {

            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

            return x;
        }
        private bool JePrvocislo(int cislo)
        {
            bool prvocislo = true;

            if (cislo == 2)
            {
                prvocislo = true;
            }
            else
            {
                if (cislo == 1 || cislo % 2 == 0)
                {
                    prvocislo = false;
                }
                else for (int delitel = 3; delitel <= Math.Sqrt(cislo) && prvocislo; ++delitel)
                {
                        if (cislo % delitel == 0) return false;
                }
            }

            return prvocislo;
        }
        void Rozklad(int x, ListBox list)
        {
            list.Items.Clear();
            int help = 1;
            
            int i = 2;

            while (i <= x)
            {
                if (JePrvocislo(i) == false);
                while (x % i == 0)
                {
                    list.Items.Add(i);
                    x =x / i;
                }
                if (i == 3)
                {
                    help = 2;
                }
                i = i+ help;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            Rozklad(x, listBox2);
            Rozklad(y, listBox1);

            label1.Text = NSD(x, y).ToString();
            label2.Text = Convert.ToString((x * y) / NSD(x, y));
        }
    }
}
