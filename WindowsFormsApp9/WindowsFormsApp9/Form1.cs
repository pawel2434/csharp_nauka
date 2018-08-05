using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        double L1,L2,Wynik;
        string RodzajDzialania;
        public Form1()
            
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnSetNumber(object sender, EventArgs e)
        {
            var button = (Button)sender;
            SetNumber(button.Text);
        }


        private void bC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void bmno_Click(object sender, EventArgs e)
        {
            L1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            RodzajDzialania = "*";
        }

        private void bdzie_Click(object sender, EventArgs e)
        {
            L1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            RodzajDzialania = "/";
        }

        private void bdod_Click(object sender, EventArgs e)
        {
            L1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            RodzajDzialania = "+";
        }

        private void bod_Click(object sender, EventArgs e)
        {
            L1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            RodzajDzialania = "-";
        }

        private void bsum_Click(object sender, EventArgs e)
        {
            L2 = Convert.ToDouble(textBox1.Text);

            if (RodzajDzialania == "+")
            {
                Wynik = (L1 + L2);
                textBox1.Text = Convert.ToString(Wynik);
                L1 = Wynik;
            }
            if (RodzajDzialania == "-")
            {
                Wynik = (L1 - L2);
                textBox1.Text = Convert.ToString(Wynik);
                L1 = Wynik;
            }
            if (RodzajDzialania == "*")
            {
                Wynik = (L1 * L2);
                textBox1.Text = Convert.ToString(Wynik);
                L1 = Wynik;
            }
            if (RodzajDzialania == "/")
            {
                if(L2 == 0)
                {
                    textBox1.Text = "Nie można dzielić przez zero";
                }
                else
                {
                    Wynik = (L1 / L2);
                    textBox1.Text = Convert.ToString(Wynik);
                    L1 = Wynik;
                }
            }
        }

        private void SetNumber(string number)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text = textBox1.Text + number;
            }
        }

       
        
    }
}
