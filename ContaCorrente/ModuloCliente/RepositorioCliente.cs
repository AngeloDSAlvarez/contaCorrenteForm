using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ModuloCliente
{
    public class RepositorioCliente
    {
        private static List<ClienteModel> Clientes {  get; set; }

        public RepositorioCliente()
        {
            if (Clientes == null)
            {
                Clientes = new List<ClienteModel>();
                Semear();
            }
        }

        private void Semear()
        {
            Clientes.Add(
                new ClienteModel
                {
                    Nome = "Angelo",
                    Cpf = "123",
                    Senha = "angelo",
                    NumConta = "123",
                    Agencia = "1",
                    Saldo = 200,
                    Limite = 1000
                }
                );
            Clientes.Add(
               new ClienteModel
               {
                   Nome = "Raissa",
                   Cpf = "12345",
                   Senha = "raissa",
                   NumConta = "12345",
                   Agencia = "1",
                   Saldo = 1000,
                   Limite = 200
               }
               );
        }

        public ClienteModel EcontreUsuarioPorCpf(string cpf)
        {
            //percorre a lista de clientes
            foreach(ClienteModel cliente in Clientes)
            {
                //se achar o cpf do cliente retorna o objeto
                if (cliente.Cpf == cpf)
                {
                    return cliente;
                }
            }

            return null;
        }

        public ClienteModel EcontreUsuarioPorAgenciaConta(string agencia, string conta)
        {
            //percorre a lista de clientes
            foreach (ClienteModel cliente in Clientes)
            {
                //se achar o cpf do cliente retorna o objeto
                if (cliente.Agencia == agencia && cliente.NumConta == conta)
                {
                    return cliente;
                }
            }

            return null;
        }

        public List<ClienteModel> ObterClientes()
        {
            return Clientes;
        }
    }
}
