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
            char[] letras = new char[0];
            int contador = -1;
            bool trabajo = true;

            do
            {
                #region Acciones
                Console.WriteLine("Accion a realizar: (Crear->c, Borrar->b, " +
                        "Insertar->i, Revisar->r, " +
                            "Buscar->d, Eliminar->e, " +
                                "Modificar->m, Creditos->o)");
                #endregion
                char descicion = Convert.ToChar(Console.ReadLine());
                switch (descicion)
                {
                    case 'c':
                        #region Crear
                        if(contador == -1) 
                        { 
                            Console.WriteLine("Asignar Tamaño de Arreglo: ");
                            int max = Convert.ToInt16(Console.ReadLine());
                            letras = new char[max];
                            contador = 0;
                        }
                        else
                        {
                            Console.WriteLine("Arreglo ya creado");
                        }
                        Console.ReadKey();
                        Console.Clear();
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
