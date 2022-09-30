using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters
{
    internal class Arreglo
    {
        CharASCII elemento = new CharASCII();
        Clases.FuncionesBasicas funciones = new Clases.FuncionesBasicas();

        public int Contador { get; set; }

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
        public void Busqueda(char[] letras, char letra, int contador)
        {
            for(int i = 1; i < contador; )
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(letras[i - 1]))
                {
                    Console.WriteLine("Elemento Encontrado en indice " + (i - 1));
                    break;
                }
                if ((i+2) == contador)
                {
                    Console.WriteLine("Elemento no Encontrado");
                }
                
                i++;
            }
        }
        public char[] Eliminar(char[] letras, char letra, int contador)
        {
            bool encontrado = false;
            int pos = 0;

            for (int i = 1; i < contador;)
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(letras[i - 1]))
                {
                    Console.WriteLine("Elemento Encontrado en indice " + (i - 1));
                    pos = i - 1;
                    encontrado = true;
                    break;
                }
                if ((i + 2) == contador)
                {
                    Console.WriteLine("Elemento no Encontrado");
                }

                i++;
            }
            if (encontrado)
            {
                if (contador > 0)
                {
                    for (int i = pos; i < contador; i++)
                    {
                        letras[i] = letras[i + 1];
                    }
                }
                else
                {
                    letras = new char[0];
                    Contador = 0;
                    Console.WriteLine("Arreglo Limpio");
                }
            }

            return letras;
        }

        public char[] OrdenamientoAlgoritmico(char[] arreglo, int contador)
        {
            char[] arreglado;
            arreglado = arreglo;

            for(int i = 0; i < contador; i++)
            {
                for(int j = 0; j < contador-1; j++)
                {
                    if (elemento.CharToASCII(arreglo[j]) > elemento.CharToASCII(arreglo[j + 1]))
                    {
                        char guardar = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = guardar;
                    }
                }
            }

            return arreglado;
        }

        public void LeerArreglo(char[] arreglo, int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }


    }
}
