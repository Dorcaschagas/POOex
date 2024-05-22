using System;

namespace carros
{
    public class ModelosCarros : Pecas
    {
        public int Ano { get; set; }
        public string Cor { get; set; }

        public ModelosCarros(int ano, string cor, int rodas, int portas) : base(rodas, portas)
        {
            Ano = ano;
            Cor = cor;
        }

        public override bool Ligado()
        {
            ligado = true;
            return ligado;
        }

        public override bool Desligado()
        {
            ligado = false;
            return ligado;
        }

        
        public void Detalhes(){
            Console.WriteLine("Ano:{0} Cor:{1} Roda:{2} Portas:{3} Ligado:{4}", Ano, Cor, Rodas, Portas, Ligado());
        }
    }
}
