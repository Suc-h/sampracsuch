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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        string[] pole;
        string alfanum = "1234567890qwertzuiopasdfghjklyxcvbnmQWERTZUIOPASDFGHJKLYXCVBNM";
        void JeAlfanum(ref int malapis, ref int velkapis, ref int jineznaky, string textbox, ref bool alfanumericke)
        {
            
            foreach(char znak in textbox)
            {
                if(alfanum.Contains(znak))
                {
                    if(znak>=61 && znak <=122)
                    {
                        malapis++;

                    }
                    if(znak>=65 && znak <=90)
                    {
                        velkapis++;
                    }

                    alfanumericke = true;
                }
                else
                {
                    jineznaky++;
                    alfanumericke = false;
                }

            }

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool alfanumericke=true ;
            int mala=0, velka=0, jine=0;
            JeAlfanum(ref mala,ref velka,ref jine, textBox1.Text,ref alfanumericke);
            label1.Text = "Malá písmena: " + mala;
            label2.Text = "Velká písmena: " + velka;
            label3.Text = "Jiné znaky: " + jine;
            label4.Text = "Je alfanumerický?" + alfanumericke;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                    }
    }
}
