using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploEventos.Formulario
{
    public partial class FormCalculo : Form
    {
        public FormCalculo()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = 0;
            double valor2 = 0;
            double divisao = 0;

            //divisao = valo1/valor2

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);
            divisao = (valor1 / valor2);

            txtResultado.Text = divisao.ToString();

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtValor1.Text = string.Empty;
            txtValor2.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtValor1.Select();
            }
            if ((e.KeyChar) == ',' || char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor1.Clear();
                txtValor1.Select();
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtValor2.Select();
            }
            if ((e.KeyChar) == ',' || char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor1.Clear();
                txtValor1.Select();
            }
        }
    }
}
