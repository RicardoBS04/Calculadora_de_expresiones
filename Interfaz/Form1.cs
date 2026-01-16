using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using clienteTCP;

namespace Interfaz
{

    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "not";
        }
        private void txtExpresion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCero_Click_1(object sender, EventArgs e)
        {
            txtExpresion.Text += "0";
        }

        private void btnUno_Click_1(object sender, EventArgs e)
        {
            txtExpresion.Text += "1";
        }

        private void btnDos_Click_1(object sender, EventArgs e)
        {
            txtExpresion.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "3";
        }

        private void btnCuatro_Click_1(object sender, EventArgs e)
        {
            txtExpresion.Text += "4";
        }

        private void btnCinco_Click_1(object sender, EventArgs e)
        {
            txtExpresion.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "9";
        }

        private void btnParDer_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "(";
        }

        private void btnParIzq_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += ")";
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "/";
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "^";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "%";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "-";
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "and";
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "or";
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            txtExpresion.Text += "xor";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text;

            //enviar_mensaje(expresion);

        }
    }
}
