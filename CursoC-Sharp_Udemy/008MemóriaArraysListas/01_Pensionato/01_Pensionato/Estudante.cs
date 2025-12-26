using System;

namespace _01_Pensionato
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //cria o estudante
        public Estudante (string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //sobrescreve o ToString pra escrever o que queremos
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
