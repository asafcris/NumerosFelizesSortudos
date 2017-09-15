using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortudoFeliz
{
   public class NumeroSortudo
    {
        public static bool Sortudo(int numero)
        {
            bool resultado = false;
            for (int i = 2; i < numero; i++)
            {
                int resto = numero % i;
                if (resto == 0)
                {

                    i = numero + 1;
                }
                else
                {
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}
