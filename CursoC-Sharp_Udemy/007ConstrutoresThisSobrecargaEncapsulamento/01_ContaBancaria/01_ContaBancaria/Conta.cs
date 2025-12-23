using System;
using System.Globalization;

namespace _01_ContaBancaria
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 0;
        }
        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
