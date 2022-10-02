using System;

namespace sort
{
    internal class Program
    {
        static void BubbleSort(int[] pole)
        {
            int hold = 0;
            int count = 0;

            do
            {
                count = 0;

                for (int i = 1; i < pole.Length; i++)
                {
                    if (pole[i - 1] > pole[i])
                    {
                        hold = pole[i - 1];
                        pole[i - 1] = pole[i];
                        pole[i] = hold;
                        count++;
                    }
                }
            } while (count > 0);
        }

        static void Main(string[] args)
        {
            int[] pole = { 0, 5, 4, 9, 12, 0, 47, 6, 3 };
            BubbleSort(pole);
            Array.ForEach(pole, Console.WriteLine);
            Console.ReadKey();
        }
    }
}
