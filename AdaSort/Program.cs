using System;

namespace AdaSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int iloscLiczb = Convert.ToInt32(Console.ReadLine());
            if (iloscLiczb != 0)
            {
                string[] liczby = Console.ReadLine().Split(' ');
                int[][] tab = new int[iloscLiczb][];
                for (int i = 0; i < iloscLiczb; i++)
                {
                    tab[i] = new int[] { int.Parse(liczby[i]), i + 1 };
                }

                Array.Sort(tab, (a, b) => a[0] <= b[0] ? -1 : 1);
                foreach (var item in tab)
                {
                    Console.Write(item[1] + " ");
                }
            }
        }
    }
}