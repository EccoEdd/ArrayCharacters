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
        #endregion

        public void ShowMenu()
        {
            Console.WriteLine("Acciones Disponibles: ");
            Console.WriteLine("         Instanciar Arreglo => c");
            Console.WriteLine("         Limpiar Arreglo => b");
            Console.WriteLine("         Insertar Elemento => i");
            Console.WriteLine("         Mostrar Elementos => r");
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
                Seleccion = 'r';
            }
            Console.Clear();
            return Seleccion;
        }
        public void Continue()
        {
            Console.ReadKey();
            Console.Clear();
        }

    }
}
