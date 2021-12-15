using System;

namespace task3_tap5_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5) Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.
            Console.Write("Ededi daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
           
 
            int sum = 0;
            int times = 1;
            int digit = 1;
            if (num>=10 && num<100)
            {
                
                
                
            }
            for (int i = 0; i < 2; i++)
            {
                digit = num % 10;
                num = num / 10;
                sum += digit;
                
            }
            if (sum%2==0)
            {
                digit = num % 10;
                num = num / 10;
                times = times * digit;

            }
            Console.WriteLine(times);


        }
    }
}
