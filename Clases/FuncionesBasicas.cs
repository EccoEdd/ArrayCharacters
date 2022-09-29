using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters.Clases
{
    internal class FuncionesBasicas
    {
        public char Seleccion { get; set; }
        public void Menu()
        {
            Console.WriteLine("Acciones Disponibles: ");
            Console.WriteLine("Crear => c");
            Console.WriteLine("Borrar => b");
            Console.WriteLine("Insertar Elemento => i");
            Console.WriteLine("Revisar Elementos => r");
            Console.WriteLine("Buscar Elemento=> s");
            Console.WriteLine("Eliminar Elemento=> e");
            Console.WriteLine("Modificar Elemento=> m");
            Console.WriteLine("Creditos => a");
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

        public void Continue()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
