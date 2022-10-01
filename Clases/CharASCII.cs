using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters
{
    internal class CharASCII
    {
        public double CharToASCII(char letra)
        {
            double valor;
            valor = Convert.ToByte(letra);

            if (valor > 90)
                valor = (valor - 32) + 0.5;
            return valor;
        }
        
    }
}
