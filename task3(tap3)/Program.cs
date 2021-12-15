using System;

namespace task3_tap3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana
            Console.Write("Eded  daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%10==7)
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
