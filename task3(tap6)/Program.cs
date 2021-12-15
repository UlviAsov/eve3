using System;

namespace task3_tap6_
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>=100 && num<1000){}
            int digit1 = num % 10;
            int digit2 = num / 10 % 10;
            int digit3 = num / 100;

            if (digit1+digit3==digit2)
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
