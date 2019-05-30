using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class ArvoreBinariaABB
    {
        public Nodo Raiz { get; set; }

        public ArvoreBinariaABB()
        {
            this.Raiz = null;
        }

        public void Inserir(IDado dado)
        {
            Nodo aux = new Nodo(dado);
            this.Raiz = InserirRecursivo(aux, Raiz);
        }
        public IDado Buscar(IDado dado)
        {
            //IDado dado = new Numero(chave); // = new (Tipo da classe) (chave);
            Nodo busca = new Nodo(dado);

            return BuscaRecursiva(busca, Raiz).MeuDado;
        }
        public IDado Retirar(IDado dado)
        {
            //IDado dado = new Numero(chave);
            Nodo retirada = new Nodo(dado);

            RetiradaRec(retirada, Raiz, out Nodo aux); //declaração dentro dos parametros do método

            return aux.MeuDado;
        }
        public override string ToString()
        {
            return EmOrdem(Raiz);
        }
        public string EmOrdem(Nodo raiz)
        {
            if (raiz != null)
            {
                StringBuilder auxImpressao = new StringBuilder();

                auxImpressao.Append(EmOrdem(raiz.Esquerda));
                auxImpressao.Append(raiz.MeuDado.ToString());
                auxImpressao.Append(EmOrdem(raiz.Direita));

                return auxImpressao.ToString();
            }
            else
                return null;
        }
        public string PreOrdem(Nodo raiz)
        {
            if (raiz != null)
            {
                StringBuilder auxImpressao = new StringBuilder();
                auxImpressao.Append(raiz.MeuDado.ToString());
                auxImpressao.Append(PreOrdem(raiz.Esquerda));
                auxImpressao.Append(PreOrdem(raiz.Direita));

                return auxImpressao.ToString();
            }
            else
                return null;
        }
        public string PosOrdem(Nodo raiz)
        {
            if (raiz != null)
            {
                StringBuilder auxImpressao = new StringBuilder();

                auxImpressao.Append(PosOrdem(raiz.Direita));
                auxImpressao.Append(PosOrdem(raiz.Esquerda));
                auxImpressao.Append(raiz.MeuDado.ToString());

                return auxImpressao.ToString();
            }
            else
                return null;
        }

        private Nodo RetiradaRec(Nodo quem, Nodo onde, out Nodo saida)
        {
            if (onde == null)
            {
                saida = new Nodo(null);
                return null;
            }

            if (quem.MeuDado.CompareTo(onde.MeuDado) < 0)
                onde.Esquerda = RetiradaRec(quem, onde.Esquerda, out saida);
            else if (quem.MeuDado.CompareTo(onde.MeuDado) > 0)
                onde.Direita = RetiradaRec(quem, onde.Direita, out saida);
            else
            {
                saida = new Nodo(onde.MeuDado);
                int grau = onde.Grau();

                switch (grau)
                {
                    case 0: //não possui filhos
                        return null;
                    case -1: //filho a esquerda
                        return onde.Esquerda;
                    case 1: //filho a direita
                        return onde.Direita;
                    case 2: //tem dois filhos
                        Nodo antecessor = onde.Antecessor();
                        onde.MeuDado = antecessor.MeuDado;
                        onde.Esquerda = RetiradaRec(antecessor, onde.Esquerda, out saida);
                        break;
                }
            }
            return onde;
        }
        private Nodo InserirRecursivo(Nodo novo, Nodo raiz)
        {
            if (raiz == null) //quando encontra uma raiz nula, vc insere novo
                return novo;

            if (novo.MeuDado.CompareTo(raiz.MeuDado) < 0) //procura uma raiz nula na esquerda
                raiz.Esquerda = InserirRecursivo(novo, raiz.Esquerda);
            else if (novo.MeuDado.CompareTo(raiz.MeuDado) == 0) // adiciona uma venda a fila do produto
            {
                //Usado para inserir em uma estrutura de dados que se encontra em uma árvore

                //IDado venda = novo.MeuDado;
                //raiz.MeuDado.Inserir(venda);  
            }
            else
                raiz.Direita = InserirRecursivo(novo, raiz.Direita); //procura uma raiz nula na direita

            return raiz;
        }
        private Nodo BuscaRecursiva(Nodo busca, Nodo raiz)
        {
            if (raiz == null)
                return null;

            if (busca.MeuDado.CompareTo(raiz.MeuDado) == 0)
                return raiz;


            else if (busca.MeuDado.CompareTo(raiz.MeuDado) < 0)
                return BuscaRecursiva(busca, raiz.Esquerda);
            else
                return BuscaRecursiva(busca, raiz.Direita);
        }
    }
}
