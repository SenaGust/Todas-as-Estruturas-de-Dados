using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class ListaCircular
    {
        Elemento Anterior, Atual;

        public ListaCircular()
        {
            this.Atual = new Elemento(null);
            this.Anterior = this.Atual;
            this.Atual.Proximo = this.Atual;
        }

        public void Inserir(IDado d)
        {
            Elemento novo = new Elemento(d);
            this.Anterior.Proximo = novo;
            novo.Proximo = this.Atual;

            if (this.Vazia())
                this.Atual = novo;
            else
                this.Anterior = novo;
        }

        public IDado Retirar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.Atual;
            this.Anterior.Proximo = aux.Proximo;
            this.Atual = aux.Proximo;
            aux.Proximo = null;

            if (this.Vazia())
                this.Atual.Proximo = this.Atual;
            return 
                aux.MeuDado;
        }


        public bool Vazia()
        {
            return Atual == Anterior;
        }
    }
}
