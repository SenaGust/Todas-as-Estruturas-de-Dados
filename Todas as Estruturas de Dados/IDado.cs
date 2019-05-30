using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public interface IDado
    {
        string ToString();
        bool Equals(object obj);
        int CompareTo(object obj);

        //void Inserir(IDado val); //Usado para inserir em uma estrutura de dados que se encontra em uma árvore
    }
}

