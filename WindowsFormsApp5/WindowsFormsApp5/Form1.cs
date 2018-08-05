using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza;
        char RodzajDzialania;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Dzialanie(10);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void Buttonsumy_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '=';
        }

        private void Buttonodejmowania_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
        }

        private void Buttondzielenia_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
        }

        private void Buttondodawania_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
        }

        private void Buttonmnorzenia_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
        }
        private void Dzialanie(int liczba)
        {
            LiczbaPierwsza += liczba;
           tBwynik.Text = LiczbaPierwsza;

        }

        private void TBwynik_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
