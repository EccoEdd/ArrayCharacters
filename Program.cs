using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters
{
    internal class Program
    {
        static void Main()
        {
            #region Clases
            Arreglo ar = new Arreglo();
            Clases.FuncionesBasicas funciones = new Clases.FuncionesBasicas();
            Clases.LosMinions LosMinions = new Clases.LosMinions();
            #endregion

            #region Variables Globales
            ar.Contador = -1;
            bool creado = true;
            #endregion      
            do
            {
                funciones.ShowMenu();
                switch (funciones.Elemento())
                {
                    case 'c':
                        #region Crear
                        if (creado)
                        {
                            ar.DefinirArreglo();
                            creado = false;
                        }
                        else
                            Console.WriteLine("Arreglo ya instanciado");
                        funciones.Continue();
                        #endregion
                        break;
                    case 'b':
                        #region Borrar
                        creado = true;
                        ar.BorrarArreglo();
                        funciones.Continue();
                        #endregion
                        break;
                    case 'r':
                        #region Revisar
                        ar.LeerArreglo();
                        funciones.Continue();
                        #endregion                        
                        break;
                    case 'i':
                        #region Insertar
                        ar.GuardadoElemento(ar.ObtenerElemento());
                        funciones.Continue();                        
                        #endregion                        
                        break;               
                    case 's':
                        #region Busqueda
                        ar.Busqueda(ar.ObtenerElemento());
                        funciones.Continue();
                        #endregion          
                        break;                    
                    case 'e':
                        #region Eliminar
                        ar.Eliminar(ar.ObtenerElemento());
                        funciones.Continue();
                        #endregion                        
                        break;
                    case 'm':
                        #region Modificar
                        ar.Modificar();
                        funciones.Continue();
                        #endregion
                        break;
                    case 'a':
                        #region Minions
                        LosMinions.Presentan();
                        funciones.Continue();
                        #endregion
                        break;
                
                }
            } while (true);

        }

    }
}
