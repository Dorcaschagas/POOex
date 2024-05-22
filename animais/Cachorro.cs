using System;

namespace aula06
{
    public class Cachorro : Animal{
        public bool? Vacinacao {get; set;}
        public Cachorro(string raca, string nome, bool vacinacao) : base (raca, nome){
            this.Vacinacao = vacinacao;
        }
        public override void EmitirSom() {
            Console.WriteLine("Auau");
        }
    }
}