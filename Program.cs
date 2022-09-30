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
            CharASCII converter = new CharASCII();
            Clases.FuncionesBasicas funciones = new Clases.FuncionesBasicas();

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
                                letras = ar.AlgoritmoAplicado(letras, contador, ar.GuardarElemento());
                                #region NO ABRIR
                                //POR QUE CARAJOS FALLA MUY DE VEZ EN CUANDO MI ORDENAMIENTO INICIAL????
                                letras = ar.OrdenamientoAlgoritmico(letras, contador);
                                #endregion
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
                                letras = ar.Eliminar(letras, ar.ObtenerElemento(), contador);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Arreglo no disponible para dicha accion");
                        }
                        funciones.Continue();

                        #endregion
                        
                        break;

                    case 'm':

                        #region En trabajo

                        ar.Modificar(letras, contador, ar.ObtenerElemento());

                        #endregion
                        
                        break;
                    case 'a':

                        Console.WriteLine(converter.CharToASCII(Convert.ToChar(Console.ReadLine())));
                        funciones.Continue();

                        break;
                
                }
            } while (trabajo);

        }

    }
}
