using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) verilmish ededin tek ve ya cut eded oldugunu yoxla
            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("Cut ededdir");
            }
            else
            {
                Console.WriteLine("Tek ededdir");
            }
        }
    }
}
