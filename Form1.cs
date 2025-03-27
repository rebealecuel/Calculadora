using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txbNum1.Text = "";
            txbNum2.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbNum2.Text);

            MessageBox.Show($"Resultado: {num1 + num2}");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbNum2.Text);

            MessageBox.Show($"Resultado: {num1 - num2}");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbNum2.Text);

            MessageBox.Show($"Resultado: {num1 * num2}");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbNum2.Text);

            MessageBox.Show($"Resultado: {num1 / num2}");
        }

        private void btnResiduo_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNum1.Text);
            int num2 = Convert.ToInt32(txbNum2.Text);

            MessageBox.Show($"Resultado: {num1 % num2}");
        }
    }
}
