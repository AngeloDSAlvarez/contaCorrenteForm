using ContaCorrente.ModuloCliente;
using ContaCorrente.ModuloLogin;
using ContaCorrente.ModuloPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class BancoForm : Form
    {
        private TelaClienteForm TelaClienteForm;
        private ClienteModel Cliente;
        private readonly RepositorioCliente RepositorioCliente;


        public BancoForm()
        {
            RepositorioCliente = new RepositorioCliente();
            while (true)
            {
                InitializeComponent();

                FormLoginCliente formLoginCliente = new FormLoginCliente();
                formLoginCliente.ShowDialog();

                Cliente = formLoginCliente.ClienteLogado;
                formLoginCliente.Close();

                TelaClienteForm = new TelaClienteForm(Cliente, RepositorioCliente);
                TelaClienteForm.ShowDialog();
                RepositorioCliente = TelaClienteForm.RepositorioCliente;
            }
        }
    }
}
