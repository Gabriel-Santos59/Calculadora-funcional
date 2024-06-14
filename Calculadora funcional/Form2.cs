using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_funcional
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Double v1, v2, soma;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            soma = v1 + v2;

            txtResultado.Text = soma.ToString();
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            Double v1, v2, subtração;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            subtração = v1 - v2;

            txtResultado.Text = subtração.ToString();
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            Double v1, v2, multiplicação;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            multiplicação = v1 * v2;

            txtResultado.Text = multiplicação.ToString();
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            Double v1, v2, divisão;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            divisão = v1 / v2;

            txtResultado.Text = divisão.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();

            txtValor1.Focus();
        }
    }
}
