using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    //Se da un vector sortat si vrem sa aflam daca un element X exista in vectorul respectiv

    class Program
    {
        static int c2 = 0;
        static bool found (int []v, int x, int St, int Dr)
        {
            c2++;
            if (St <= Dr)
            {
                int m = (St + Dr) / 2;
                if (v[m] == x)
                    return true;
                else if (x < v[m])
                    return found(v, x, St, m - 1);
                else
                    return found(v, x, m + 1, Dr);
            }
            else return false;
            //algoritm de cautare binara
            //metoda de a gasi un element dintr-un vector daca este sortat 
        }

        static int c1 = 0;
        static bool found (int [] v, int x)
        {
            for (int i = 0; i < v.Length; i++)
            {
                c1++;
                if (v[i] == x)
                    return true;               
            }
            return false;
        }
        static int Nc, Nu;
        static int x = 0;
        // Nc - numarul calcuatorului
        // Nu- numarul utilizatorului
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            /* Nc = rnd.Next(1000);

             do
             {
                 Nu = int.Parse(Console.ReadLine());
                 x++;
                 if (Nu < Nc)
                     Console.WriteLine("Too low");
                 else
                     if (Nc < Nu)
                     Console.WriteLine("Too High");
             }
             while (Nu != Nc);
             Console.WriteLine("You found the number after " + x +  "tries");
            varianta triviala*/

            int[] v;
            int n = 1000, k = 10000;
            v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(k);
            }
            
            int[] x;
            int t = 5000;
            x = new int [t];
            for (int i = 0; i < t; i++)
            {
                x[i] = rnd.Next(k);
            }

            for (int i = 0; i < t; i++)
            {
                found(v, x[i]);
            }
            Console.WriteLine(c1);
            int aux;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    { aux = v[i];
                        v[i] = v[j];
                        v[j] = aux; }
                }
            }
            for (int i = 0; i < t; i++)
            {
                found(v, x[i], 0, v.Length - 1 );

            }
            Console.WriteLine(c2 + 700000);
        }
    }
}
