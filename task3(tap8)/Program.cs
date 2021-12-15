using System;

namespace task3_tap8_
{
    class Program
    {
        static void Main(string[] args)
        {
            //         //8) SWITCH operatoru ile yoxla. 
            //              Verilmish ededdin sonuncu reqemi

            //              1 olarsa - "I gun" sozunu
            //              2 olarsa - "II gun" sozunu...
            //	           7 olarsa - "VI gun" sozunu yaz

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch (num%10)
            {
                case 1:
                    Console.WriteLine("1 ci-gun");
                    break;
                case 2: 
                    Console.WriteLine("2 ci-gun");
                    break;
                case 7: 
                    Console.WriteLine("7ci gun");
                    break;
                default:
                    Console.WriteLine("Uygunluq yoxdur");
                    break;
            }



        }
    }
}
