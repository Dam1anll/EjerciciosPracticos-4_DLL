using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos_4_DLL
{
    public class Ejercicio
    {
        public void Ejercicio4()
        {
            //Inciso A.
            int[,] t = new int[2, 3];

            //Inciso B.
            Console.WriteLine(t.GetLength(0));

            //Inciso C.
            Console.WriteLine(t.GetLength(1));

            //Inciso D.
            Console.WriteLine(t.Length);

            //Inciso E.
            int tfila1 = t[1, 0];
            int tfila2 = t[1, 1];
            int tfila3 = t[1, 2];

            //Inciso F.
            int tcolumna1 = t[0, 2];
            int tcolumna2 = t[1, 2];

            //Inciso G.
            t[0, 1] = 0;

            //Inciso H.
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;

            //Inciso I.
            for (int x = 0; x < 2; x++)
            {
                for (int z = 0; z< 3; z++)
                {
                    t[x, z] = 0;
                }
            }

            //Inciso j.
            for (int x= 0; x < 2; x++)
            {
                for (int z = 0; z < 3; z++)
                {
                    Console.Write($"Ingrese el valor para t[{x}, {z}]: ");
                    t[x, z] = int.Parse(Console.ReadLine());
                }
            }

            //Inciso k.
            int menor = t[0, 0];

            for (int x = 0; x < 2; x++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (t[x, z] < menor)
                    {
                        menor = t[x, z];
                    }
                }
            }

            Console.WriteLine($"El valor más pequeño en t es: {menor}");

            //Inciso L.
            Console.WriteLine($"Elementos de la primera fila de t: {t[0, 0]}, {t[0, 1]}, {t[0, 2]}");

            //Inciso M.
            int total = t[0, 2] + t[1, 2];
            Console.WriteLine($"La suma de la tercera columna del arreglo t es: {total}");

            //Inciso N.
            Console.WriteLine("Índices de columna:\t0\t1\t2");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Índice de fila {i}:\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{t[i, j]}\t");
                }
                Console.WriteLine();
            }




        }
    }
}
