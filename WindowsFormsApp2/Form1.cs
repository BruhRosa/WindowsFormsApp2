using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaCorrente cc = new ContaCorrente();

        private void btncriar_Click(object sender, EventArgs e)
        {
            cc.Agencia = txtagencia.Text;
            cc.Agencia = txtconta.Text;
            cc.Titular = txtitular.Text;
            cc.Saldo = Convert.ToDouble(txtsaldo.Text);
            cc.Limite = 500;
            MessageBox.Show("Conta criada com sucesso!!");
        }

        private void btndepositar_Click(object sender, EventArgs e)
        {
            cc.Depositar(Convert.ToDouble(txtvalor.Text));
            txtsaldo.Text = cc.Saldo.ToString();
            txtvalor.Text = null;
        }

        private void btnsacar_Click(object sender, EventArgs e)
        {
            cc.Sacar(Convert.ToDouble(txtvalor.Text));
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titular: " + cc.Titular + "\nAgência: " + cc.Agencia + "\nNúmero da Conta: " +
                cc.Numero + "\nSaldo: " + cc.Saldo.ToString("C") + "\nValor do júros: " +
                cc.Calcular().ToString("C"));
        }
    }
}
