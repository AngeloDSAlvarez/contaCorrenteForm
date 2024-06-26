using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ModuloCliente
{
    public class ClienteModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string NumConta { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

        //verifica se é possivel realizar saque ou transferencia
        private bool verificarSaldo(decimal valor)
        {
            //retorna TRUE/FALSE caso o valor que queira sacar for menor 
            return valor <= Saldo + Limite ? true : false;
        }

        public string Validar()
        {
            string erro = string.Empty;

            if (string.IsNullOrEmpty(Cpf))
            {
                erro += "O campo 'CPF' é obrigatório! \n";
            }

            return erro;
        }

        public void Sacar(decimal valor)
        {
            bool tirarSaldo = Saldo >= valor;
            bool tirarSaldoELimite = Saldo + Limite >= valor;
            if (tirarSaldo)
            {
                Saldo -= valor;
            } else if (tirarSaldoELimite)
            {
                decimal dif = Saldo - valor;
                dif = dif * -1;
                Limite -= dif;
                valor = valor - dif;
                Saldo -= valor;
            }
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Transferir (decimal valor, ClienteModel cliente)
        {
            if (verificarSaldo(valor))
            {
                Saldo -= valor;
                cliente.Depositar(valor);
            }
        }

    }
}
