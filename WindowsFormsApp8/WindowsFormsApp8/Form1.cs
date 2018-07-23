using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Calkulator : Form
    {
        public Calkulator()
        {
            InitializeComponent();
        }
        string l1, l2;
        char Rodzajdzialania;

        public int Dzialanie { get; private set; }

        private void bmnorzenia_Click(object sender, EventArgs e)
        {
            Rodzajdzialania='*';
        }

        private void bdodawania_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '+';
        }

        private void bodejmowania_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '-';
        }

        private void bdzielenia_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '/';
        }

        private void bsumy_Click(object sender, EventArgs e)
        {
            Rodzajdzialania = '=';
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie = (9);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie = (8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie = (7);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie = (6);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie = (5);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie = (4);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie = (2);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie = (1);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie = (0);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie = (3);
        }

        private void tBwynik_TextChanged(object sender, EventArgs e)
        {
            tBwynik.Text = int.Parse(Dzialanie).ToString();
        }
    }
}
