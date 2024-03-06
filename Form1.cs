using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormComplejo
{
    public partial class Form1 : Form
    {

        private Complejo complejo1;
        private Complejo complejo2;
        private Complejo complejo3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            complejo1 = Complejo.Leer(txtbComplejo1.Text);
            complejo2 = Complejo.Leer(txtbComplejo2.Text);

            complejo3 = complejo1 + complejo2;
            lbResultComplejo.Text = complejo3.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            complejo1 = Complejo.Leer(txtbComplejo1.Text);
            complejo2 = Complejo.Leer(txtbComplejo2.Text);

            complejo3 = complejo1 - complejo2;
            lbResultComplejo.Text = complejo3.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            complejo1 = Complejo.Leer(txtbComplejo1.Text);
            complejo2 = Complejo.Leer(txtbComplejo2.Text);
            complejo3 = complejo1 * complejo2;
            lbResultComplejo.Text = complejo3.ToString();
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSumar_MouseHover(object sender, EventArgs e)
        {
            lbOperador.Text = "+";
        }

        private void btnRestar_MouseHover(object sender, EventArgs e)
        {
            lbOperador.Text = "-";
        }

        private void btnMultiplicar_MouseHover(object sender, EventArgs e)
        {
            lbOperador.Text = "*";
        }

        private void btnConjugar_MouseHover(object sender, EventArgs e)
        {
            lbOperador.Text = "c";
        }

        
    }
}
