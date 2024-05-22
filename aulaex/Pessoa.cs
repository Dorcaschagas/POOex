using System;

namespace aulaex {
    public abstract class Pessoa {
        public bool Vacinacao { get; set; }

        protected Pessoa(bool vacinacao) {
            Vacinacao = vacinacao;
        }

        public abstract bool Vacinado();
    }
}
