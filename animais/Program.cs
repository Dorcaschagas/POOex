using System;

namespace aula06{
    public class Program{
        public static void  Main(string[] args ){
            Cachorro cachorro = new Cachorro("pet", "Toto", true);
            cachorro.EmitirSom();

            Canario canario = new Canario("Passarinho", "PiuPiu", true);
            canario.EmitirSom();

            Gato gato = new Gato("cat","gatinho", 10);
            gato.EmitirSom();
        }
    }
}