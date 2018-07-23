using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string LiczbaPierwsza , LiczbaDruga;
        char RodzajDialania = ' ';

        private void bsumy_Click(object sender, EventArgs e)
        {
            RodzajDialania = '=';
            tBwynik.Text = "";
        }

        private void bdzielenia_Click(object sender, EventArgs e)
        {
            RodzajDialania = '/';
            tBwynik.Text = "";
        }

        private void bmnorzenia_Click(object sender, EventArgs e)
        {
            RodzajDialania = '*';
            NewMethod();
        }

        private void NewMethod()
        {
            tBwynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
        }

        private void bodejmowania_Click(object sender, EventArgs e)
        {
            RodzajDialania = '-';
            tBwynik.Text = "";
        }

        private void bdodawania_Click(object sender, EventArgs e)
        {
            RodzajDialania = '+';
            tBwynik.Text = "";
        }
        private void tBWynik(object sender, EventArgs e)
        {
            switch (RodzajDialania)
            {
                case ('+'):
                    tBwynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    tBwynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    tBwynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    tBwynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDialania = ' ';
        }
       

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }
      

      
        private void Dzialanie(int liczba)
        {
            if (RodzajDialania == ' ')
            {
                LiczbaPierwsza += liczba;
                tBwynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                tBwynik.Text = LiczbaDruga;
            }
        }
    }
}
