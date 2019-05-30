using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class Lista
    {
        public Elemento Primeiro { get; set; }
        public Elemento Ultimo { get; set; }

        public Lista()
        {
            this.Primeiro = new Elemento(null);
            this.Ultimo = this.Primeiro;
        }

        public void Inserir(IDado dado)
        {
            // insira elementos ao final da lista
            Elemento novo_eleitor = new Elemento(dado);

            Ultimo.Proximo = novo_eleitor;
            Ultimo = Ultimo.Proximo;
        }

        public IDado Buscar(IDado dado)
        {
            if (this.Vazia())
                return null;

            Elemento atual = this.Primeiro.Proximo;

            while (atual != null && !atual.MeuDado.Equals(dado))
                atual = atual.Proximo;

            if (atual != null)
                return atual.MeuDado;
            else
                return null;
        }


        public override string ToString()
        {
            if (this.Vazia()) return "Lista está vazia\n";

            StringBuilder auxImpressao = new StringBuilder();
            Elemento atual = this.Primeiro.Proximo;

            while (atual != null)
            {
                auxImpressao.AppendLine(atual.MeuDado.ToString());
                atual = atual.Proximo;
            }

            return auxImpressao.ToString();
        }

        public IDado Localizar(int posBusca)
        {
            int posAux = 0;
            Elemento aux = this.Primeiro;

            while ((aux != null) && (posAux < posBusca))
            {
                aux = aux.Proximo;
                posAux++;
            }

            if (aux == null)
                return null;
            else
                return aux.MeuDado;
        }

        public IDado Retirar(IDado valor)
        {
            if (this.Vazia()) return null;

            Elemento aux = this.Primeiro;

            while ((aux.Proximo != null) && (!aux.Proximo.MeuDado.Equals(valor)))
                aux = aux.Proximo;

            if (aux.Proximo == null)
                return null;
            else
            {
                Elemento auxRet = aux.Proximo;
                aux.Proximo = auxRet.Proximo;
                if (auxRet == this.Ultimo)
                    this.Ultimo = aux;
                else
                    auxRet.Proximo = null;

                return auxRet.MeuDado;
            }
        }
        
        public void Concatenar(Lista outraLista)
        {

            if (outraLista.Vazia()) return;

            this.Ultimo.Proximo = outraLista.Primeiro.Proximo;
            this.Ultimo = outraLista.Ultimo;
            outraLista = new Lista();
        }

        public bool Vazia()
        {
            return Primeiro == Ultimo;
        }
    }
}
