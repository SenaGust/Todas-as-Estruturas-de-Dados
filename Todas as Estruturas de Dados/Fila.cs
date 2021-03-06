﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class Fila
    {
        public Elemento Primeiro { get; set; }
        public Elemento Ultimo { get; set; }

        public Fila()
        {
            Primeiro = new Elemento(null);
            Ultimo = Primeiro;
        }

        public void Inserir(IDado dado)
        {
            Elemento novo = new Elemento(dado);

            Ultimo.Proximo = novo;
            Ultimo = novo;
        }

        public IDado Retirar()
        {
            if (Vazio())
                return null;

            Elemento aux = Primeiro.Proximo;
            Primeiro.Proximo = aux.Proximo;

            if (aux == Ultimo)
                Ultimo = Primeiro;
            else
                aux.Proximo = null;

            aux.Proximo = null;

            return aux.MeuDado;
        }

        public override string ToString()
        {
            if (Vazio())
                return null;

            StringBuilder auxString = new StringBuilder();
            Elemento aux = Primeiro.Proximo;

            while (aux != null)
            {
                auxString.AppendLine(aux.MeuDado.ToString());
                aux = aux.Proximo;
            }

            return auxString.ToString();
        }

        public bool Vazio()
        {
            return (Primeiro == Ultimo);
        }
    }
}
