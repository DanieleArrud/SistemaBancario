using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario.SistemaBanco
{
    class Conta
    {
        public int Agencia { get; set; }

        public int NumeroConta { get; set; }

        public string NomeConta { get; set; }

        public Titular Titular { get; set; }

        public Double Saldo { get; set; }

        public Double VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < Saldo) Saldo -= valor;
            else Console.WriteLine("Saldo insuficiente");
        }
    }
}
