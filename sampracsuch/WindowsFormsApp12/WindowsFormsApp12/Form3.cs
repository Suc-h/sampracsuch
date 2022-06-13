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
        
        void Smazancisla(string veta, ListBox list)
        {
            listBox1.Items.Clear();
            string cisla = "0123456789";
            while (veta.Contains("  "))
            {
                veta = veta.Replace("  ", " ");
            }
            foreach (char c in cisla)
            {
                if (veta.Contains(c)) {
                    veta = veta.Replace(c.ToString(), "");
                    }
            }


            string[] slova = veta.Split(' ');


            foreach (string slovo in slova)
            {
                list.Items.Add(slovo);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            Smazancisla(veta,listBox1);
        }
    }
}
