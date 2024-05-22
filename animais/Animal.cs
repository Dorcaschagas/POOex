using System;
namespace aula06
{
    public abstract class Animal{
        public string? Raca {get; set;}
        public string? Nome {get; set;}
        public Animal(string raca, string nome){
            this.Raca = raca;
            this.Nome = nome;
        }
        public abstract void EmitirSom();
    }
}