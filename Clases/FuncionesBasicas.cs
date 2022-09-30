using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters.Clases
{
    internal class FuncionesBasicas
    {

        #region Valores
        public char Seleccion { get; set; }
        public int Len { get; set; }
        #endregion

        public void ShowMenu()
        {
            Console.WriteLine("Acciones Disponibles: ");
            Console.WriteLine("         Crear => c");
            Console.WriteLine("         Borrar => b");
            Console.WriteLine("         Insertar Elemento => i");
            Console.WriteLine("         Revisar Elementos => r");
            Console.WriteLine("         Buscar Elemento => s");
            Console.WriteLine("         Eliminar Elemento => e");
            Console.WriteLine("         Modificar Elemento => m");
            Console.WriteLine("         Creditos => a");
        }

        public char Elemento()
        {
            try 
            { 
                Seleccion = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Seleccion = 'c';
            }
            Console.Clear();
            return Seleccion;
        }

        public int Capasidad()
        {
            try
            {
                Console.WriteLine("Asignar Tamaño de Arreglo: ");
                Len = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Len = 20;
            }
            return Len;
        }

        public int Reset()
        {
            Console.WriteLine("Arreglo Limpio");
            Len = 0;
            return Len;
        }

        public void Continue()
        {
            Console.ReadKey();
            Console.Clear();
        }

    }
}
