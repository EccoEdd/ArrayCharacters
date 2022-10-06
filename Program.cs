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
            Clases.LosMinions LosMinions = new Clases.LosMinions();
            Clases.FuncionesBasicas funciones = new Clases.FuncionesBasicas();
            #endregion

            #region Variables Globales
            ar.Contador = -1;
            bool creado = true, creado2 = false;
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
                            creado2 = true;
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
                        creado2 = false;
                        ar.BorrarArreglo();
                        funciones.Continue();
                        #endregion
                        break;
                    case 'r':
                        #region Revisar
                        if (creado2)
                            ar.LeerArreglo();
                        else
                            Console.WriteLine("Arreglo no Instanciado");
                        funciones.Continue();
                        #endregion                        
                        break;
                    case 'i':
                        #region Insertar
                        if(creado2)
                            ar.GuardadoElemento(ar.ObtenerElemento());
                        else
                            Console.WriteLine("Arreglo no Instanciado");
                        funciones.Continue();                        
                        #endregion                        
                        break;               
                    case 's':
                        #region Busqueda
                        if(creado2)
                            ar.Busqueda(ar.ObtenerElemento());
                        else
                            Console.WriteLine("Arreglo no Instanciado");
                        funciones.Continue();
                        #endregion          
                        break;                    
                    case 'e':
                        #region Eliminar
                        if(creado2)
                            ar.Eliminar(ar.ObtenerElemento());
                        else
                            Console.WriteLine("Arreglo no Instanciado");
                        funciones.Continue();
                        #endregion                        
                        break;
                    case 'm':
                        #region Modificar
                        if(creado2)
                            ar.Modificar();
                        else
                            Console.WriteLine("Arreglo no Instanciado");
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
