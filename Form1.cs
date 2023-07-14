using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
        //Variáveis globais
        List<string> extratos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(TxtValor.Text);
            double saldo = double.Parse(LblSaldo.Text.Replace("R$", ""));
            double soma;

            if (LblOperação.Text == "SAQUE")
            {
               soma = saldo- valor;
                extratos.Add("SAQUE no valor de R$ " + valor);

            }
            else
            {
               soma = valor + saldo;
                extratos.Add("DEPÓSITO no valor de R$ " + valor);

            }



            LblSaldo.Text = "R$" + soma;
            
        }

        private void LblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaque_Click(object sender, EventArgs e)
        {
            BtnDeposito.BackColor = Color.Gainsboro;
            BtnDeposito.ForeColor = Color.Black;
            BtnSaque.BackColor = Color.LightBlue;
            BtnSaque.ForeColor = Color.DodgerBlue;
            LblOperação.Text = "SAQUE";
            

        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            BtnSaque.BackColor = Color.Gainsboro;
            BtnSaque.ForeColor = Color.Black;
            BtnDeposito .BackColor = Color.LightBlue;
            BtnDeposito.ForeColor = Color.DodgerBlue;
            LblOperação.Text = "DEPOSITAR";
        }

        private void BtnExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();

        }
    }
}
