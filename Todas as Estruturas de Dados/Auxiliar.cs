using System;
using System.Collections.Generic;
using System.Text;

namespace Todas_as_Estruturas_de_Dados
{
    /// <summary>
    /// Exemplo classe funcional
    /// </summary>
    public class Auxiliar : IDado
    {
        public int Numero { get; set; }

        public Auxiliar(int Numero)
        {
            this.Numero = Numero;
        }

        public int CompareTo(Object obj)
        {
            Auxiliar auxiliar = (Auxiliar)(obj);

            if (Numero < auxiliar.Numero)
                return -1;
            else if (Numero > auxiliar.Numero)
                return 1;
            else
                return 0;
        }

        public override bool Equals(object obj)
        {
            Auxiliar auxiliar = (Auxiliar)(obj);

            return (this.Numero == auxiliar.Numero);
        }

        public override int GetHashCode()
        {
            int auxiliarFuncao = this.Numero;

            //Fazer função

            return auxiliarFuncao;
        }

        public override string ToString()
        {
            return Convert.ToString(this.Numero);
        }
    }
}
