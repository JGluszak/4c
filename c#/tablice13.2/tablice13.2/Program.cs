using System;

namespace tablice13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[3];
            tab[2] = new int[2];
            tab[3] = new int[1];

            int licznik = 1,i=0;

            while(i < tab.Length)
            {
                int j = 0;
                while (j < tab[i].Length)
                {
                    tab[i][j] = licznik++;
                    j++;
                }
                i++;
            }
            int x = 0;
            while ( x < tab.Length)
            {
                Console.Write($"tab[{x}] = ");
                int z = 0;
                while (z < tab[x].Length)
                {
                    Console.Write($" {tab[x][z]} ");
                    z++;
                }
                x++;
                Console.WriteLine("");
            }
        }
    } 
}
