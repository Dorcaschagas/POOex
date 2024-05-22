using System;

namespace aulaex
{
    public class Funcionario : Usuario {
        public string Matricula { get; set; }

        public Funcionario(string nome, string cpf, string dataNascimento, bool vacinacao, string matricula) : base(nome, cpf, dataNascimento, vacinacao){
            Matricula = matricula;
        }

        public void Informacoes(){
            Console.WriteLine("\n========================\n");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Data Nascimento: " + DataNascimento);
            Console.WriteLine("Vacinado: " + Vacinacao);
            Console.WriteLine("Matricula: " + Matricula);
        }
    }
}