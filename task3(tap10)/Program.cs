using System;

namespace task3_tap10_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) IF operatoru ile yoxla.  6 dene eded verilib.Bu ededlerden hansi en boyukdur.
            int[] array = new int[6];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Eded daxil edin");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max<array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"En boyuk eded {max}");

        }
    }
}
