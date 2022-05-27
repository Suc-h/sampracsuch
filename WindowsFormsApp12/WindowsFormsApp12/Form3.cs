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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string alfanum = "0123456789";
        void smazcisla(ref string slovo)
        {
            foreach (char znak in slovo)
            {
                if (alfanum.Contains(znak))
                {
                    if (znak >= 48 && znak <= 57)
                    {
                        slovo.Replace(slovo,"");


                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string vstup = textBox1.Text;
            vstup = vstup.Trim();
            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }
            string[] slova = vstup.Split(' ');
                string slovo;
            foreach (string slovicka in slova)
            {
                slovo = slovicka;
                smazcisla(ref slovo);
                listBox1.Items.Add(slovo);

            }
        }
    }
}
