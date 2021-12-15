using System;

namespace task3_tap4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana

            Console.Write("Ededi daxil edin daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>=10 && num <100)
            {
                int a = num / 10;
                int b = num % 10;

                if (a==b)
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
}
