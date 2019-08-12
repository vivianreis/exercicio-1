using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = txtNome.Text;
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            decimal totalVendas = Convert.ToDecimal(txtTotal.Text);
            decimal taxa = 0.1M;
            decimal salarioTotal = salario + (totalVendas * taxa);

            MessageBox.Show($"O salário do {nomeFuncionario} este mês é : {salarioTotal}");
        }
    }
}
