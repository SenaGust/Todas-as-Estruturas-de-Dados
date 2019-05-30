using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class ListaDupla
    {
        public Elemento Anterior { get; set; }
        public Elemento Ultimo { get; set; }

        public void Inserir(IDado d)
        {  
            //insere no fim 
            Elemento novo = new Elemento(d);
            this.Ultimo.Proximo = novo;
            novo.Anterior = this.Ultimo;
            this.Ultimo = novo;
        }
        public IDado Buscar(IDado dado)
        {
            if (this.Vazia())
                return null;

            Elemento atual = this.Anterior.Proximo;

            while (atual != null && !atual.MeuDado.Equals(dado))
                atual = atual.Proximo;

            if (atual != null)
                return atual.MeuDado;
            else
                return null;
        }

        public IDado Retirar(IDado valor)
        {
            Elemento aux = new Elemento (this.Buscar(valor));

            if (aux == null)
                return null;
            else
            {
                aux.Anterior.Proximo = aux.Proximo;

                if (aux != this.Ultimo)
                    aux.Proximo.Anterior = aux.Anterior;
                else
                    this.Ultimo = aux.Anterior;

                aux.Anterior = aux.Proximo = null;

                return aux.MeuDado;
            }
        }
        public bool Vazia()
        {
            return Anterior == Ultimo;
        }
    }
}
