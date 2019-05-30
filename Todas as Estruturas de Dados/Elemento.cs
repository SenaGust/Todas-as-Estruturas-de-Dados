using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    public class Elemento
    {
        public IDado MeuDado { get; set; }
        public Elemento Proximo { get; set; }
        public Elemento Anterior { get; set; }

        public Elemento(IDado dado)
        {
            this.MeuDado = dado;
            Proximo = Anterior = null;
        }
    }
}
