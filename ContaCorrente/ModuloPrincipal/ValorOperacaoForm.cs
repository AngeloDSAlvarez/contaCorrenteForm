using ContaCorrente.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente.ModuloPrincipal
{
    public partial class ValorOperacaoForm : Form
    {
        private ClienteModel Cliente;
        public ValorOperacaoForm(ClienteModel cliente, bool op)
        {
            Cliente = cliente;
            InitializeComponent();

            if (op)
            {
                lblSenha.Visible = false;
                txtSenha.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool op = txtSenha.Visible;

            if (!op)
            {
                decimal valor = Convert.ToDecimal(txtValor.Text);
                Cliente.Depositar(valor);
                Hide();
            }
            else
            {
                decimal valor = Convert.ToDecimal(txtValor.Text);
                string senha = txtSenha.Text;

                if (Cliente.Senha.Equals(senha))
                {
                    Cliente.Sacar(valor);
                    Hide();
                }
            }
        }

        private void ValorOperacaoForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
