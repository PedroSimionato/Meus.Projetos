using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            double saldo = 0;

            Console.Write("Entre o número da conta: ");
            int dadosConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            
            Console.Write("Haverá depósito inicial(s / n) ? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            Console.WriteLine();

            c = new Conta(nome, dadosConta, saldo); // Leitura dos dados iniciais e atribuição ao construtor.
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);
            Console.WriteLine(c);
            Console.WriteLine();
        }
    }
}
