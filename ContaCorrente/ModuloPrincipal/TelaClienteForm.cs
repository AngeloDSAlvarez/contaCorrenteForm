using ContaCorrente.ModuloCliente;
using ContaCorrente.ModuloLogin;
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
    public partial class TelaClienteForm : Form
    {
        private ClienteModel Cliente;
        public readonly RepositorioCliente RepositorioCliente;

        public TelaClienteForm(ClienteModel cliente, RepositorioCliente repositorioCliente)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.RepositorioCliente = repositorioCliente;

            AtualizarEstilo();
            AtualizarInfo();
        }
        private void AtualizarInfo()
        {
            lblNome.Text = Cliente.Nome;
            lblSaldo.Text = Convert.ToString(Cliente.Saldo);
            lblLimite.Text = Convert.ToString(Cliente.Limite);
        }

        private void AtualizarEstilo()
        {
            if (Cliente.Saldo < 0)
            {
                lblSaldo.ForeColor = Color.Red;
            }
            else
            {
                lblSaldo.ForeColor = Color.Green;
            }

            if (Cliente.Limite < 0)
            {
                lblLimite.ForeColor = Color.Red;
            }
            else
            {
                lblLimite.ForeColor = Color.Green;
            }
        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            ValorOperacaoForm valorOperacaoForm = new ValorOperacaoForm(Cliente, false);
            valorOperacaoForm.ShowDialog();
            AtualizarInfo();
            AtualizarEstilo();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ValorOperacaoForm valorOperacaoForm = new ValorOperacaoForm(Cliente, true);
            valorOperacaoForm.ShowDialog();
            AtualizarInfo();
            AtualizarEstilo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            TransferenciaForm transferenciaForm = new TransferenciaForm(Cliente, RepositorioCliente);
            transferenciaForm.ShowDialog();
            AtualizarInfo();
            AtualizarEstilo();
        }
    }

}
