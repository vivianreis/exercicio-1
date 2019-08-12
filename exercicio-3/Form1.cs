using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double percentual = Convert.ToDouble(txtPercentual.Text);
            double percentualSalario = salario * percentual / 100;
            double novoSalario = salario + percentualSalario;

            MessageBox.Show($"O novo salário do funcionário é de: {novoSalario}");

        }
    }
}
