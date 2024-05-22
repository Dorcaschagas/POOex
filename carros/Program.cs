using System;
using System.Collections.Generic; // Importando o namespace necessário

namespace carros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ModelosCarros> carros = new List<ModelosCarros>();

            carros.Add(new ModelosCarros(2008, "Preto", 5, 2)); // Usando o método Add para adicionar um carro à lista

            foreach(var carro in carros){
                carro.Detalhes();
            }
        }
    }
}
