using System;

namespace aula06
{
    public class Gato : Animal{
        public int? Idade {get; set;}
        public Gato(string raca, string nome, int idade) : base (raca, nome){
            this.Idade = idade;
        }
        public override void EmitirSom(){
            Console.WriteLine("Miau");
        }
    }
}