using System;
using SistemaBancario.SistemaBanco;


namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();

            conta.NomeConta = "Conta Teste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 100.55;

            conta.Titular = new Titular()
            {
                Cpf = "234456567",
                Rg = "233452323",
                Endereco = "Rua Test",
                Nome = "Joao Santos"
            };

            Console.WriteLine($"O saldoa atual é: {conta.VerSaldo()}");
            conta.Depositar(150);

            Console.WriteLine($"O saldoa atual após deposito é: " + conta.VerSaldo());

            conta.Sacar(50);
            Console.WriteLine("O saldoa atual após saque é: {0}", conta.VerSaldo());

            conta.Sacar(2000);
        }



    }
}
