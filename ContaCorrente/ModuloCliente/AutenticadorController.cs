using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ModuloCliente
{
    public class AutenticadorController
    {
        private readonly RepositorioCliente RepositorioCliente;

        public AutenticadorController()
        {
            RepositorioCliente = new RepositorioCliente();
        }

        public ClienteModel Autenticar (string cpf, string senha)
        {
            ClienteModel? cliente = new ClienteModel()
            {
                Cpf = cpf,
                Senha = senha
            };

            if (cliente.Validar() != String.Empty)
            {
                throw new AuthenticationException();
            }

            cliente = RepositorioCliente.EcontreUsuarioPorCpf(cpf);

            if (cliente != null && cliente.Senha.Equals(senha))
            {
                return cliente;
            }
            throw new AuthenticationException();
        }

        public List<ClienteModel> ObterClientes()
        {
            return RepositorioCliente.ObterClientes();
        }
    }

    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message = "Usuário ou senha inválidos") : base (message) 
        {

        }
    }
}
