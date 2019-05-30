using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public interface IEstruturaDados
    {
        void Inserir(IDado dado);
        IDado Retirar();
        IDado Buscar(IDado dado);
        string ToString();
    }
}
