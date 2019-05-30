using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todas_as_Estruturas_de_Dados
{
    public class Pilha
    {
        public Elemento Topo { get; set; }
        public Elemento Fundo { get; set; }

        public Pilha()
        {
            this.Topo = new Elemento(null);
            this.Fundo = this.Topo;
        }

        public void Empilhar(IDado dado)
        {
            Elemento novo = new Elemento(dado);

            if (this.Vazia())
            {
                Topo.Proximo = novo;
                Fundo = novo;
            }
            else
            {
                novo.Proximo = Topo.Proximo;
                Topo.Proximo = novo;
            }
        }

        public IDado Desempilhar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.Topo.Proximo;
            this.Topo.Proximo = aux.Proximo;

            if (aux == this.Fundo)
            {
                this.Fundo = this.Topo;
            }
            else
                aux.Proximo = null;

            return aux.MeuDado;
        }

        public bool Vazia()
        {
            return Fundo.Equals(Topo);
        }

        public IDado ConsultarTopo()
        {
            return Topo.Proximo.MeuDado;
        }

        public override string ToString()
        {
            if (this.Vazia()) return null;

            StringBuilder auxImpressao = new StringBuilder();
            Elemento atual = Topo.Proximo;

            while (atual != null)
            {
                auxImpressao.AppendLine(atual.MeuDado.ToString());
                atual = atual.Proximo;
            }

            return auxImpressao.ToString();
        }
    }
}
