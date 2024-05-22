using System;

namespace aulaex
{
    public class Usuario : Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }

        public Usuario(string nome, string cpf, string dataNascimento, bool vacinacao)
            : base(vacinacao)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public override bool Vacinado()
        {
            return Vacinacao;
        }
    }
}
