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

        public char ObtenerElemento()
        {
            char letra;
            try
            {
                Console.WriteLine("Insertar Elemento");
                letra = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Default : a");
                letra = 'a';
            }
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
                Console.WriteLine("Default : a");
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
            for(int i = 0; i < contador; )
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(letras[i]))
                {
                    Console.WriteLine("Elemento Encontrado en indice " + i);
                    break;
                }
                if ((i+1) == contador)
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

            for (int i = 0; i < contador;)
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(letras[i]))
                {
                    Console.WriteLine("Elemento Encontrado en indice " + i);
                    encontrado = true;
                    pos = i;
                    break;
                }
                if ((i + 1) == contador)
                {
                    Console.WriteLine("Elemento no Encontrado");
                }
                i++;
            }
            if (encontrado)
            {
                if (contador > 0)
                {
                    for(int i = pos; i < contador; i++)
                    {
                        letras[pos] = letras[i];
                    }
                    CountSave = contador - 1;
                }
                else
                {
                    letras = new char[0];
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

        public char[] Modificar(char[] letras, int contador, char letra)
        {
            bool encontrado = false;
            int pos = 0, i;
            char[] arg;
            for (i = 0; i < contador;)
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(letras[i]))
                {
                    Console.WriteLine("Elemento Encontrado en indice " + i);
                    encontrado = true;
                    pos = i;
                    break;
                }
                if ((i + 1) == contador)
                {
                    Console.WriteLine("Elemento no Encontrado");
                }
                i++;
            }
            if (encontrado)
            {
                letras[pos] = ObtenerElemento();
                Console.WriteLine("Elemento Modificado exitosamente");
            }
            arg = OrdenamientoAlgoritmico(letras, contador);
            InsertaBusqueda(arg, letra, contador);
            return arg;
        }

        public void InsertaBusqueda(char[] letras, char letra, int contador)
        {
            for (int i = 0; i < contador;)
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(letras[i]))
                {
                    Console.WriteLine("Elemento en indice " + i);
                    break;
                }
                i++;
            }
        }


        public int CountSave { get; set; }

    }
}
