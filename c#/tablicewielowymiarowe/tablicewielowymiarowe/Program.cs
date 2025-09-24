using System;

namespace tablicewielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab =
            {
                { 0 , 1, 2, 3, 4} ,
                { 5 , 6, 7, 8, 9}
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"tab[{i},{j}] {tab[i, j]}");
                }
            }
            Console.WriteLine("\n\n\n");

            int[,] tab2 =
            {
                { 9 , 8, 7, 6, 5} ,
                { 4 , 3, 2, 1, 0}
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"tab2[{i},{j}] {tab2[i, j]}");
                }
            }


            Console.WriteLine("\n\n\n");
            int[,] tab3 =
            {
                { 0 , 1, 2, 3, 4} ,
                { 5 , 6, 7, 8, 9}
            };
            for (int i = 1; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    Console.WriteLine($"tab3[{i},{j}] {tab3[i, j]}");
                }
            }
            Console.WriteLine("\n\n\n");

            int[,] tabb = new int[2, 5];
            int licznik = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tabb[i, j] = licznik++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"tabb[ {i} , {j}] {tabb[i, j]}");

                }
            }

            Console.WriteLine("\n\n\n");

            int[][] tabtab = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                tabtab[i] = new int[5];
            }
            int licznikk = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tabtab[i][j] = licznikk++;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"tabtab[{i}] [{j}] = {tabtab[i][j]}");
                }
            }
            Console.WriteLine("\n\n\n");


            int[][] tab12 = new int[2][];

            for (int i = 0; i < tab12.Length; i++)
            {
                tab12[i] = new int[5];
            }

            int licznikkk = 0;

            for (int i = 0; i < tab12.Length; i++)
            {
                for (int j = 0; j < tab12[i].Length; j++)
                {
                    tab12[i][j] = licznikkk++;
                }
            }

            for (int i = 0; i < tab12.Length; i++)
            {
                for (int j = 0; j < tab12[i].Length; j++)
                {
                    Console.WriteLine($"tab12[{i}][{j}] = {tab12[i][j]}");
                }
            }


        }
    }
}
