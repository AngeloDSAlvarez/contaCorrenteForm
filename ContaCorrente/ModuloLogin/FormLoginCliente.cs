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

namespace ContaCorrente.ModuloLogin
{
    public partial class FormLoginCliente : Form
    {
        public ClienteModel ClienteLogado {  get; set; }
        AutenticadorController AutenticadorController { get; set; }
        public FormLoginCliente()
        {
            InitializeComponent();
            AutenticadorController = new AutenticadorController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            string senha = txtSenha.Text;
            try
            {
                ClienteLogado = AutenticadorController.Autenticar(cpf, senha);
                if (ClienteLogado != null)
                {
                    Hide();
                }
            }
            catch (Exception ex)
            {
                statusStripLogin.Visible = true;
                statusStripLogin.Text = ex.Message;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
