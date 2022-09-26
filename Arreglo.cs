using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters
{
    internal class Arreglo
    {
        char[] letras;

        public void CreacionArreglo()
        {
            Console.WriteLine("Asignar Tamaño de Arreglo: ");
            int max = Convert.ToChar(Console.ReadLine());
            letras = new char[max];
        }
        public void LimpiarArreglo(char[] arg)
        {

        }
    }
}
