using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaCorrente cc = new ContaCorrente();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cc.Agencia = txtAgencia.Text;
            cc.Numero = txtNConta.Text;
            cc.Titular = txtTitular.Text;
            cc.Saldo = Convert.ToDouble(txtSaldo.Text);
            cc.Limite = 500;
            MessageBox.Show("Conta criada com sucesso");
        }

        private void txtDepositar_Click(object sender, EventArgs e)
        {
            cc.Depositar(Convert.ToDouble(textValor.Text));
            txtSaldo.Text = cc.Saldo.ToString();
            txtValor.Text = null;
        }

        private void txtSacar_Click(object sender, EventArgs e)
        {
            cc.Sacar(Convert.ToDouble(textValor.Text));
            txtSaldo.Text = cc.Saldo.ToString();
            txtValor.Text = null;
        }

        private void txtExibirSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titular:" + cc.Titular + "\nAgência: " +
                cc.Agencia + "\nNúmero da Conta: " + cc.Numero + "\nSaldo: " +
                cc.Saldo.ToString("c") +"\nvalor do juros: " +
                cc.Calcular().ToString("c"));
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
