using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Clases

            Arreglo ar = new Arreglo();
            Clases.FuncionesBasicas funciones = new Clases.FuncionesBasicas();
            Clases.LosMinions LosMinions = new Clases.LosMinions();

            #endregion

            #region Variables Globales
            char[] letras = new char[0];
            int contador = -1;
            bool trabajo = true;
            #endregion
            
            do
            {
                funciones.ShowMenu();
                switch (funciones.Elemento())
                {
                    case 'c':

                        #region Crear

                        if(contador == -1){ 
                            letras = new char[funciones.Capasidad()];
                            contador = 0;
                        }
                        else
                            Console.WriteLine("Arreglo ya creado");
                        funciones.Continue();

                        #endregion

                        break;

                    case 'b':

                        #region Borrar

                        letras = new char[funciones.Reset()];
                        contador = -1;
                        funciones.Continue();

                        #endregion

                        break;

                    case 'r':

                        #region Revisar

                        if (contador == 0 || contador == -1)
                            Console.WriteLine("Arreglo Vacio");

                        ar.LeerArreglo(letras, contador);
                        funciones.Continue();

                        #endregion
                        
                        break;

                    case 'i':

                        #region Insertar

                        if (contador < letras.Length && contador > -1)
                        {
                            if (contador == 0)
                            {
                                letras[0] = ar.GuardarElemento();
                                contador++;
                            }
                            else
                            {
                                char n = ar.GuardarElemento();
                                letras = ar.GuardadoElemento(letras, contador, n);
                                contador++;
                            }
                        }
                        else
                            Console.Write("Arreglo No disponible para cierta accion");
                        funciones.Continue();
                        
                        #endregion
                        
                        break;
                    
                    case 's':

                        #region Busqueda
                        Console.WriteLine(contador);
                        if (contador > -1)
                        {
                            ar.Busqueda(letras, ar.ObtenerElemento(), contador);
                        }
                        else
                        {
                            Console.WriteLine("Arreglo no disponible para dicha accion");
                        }
                        funciones.Continue();

                        #endregion
                        
                        break;
                    
                    case 'e':

                        #region Eliminar

                        if (contador > -1)
                        {
                            if (contador == 0)
                            {
                                letras = new char[funciones.Reset()];
                                contador = -1;
                            }
                            else
                            {
                                if(contador >= 1)
                                    letras = ar.Eliminar(letras, ar.ObtenerElemento(), contador);
                                contador = ar.CountSave;
                            }
                            ar.OrdenamientoAlgoritmico(letras, contador);
                        }
                        else
                        {
                            Console.WriteLine("Arreglo no disponible para dicha accion");
                        }
                        funciones.Continue();

                        #endregion
                        
                        break;

                    case 'm':

                        #region Modificar
                        if (contador > -1)
                            ar.Modificar(letras, contador, ar.ObtenerElemento());
                        else
                            Console.WriteLine("Arreglo no disponible para dicha accion");
                        funciones.Continue();

                        #endregion

                        break;
                    case 'a':

                        LosMinions.Presentan();
                        funciones.Continue();

                        break;
                
                }
            } while (trabajo);

        }

    }
}
