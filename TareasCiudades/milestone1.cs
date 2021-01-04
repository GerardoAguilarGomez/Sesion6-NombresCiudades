using System;
using System.Collections.Generic;
using System.Text;

namespace TareasCiudades
{
    class milestone1
    {
        public void Ejercicio()
        {
            //FASE1
            Console.WriteLine("Ciudad nº1: ");
            string ciudad1 = Console.ReadLine();

            Console.WriteLine("Ciudad nº2: ");
            string ciudad2 = Console.ReadLine();

            Console.WriteLine("Ciudad nº3: ");
            string ciudad3 = Console.ReadLine();

            Console.WriteLine("Ciudad nº4: ");
            string ciudad4 = Console.ReadLine();

            Console.WriteLine("Ciudad nº5: ");
            string ciudad5 = Console.ReadLine();

            Console.WriteLine("Ciudad nº6: ");
            string ciudad6 = Console.ReadLine();

            Console.WriteLine("{0}. {1}. {2}. {3}. {4}. {5}. ", ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6);

            //FASE 2

            string[] ArrayCiudades = { ciudad1,ciudad2,ciudad3,ciudad4,ciudad5,ciudad6};

            Comparison<string> comparador = new Comparison<string>((cadena1, cadena2) => cadena1.CompareTo(cadena2));

            Array.Sort(ArrayCiudades, comparador);
            Console.WriteLine("Orden alfabético: ");
            for(int i = 0; i <= ArrayCiudades.Length - 1; i++)
            {
                Console.WriteLine(ArrayCiudades[i]);
            }

            //FASE 3

            string[] ArrayCiudaddesModificadas = new string[6];

            Comparison<string> comparador2 = new Comparison<string>((cadena1, cadena2) => cadena1.CompareTo(cadena2));

            for (int i = 0; i <= ArrayCiudades.Length-1; i++)
            {
                ArrayCiudaddesModificadas[i] = ArrayCiudades[i].Replace("a","4");
                //Console.WriteLine(ArrayCiudaddesModificadas[i]);
               
            }

            //Array.Sort(ArrayCiudaddesModificadas, comparador2);
            Console.WriteLine();
            Console.WriteLine("Orden alfabético sustituyendo a x 4: ");

            for (int i = 0; i <= ArrayCiudaddesModificadas.Length - 1; i++)
            {
                Console.WriteLine(ArrayCiudaddesModificadas[i]);
            }

            //FASE 4

            char[] nomCiudad1 = new char[ciudad1.Length];
            char[] nomCiudad2 = new char[ciudad2.Length];
            char[] nomCiudad3 = new char[ciudad3.Length];
            char[] nomCiudad4 = new char[ciudad4.Length];
            char[] nomCiudad5 = new char[ciudad5.Length];
            char[] nomCiudad6 = new char[ciudad6.Length];

            for(int i = 0; i <= nomCiudad1.Length - 1; i++)
            {
                nomCiudad1[i] = Convert.ToChar(ciudad1.Substring(i, 1));
            }

            for (int i = 0; i <= nomCiudad2.Length - 1; i++)
            {
                nomCiudad2[i] = Convert.ToChar(ciudad2.Substring(i, 1));
            }

            for (int i = 0; i <= nomCiudad3.Length - 1; i++)
            {
                nomCiudad3[i] = Convert.ToChar(ciudad3.Substring(i, 1));
            }

            for (int i = 0; i <= nomCiudad4.Length - 1; i++)
            {
                nomCiudad4[i] = Convert.ToChar(ciudad4.Substring(i, 1));
            }

            for (int i = 0; i <= nomCiudad5.Length - 1; i++)
            {
                nomCiudad5[i] = Convert.ToChar(ciudad5.Substring(i, 1));
            }

            for (int i = 0; i <= nomCiudad6.Length - 1; i++)
            {
                nomCiudad6[i] = Convert.ToChar(ciudad6.Substring(i, 1));
            }

            Console.WriteLine();
            Console.WriteLine("Ciudad Número 1: ");
            for(int i = nomCiudad1.Length - 1; i >= 0; i--)
            {
                Console.Write(nomCiudad1[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Ciudad Número 2: ");
            for (int i = nomCiudad2.Length - 1; i >= 0; i--)
            {
                Console.Write(nomCiudad2[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Ciudad Número 3: ");
            for (int i = nomCiudad3.Length - 1; i >= 0; i--)
            {
                Console.Write(nomCiudad3[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Ciudad Número 4: ");
            for (int i = nomCiudad4.Length - 1; i >= 0; i--)
            {
                Console.Write(nomCiudad4[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Ciudad Número 5: ");
            for (int i = nomCiudad5.Length - 1; i >= 0; i--)
            {
                Console.Write(nomCiudad5[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Ciudad Número 6: ");
            for (int i = nomCiudad6.Length - 1; i >= 0; i--)
            {
                Console.Write(nomCiudad6[i]);
            }

        }
    }
}
