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
                        #region Modificar
                        if (contador > -1)
                        {
                            #region Elementos
                            bool enc = true;
                            int i;
                            Console.WriteLine("Elemento a Buscar: ");
                            char bus = Convert.ToChar(Console.ReadLine());

                            char[] caracter = new char[1];
                            caracter[0] = bus;
                            double numero1 = 0, numero2 = 0;
                            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(caracter);

                            for (int e = 0; e < caracter.Length; e++)
                            {
                                numero1 = Convert.ToDouble(ASCIIvalues[e]);
                            }

                            for (i = 0; i < contador; i++)
                            {
                                char[] caracter1 = new char[1];
                                caracter1[0] = letras[i];
                                byte[] ASCIIvalues1 = Encoding.ASCII.GetBytes(caracter1);
                                for (int f = 0; f < caracter.Length; f++)
                                {
                                    numero2 = Convert.ToDouble(ASCIIvalues1[f]);
                                }

                                if (numero1 == numero2)
                                {
                                    Console.WriteLine("Elemento encontrado en Posicion: " + i);
                                    enc = true;
                                    break;
                                }
                                else if (i == contador)
                                {
                                    Console.WriteLine("No encontrado");
                                    enc = false;
                                }
                            }
                            #endregion
                            if (enc == true)
                            {
                                double nigg = 0, nigge = 0;
                                Console.WriteLine("Acceder Valor");
                                char valor = Convert.ToChar(Console.ReadLine());

                                letras[i] = valor;

                                char guarda; int j, l = 1;
                                double numero4 = 0;
                                char[] valor1 = new char[1];
                                char[] comparador = new char[1];

                                if (i == contador)
                                {
                                    break;
                                }
                                else
                                {
                                    //Saca Valores ASCII elementos ya existentes
                                    byte[] ASCIIvalues1 = Encoding.ASCII.GetBytes(letras);

                                    char g1;
                                    #endregion
                                    for (l = 1; l <= contador; l ++)
                                    {
                                        Console.WriteLine(l);
                                        Console.ReadKey();
                                        g1 = letras[l-1];
                                        //Saca Valor Ascii del elemento guardado

                                        #region ASCIIexistentes
                                        double numero3 = Convert.ToInt16(ASCIIvalues1[l - 1]);
                                        if (numero2 > 90)
                                        {
                                            numero2 = (numero2 - 32) + 0.5;
                                        }
                                        #endregion
                                        #region ASCII
                                        valor1[0] = g1;
                                        byte[] ASCIIvaluese = Encoding.ASCII.GetBytes(valor1);
                                        for (int e = 0; e < valor1.Length; e++)
                                        {
                                            numero4 = Convert.ToInt32(ASCIIvaluese[e]);
                                        }
                                        if (numero4 >= 90)
                                        {
                                            numero4 = (numero4 - 32) + 0.5;
                                        }
                                        #endregion

                                        //Console.WriteLine(numero);
                                        //Console.WriteLine(numero2);
                                        for (j = l; j > 0 && numero2 > numero4; j--)
                                        {
                                            letras[j] = letras[j - 1];
                                        }
                                        letras[j] = g1;
                                    }
                                }
                                //{
                                //    compara[0] = valor;
                                //    for(int k = 1; k < contador; k++)
                                //    {
                                //        #region valor1
                                //        byte[] ASCIIvaluesComp = Encoding.ASCII.GetBytes(compara);
                                //        for(int v = 1; v < ASCIIvaluesComp.Length; v++)
                                //        {
                                //            comp = Convert.ToDouble(ASCIIvaluesComp[v]);
                                //            if (comp >= 90)
                                //            {
                                //                comp = (comp - 32) + 0.5;
                                //            }
                                //        }
                                //        #endregion

                                //        #region valor2
                                //        byte[] ASCIIvaliuesCom = Encoding.ASCII.GetBytes(comparador);
                                //        #endregion
                                //        for()
                                //        letras[j] = guarda;
                                //    }
                                //}                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Arreglo no disponible para dicha accion");
                        }
                        Console.ReadKey();
                        Console.Clear();
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
