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

        #region Variables
        public char[] Letras { get; set; }
        public int Contador { get; set; }
        private bool Encontrado { get; set; }
        #endregion

        #region Basico
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
        public void DefinirArreglo()
        {
            Console.WriteLine("Arreglo Instanciado");
            Letras = new char[20];
            Contador = 0;
        }
        public void BorrarArreglo()
        {
            Console.WriteLine("Arreglo Eliminado");
            Letras = new char[0];
            Contador = -1;
        }
        public void LeerArreglo()
        {
            if (Contador > -1)
            {
                for (int i = 0; i < Contador; i++)
                    Console.WriteLine(Letras[i]);
            }
            else
                Console.WriteLine("Arreglo vasio");            
        }
        #endregion

        #region Avanzado
        public void GuardadoElemento(char letra)
        {
            int i;
            if (Contador < Letras.Length)
            {
                for (i = 0; i < Contador; i++)
                    if (elemento.CharToASCII(letra) < elemento.CharToASCII(Letras[i]))
                        break;

                for (int j = Contador; j > i; j--)
                    Letras[j] = Letras[j - 1];

                Contador++;
                Letras[i] = letra;
            }
            else
                Console.WriteLine("Arreglo lleno");
        }
        public void Busqueda(char letra)
        {
            int i;
            for(i = 0; i < Contador; i++)
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(Letras[i]))
                {
                    Console.WriteLine("Elemento en indice " + i);
                    break;
                }
            }
            if (i == Contador)
                Console.WriteLine("Elemento no Encontrado");
        }
        public void Eliminar(char letra)
        {
            int i;
            Encontrado = false;

            for (i = 0; i < Contador; i++)
            {
                if (elemento.CharToASCII(letra) == elemento.CharToASCII(Letras[i]))
                {
                    Console.WriteLine("Elemento Encontrado en indice " + i);
                    Encontrado = true;
                    break;
                }
            }
            if (i == Contador)
                Console.WriteLine("Elemento no Encontrado");

            if (Encontrado)
            {
                if (Contador > 0)
                {
                    for(int l = i; l < Contador - 1; l++)
                        Letras[l] = Letras[l + 1];
                    Contador--;
                }
                else
                {
                    Letras = new char[0];
                    Contador = -1;
                    Console.WriteLine("Arreglo Limpio");
                }
            }
        }
        public void Modificar()
        {
            Eliminar(ObtenerElemento());
            if(Encontrado)
                GuardadoElemento(ObtenerElemento());
        }
        #endregion

        #region Algoritmos "Complejos"
        /*public char[] OrdenamientoAlgoritmico(char[] arreglo, int contador)
        {
            char[] arreglado;
            arreglado = arreglo;
            bool flag = true;
            for (int i = 0; i < contador && flag; i++)
            {
                flag = false;
                for (int j = 0; j < contador - i - 1; j++)
                {
                    if (elemento.CharToASCII(arreglo[j]) > elemento.CharToASCII(arreglo[j + 1]))
                    {
                        flag = true;
                        char guardar = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = guardar;
                    }
                }
            }

            return arreglado;
        }*/
        /*public char[] AlgoritmoAplicado(char[] letras, int contador, char letra)
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
        }*/
        #endregion
    }
}

