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
    public partial class TransferenciaForm : Form
    {
        private ClienteModel Cliente;
        private RepositorioCliente RepositorioCliente;
        public TransferenciaForm(ClienteModel cliente, RepositorioCliente rep)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.RepositorioCliente = rep;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string agencia = txtAgencia.Text;
            string conta = txtConta.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            string senha = txtSenha.Text;

            if (Cliente.Senha.Equals(senha))
            {
                ClienteModel clienteDestino = RepositorioCliente.EcontreUsuarioPorAgenciaConta(agencia, conta);

                if (clienteDestino != null)
                {
                    Cliente.Transferir(valor, clienteDestino);
                }
                Hide();
                Close();
            }
        }
    }
}
