using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {        
            decimal numero = Convert.ToDecimal(txtNumero.Text);
            decimal multiplicacao = numero * numero;
            MessageBox.Show($"O resultado do número multiplicado por ele mesmo é igual a: {multiplicacao}");      
        }
    }
}
