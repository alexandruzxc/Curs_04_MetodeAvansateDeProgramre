using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_03_MetodeAvansateDeProgramre
{
    class Program
    {
        static int nr = 0;
        static void h (int n, char A, char B, char C)
        {

            if (n == 1)
            {
                Console.WriteLine(A + "->" + C);
                nr++;
            }
            else
            {
                h(n - 1, A, C, B);
                h(1, A, B, C);
                h(n - 1, B, A, C);
            }
        }
        static void h2(int n, char A, char B, char C, char D)
        //se dau 4 tije, 
        //pe prima tija exista N discuri in ordine descrescatoare(de sus in jos)
        //respectand condtiile problemei Turnurilor din Hanoi, construiti solutia. 

        {
            if (n == 1 )
            {
                Console.Write(A + "->" + D);
                Console.WriteLine();
                nr++;
            }
            else if (n == 2)
            {
                h2(1, A, B, D, C);
                h2(1, A, B, C, D);
                h2(1, C, A, B, D);
            }
            else {
                h2(n - 2, A, C, D, B);
                h2(1, A, B, D, C);
                h2(1, A, B, C, D);
                h2(1, C, A, B, D);
                h2(n - 2, B, A, C, D);
                
                    }
        }
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            h2(n, 'A', 'B', 'C', 'D');

            Console.WriteLine(nr);
            Console.ReadKey();
            
        }
    }
}
