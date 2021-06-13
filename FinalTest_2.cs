using System;

namespace Final_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 1;
            int[] a = new int[100];
            Console.Write("Put Number: ");

            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int number = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = number;
                    }
                }
            }
            Console.Write("GG' s Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
                Console.ReadLine();
            }
        }
    }
}
