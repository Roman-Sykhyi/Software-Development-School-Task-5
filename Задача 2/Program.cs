using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 3, n = 3, p = 3;
            int[,,] objectImage = new int[m, n, p] 
            {
                {
                    {1, 0, 1}, {1, 1, 1}, {0, 0, 1}
                },
                {
                    {0, 0, 0}, {1, 0, 1}, {1, 1, 1 }
                },
                {
                    {0, 1, 0}, {1, 1, 1 }, {1, 0, 1 }
                }
            };
            int[,] xyShadow, xzShadow, yzShadow;

            xyShadow = FindXYShadow(objectImage, m, n, p);
            xzShadow = FindXZShadow(objectImage, m, n, p);
            yzShadow = FindYZShadow(objectImage, m, n, p);

            PrintShadow(xyShadow, m, n);
            PrintShadow(xzShadow, m, p);
            PrintShadow(yzShadow, n, p);
        }

        private static int[,] FindYZShadow(int[,,] objectImage, int m, int n, int p)
        {
            int[,] shadow = new int[n, p];
            for (int y = 0; y < n; y++)
            {
                for (int z = 0; z < p; z++)
                {
                    shadow[y, z] = 0;

                    for (int x = 0; x < m; x++)
                    {
                        if (objectImage[x, y, z] == 1)
                        {
                            shadow[y, z] = 1;
                            break;
                        }
                    }
                }
            }

            return shadow;
        }

        private static int[,] FindXZShadow(int[,,] objectImage, int m, int n, int p)
        {
            int[,] shadow = new int[m, p];
            for (int x = 0; x < m; x++)
            {
                for (int z = 0; z < p; z++)
                {
                    shadow[x, z] = 0;

                    for (int y = 0; y < n; y++)
                    {
                        if (objectImage[x, y, z] == 1)
                        {
                            shadow[x, z] = 1;
                            break;
                        }
                    }
                }
            }

            return shadow;
        }

        private static int[,] FindXYShadow(int[,,] objectImage, int m, int n, int p)
        {
            int[,] shadow = new int[m,n];
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    shadow[x, y] = 0;

                    for (int z = 0; z < p; z++)
                    {
                        if(objectImage[x,y,z] == 1)
                        {
                            shadow[x, y] = 1;
                            break;
                        }
                    }
                }
            }

            return shadow;
        }

        private static void PrintShadow(int[,] shadow, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{shadow[i, j],-3} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
