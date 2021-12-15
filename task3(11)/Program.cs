using System;

namespace task3_11_
{
    class Program
    {
        static void Main(string[] args)
        {
            //        11) Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse o zaman
            //            bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
            //            Neticenin ustune ortaya dushen 2 reqemini gel. 

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num>=100000 && num>1000000){}
            int digit6 = num % 10;
            int digit5 = num / 10 % 10;
            int digit4 = num / 100 % 10;
            int digit3 = num / 1000 % 10;
            int digit2 = num / 10000 % 10;
            int digit1 = num / 100000;
            
            if (digit1+digit2+digit3==digit6+digit5+digit4)
            {
               int a= (digit1 * 10 + digit2) * 100 + (digit5 * 10 + digit6);
                int b = a + (digit3 * 10 + digit4);
                Console.WriteLine($"Netice {b}");
            }
            else
            {
                Console.WriteLine("Uygun deil ");
            }





        }
    }
}
