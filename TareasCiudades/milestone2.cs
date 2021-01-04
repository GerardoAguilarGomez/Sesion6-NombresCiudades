using System;
using System.Collections.Generic;
using System.Text;

namespace TareasCiudades
{
    class milestone2
    {
        public void Ejercicio()
        {
            int[,] alumnos = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                for (int x = 0; x < 3; x++)
                {

                    Console.WriteLine("Inserta la nota {0} del alumno {1}", x + 1, i + 1);
                    string n = Console.ReadLine();
                    if ((Convert.ToInt32(n) > 0) && (Convert.ToInt32(n) <= 10))
                    {
                        alumnos[i, x] = Convert.ToInt32(n);
                    }
                    else
                    {
                        alumnos[i, x] = 0;
                    }

                }
            }

            for (int i = 0; i < 5; i++)
            {
                double media = 0;

                for (int x = 0; x < 3; x++)
                {
                    media = media + alumnos[i, x];


                }
                Console.Write("Nota media del alumno {0}: {1}", i + 1, media / 3);
                if (media / 3 >= 5)
                {
                    Console.WriteLine(" - Alumno aprobado");
                }
                else
                {
                    Console.WriteLine(" - Alumno suspendido");
                }
            }
        }
    }
}
