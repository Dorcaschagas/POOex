using System;

namespace aula06
{
    public class Canario : Animal{
        public bool? Cantando {get; set;}
        public Canario (string raca, string nome, bool cantando) : base (raca, nome){
            this.Cantando = cantando;
        }
        public override void EmitirSom(){
            Console.WriteLine("PiuPiu");
        }
    }
}