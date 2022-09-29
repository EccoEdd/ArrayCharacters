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
            CharASCII converter = new CharASCII();
            Clases.FuncionesBasicas funciones = new Clases.FuncionesBasicas();

            char[] letras = new char[0];
            int contador = -1, max;
            bool trabajo = true;
            char descicion;
            do
            {
                funciones.Menu();
                switch (funciones.Elemento())
                {
                    case 'c':

                        #region Crear
                        if(contador == -1){ 
                            Console.WriteLine("Asignar Tamaño de Arreglo: ");
                            max = Convert.ToInt16(Console.ReadLine());
                            letras = new char[max];
                            contador = 0;
                        }
                        else
                            Console.WriteLine("Arreglo ya creado");
                        funciones.Continue();
                        #endregion

                        break;
                    case 'b':
                        #region Borrar
                        Console.WriteLine("Arreglo limpio");    
                        letras = new char[0];
                        contador = -1;
                        Console.ReadKey();
                        Console.Clear();
                        #endregion
                        break;
                    case 'r':
                        #region Revisar
                        if (contador == 0 || contador == -1)
                        {
                            Console.WriteLine("Arreglo Vacio");
                        }
                        else { 
                            for(int i = 0; i < contador;)
                            {
                                Console.WriteLine(letras[i]);
                                i++;
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        #endregion
                        break;
                    case 'i':
                        #region Insertar
                        //Verifica si arreglo esta creado y o le queda espacio
                        if (contador < letras.Length && contador != -1)
                        {
                            #region InicializacionValores
                            char[] valor = new char[1];
                            double numero = 0;

                            Console.WriteLine("Insertar Elemento");
                            char val = Convert.ToChar(Console.ReadLine());
                            letras[contador] = val;

                            //Saca Valores ASCII elementos ya existentes
                            byte[] ASCIIvalues1 = Encoding.ASCII.GetBytes(letras);

                            char g1;
                            int j, i = 1;
                            #endregion
                            for (i = 1; i <= contador; i++)
                            {
                                
                                g1 = letras[i];
                                //Saca Valor Ascii del elemento guardado

                                #region ASCIIexistentes
                                double numero2 = Convert.ToInt16(ASCIIvalues1[i - 1]);
                                if (numero2 > 90)
                                {
                                    numero2 = (numero2 - 32) + 0.5;
                                }
                                #endregion
                                #region ASCII
                                valor[0] = g1;
                                byte[] ASCIIvalues = Encoding.ASCII.GetBytes(valor);
                                for (int e = 0; e < valor.Length; e++)
                                {
                                    numero = Convert.ToInt32(ASCIIvalues[e]);
                                }
                                if (numero >= 90)
                                {
                                    numero = (numero - 32) + 0.5;
                                }
                                #endregion

                                //Console.WriteLine(numero);
                                //Console.WriteLine(numero2);
                                for (j = i; j > 0 && numero2 > numero; j--)
                                {
                                    letras[j] = letras[j - 1];
                                }
                                letras[j] = g1;
                            }
                            #region Contador+
                            if (contador < letras.Length)
                            {
                                contador++;
                            }
                            #endregion
                        }
                        else
                        {
                            Console.Write("Arreglo No disponible para cierta accion");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        #endregion
                        break;
                    case 'd':
                        #region Busqueda
                        if (contador > -1)
                        {
                            int i;
                            Console.WriteLine("Elemento a Buscar: ");
                            char bus = Convert.ToChar(Console.ReadLine());

                            char[] caracter = new char[1];
                            caracter[0] = bus;
                            double numero1 = 0, numero2 = 0;
                            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(caracter);

                            for (int e = 0; e < caracter.Length ; e++)
                            {
                                numero1 = Convert.ToDouble(ASCIIvalues[e]);
                            }

                            for (i = 0; i < contador;)
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
                                }else if(i == contador)
                                {
                                    Console.WriteLine("No encontrado");
                                }
                                i++;
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
                    case 'e':
                        #region Eliminar
                        if (contador > -1)
                        {
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

                            if (enc == true)
                            {
                                for (int e = i; e <= contador - 1; e++)
                                {
                                    if (letras.Length <= 1)
                                    {
                                        #region Borrar
                                        Console.WriteLine("Arreglo limpio");
                                        letras = new char[0];
                                        contador = -1;
                                        Console.ReadKey();
                                        Console.Clear();
                                        #endregion
                                    }
                                    else
                                    {
                                        Console.WriteLine(e);
                                        Console.ReadKey();
                                        for(int l = e; l < letras.Length; l++)
                                        {
                                            if (l + 1 >= letras.Length)
                                                break;
                                            letras[e] = letras[l + 1];
                                            e++;
                                        }
                                        //guar = letras[e - 1];
                                        //letras[e] = guar;
                                        contador = contador - 1;

                                    }
                                }
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
                    case 'm':
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
                        break;
                    case 'v':
                        char n = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine(converter.CharToAscii(n));
                        break;
                
                }
            } while (trabajo);
            

            //letras[0] = 'a';
            //letras[1] = 'A';

            //Console.WriteLine(letras [1].GetTypeCode());

            //byte[] ASCIIvalues = Encoding.ASCII.GetBytes(letras);

            //for(int i = 0; i < letras.Length;)
            //{
            //    Console.WriteLine(ASCIIvalues[i]);
            //    i++;
            //}

            //if (letras[0].CompareTo(letras[1]) > 0)
            //    Console.WriteLine("Desorden");
            //else
            //    Console.WriteLine("Ordenados");

            //Console.ReadKey();

        }

    }
}
