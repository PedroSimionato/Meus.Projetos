using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public string Nome { get, private set };
        public int DadosConta { get, private set };
        public double Saldo { get, private set };

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public Conta(string nome, int dadosconta, double saldo) // Construtor para leitura do nome e numero da conta
        {
            Nome = nome;
            DadosConta = dadosconta;
            Saldo = saldo;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5.0;
        }

        public void Deposito(double deposito)
        {
            Saldo = Saldo + deposito;
        }

        public override string ToString()
        {
            Console.WriteLine("Dados da conta atualizados: ");
            return "Conta " + DadosConta + ", Titutlar: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
