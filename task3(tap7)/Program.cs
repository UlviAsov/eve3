using System;

namespace task3_tap7_
{
    class Program
    {
        static void Main(string[] args)
        {
            //7)Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 100 && num < 1000) { }

            int digit1 = num % 10;
            int digit2 = num / 10 % 10;
            int digit3 = num / 100;

            int sum = digit1 + digit2 + digit3;
            if (sum==Math.Pow(digit3,2))
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }

        }
    }
}
