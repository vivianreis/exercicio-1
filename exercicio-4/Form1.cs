using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double tempo = Convert.ToDouble(txtTempo.Text);
            double velocidade = Convert.ToDouble(txtVelocidade.Text);
            double distancia = tempo * velocidade;
            double qtdLitrosUsada = distancia / 12; //colocar o 12 dentro de uma variável e chamar a variável na hora da divisão

            MessageBox.Show($@"A velocidade média foi de: {velocidade} km/h
O tempo gasto na viagem foi de: {tempo} horas
A distancia percorrida foi de: {distancia} Km
A quantidade de litros usada foi de: {qtdLitrosUsada} litros");
        }
    }
}
