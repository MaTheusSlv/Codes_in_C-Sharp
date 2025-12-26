using System;
using System.Globalization;

namespace _01_ContaBancaria
{
    internal class Conta
    {
        public int Numero { get; private set; } //só pode ser criado/alterado pelo construtor
        public string Nome { get; set; }
        public double Saldo { get; private set; } //só pode ser criado/alterado pelo construtor

        //cria a conta sem saldo inicial
        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 0;
        }

        //cria a conta com saldo inicial com base na conta sem saldo inicial
        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        //executa o depósito no saldo
        public void Deposito(double quantia)
        {
            Saldo = Saldo += quantia;
        }

        //executa o saque no saldo, já descontando a taxa
        public void Saque(double quantia)
        {
            Saldo = Saldo -= quantia + 5.00;
        }

        //sobrecreve o ToString pra imprimir da forma que quero
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
