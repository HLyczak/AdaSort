using System;
using System.Linq;

namespace AdaSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int iloscLiczb = Convert.ToInt32(Console.ReadLine());
            string liczby = Console.ReadLine();
            // 2 3 4 5
            // [2,3,4,5]
            // int index = 1;
            // a => (a, index
            // 2 => (2,1)
            // 3 => (3,2)
            // [(2,1), (3,2), (4,3), (5,4)]
            // [(2,1), (3,2),(5,4), (4,3) ]

            (int, int)[] tab = Array.ConvertAll(liczby.Split(' '), int.Parse).Select((a, index) => (a, index)).ToArray();
            Sort(tab, 0, tab.Length - 1);
        }

        public static void Sort((int, int)[] array, int lewy, int prawy)
        {
            var i = lewy;
            var j = prawy;
            var srodek = array[(lewy + prawy) / 2];
            var srodkowy = srodek.Item1;
            while (i < j)
            {
                while (array[i].Item1 < srodkowy) i++;
                while (array[j].Item1 > srodkowy) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = array[i];
                    array[i++] = array[j];  // ++ and -- inside array braces for shorter code
                    array[j--] = tmp;
                }
            }
            if (lewy < j) Sort(array, lewy, j);
            if (i < prawy) Sort(array, i, prawy);
        }
    }
}