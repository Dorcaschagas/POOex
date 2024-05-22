using System;

namespace carros
{
    public abstract class Pecas
    {
        public int Rodas { get; set; }
        public int Portas { get; set; }
        protected bool ligado;

        public Pecas(int rodas, int portas)
        {
            Rodas = rodas;
            Portas = portas;
            ligado = false;
        }

        public abstract bool Ligado();
        public abstract bool Desligado();
    }
}
