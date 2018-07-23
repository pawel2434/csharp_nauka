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

        private void button10_Click(object sender, EventArgs e)
        {
            Dzialanie()
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonsumy_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '=';
        }

        private void buttonodejmowania_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
        }

        private void buttondzielenia_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
        }

        private void buttondodawania_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
        }

        private void buttonmnorzenia_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
        }
        private void Dzialanie(int liczba)
        {
            LiczbaPierwsza += liczba;
            tBwynik.Text = LiczbaPierwsza;

        }

        private void tBwynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
