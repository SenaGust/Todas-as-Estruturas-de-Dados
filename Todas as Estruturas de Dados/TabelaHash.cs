using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class TabelaHash
    {
        public Lista[] Vetores { get; set; }
        public int Tamanho { get; set; }

        public TabelaHash(int tam)
        {
            //atribuindo tamanho
            this.Tamanho = tam;
            this.Vetores = new Lista[this.Tamanho];

            //inicializando as Listas 
            for (int pos = 0; pos < this.Tamanho; pos++)
                this.Vetores[pos] = new Lista();
        }

        public void Inserir(IDado dado)
        {
            //Descubro onde inserir
            int ondeInserir = dado.GetHashCode() % Tamanho;

            //Inserir
            Vetores[ondeInserir].Inserir(dado);
        }

        public IDado Buscar(IDado dado)
        {
            //Descubro onde buscar
            int ondeBuscar = dado.GetHashCode() % Tamanho;

            //Faço a busca usando a lista
            return Vetores[ondeBuscar].Buscar(dado); //se retornar null é porque não existe
        }

        public IDado Retirar(IDado dado)
        {
            //Descubro onde buscar
            int ondeBuscar = dado.GetHashCode() % Tamanho;

            //Faço a busca usando a lista
            return Vetores[ondeBuscar].Retirar(dado); //se retornar null é porque não existe
        }

        public override string ToString()
        {
            StringBuilder auxImpressao = new StringBuilder();

            //Imprimindo cada uma das listas
            for (int pos = 0; pos < Tamanho; pos++)
            {
                auxImpressao.AppendLine("Vetor " + pos + ":");
                auxImpressao.AppendLine(this.Vetores[pos].ToString());
            }

            return auxImpressao.ToString();
        }
    }
}
