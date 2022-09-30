using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters
{
    internal class Arreglo
    {
        public char ObtenerElemento()
        {
            char letra;
            Console.WriteLine("Insertar Elemento");
            letra = Convert.ToChar(Console.ReadLine());
            return letra;
        }
        public char GuardarElemento()
        {
            char letra;
            Console.WriteLine("Insertar Elemento");
            try
            {
                letra = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                letra = 'a';
            }
            return letra;
        }
        public char[] AlgoritmoAplicado(char[] letras, int contador, char letra)
        {
            CharASCII elemento = new CharASCII();

            #region Valores
            char[] arr = letras;
            int j, i;
            double numero1, numero2;
            char g1;
            letras[contador] = letra;
            #endregion

            for (i = 1; i <= contador; i++)
            {
                g1 = letras[i];
                numero2 = elemento.CharToASCII(letras[i - 1]);
                numero1 = elemento.CharToASCII(g1);
                for (j = i; j > 0 && numero2 > numero1; j--)
                {
                    letras[j] = letras[j - 1];
                }
                letras[j] = g1;
            }

            return arr;
        }

    }
}
