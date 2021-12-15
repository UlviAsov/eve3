using System;

namespace task3_tap9_
{
    class Program
    {
        static void Main(string[] args)
        {
            //         9) SWITCH operatoru ile yoxla. 
            //            Verilmish ededdin 1 - ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
            //            Eger bu eded

            //            1 olarsa - "Yanvar" sozunu
            //            2 olarsa - "Fevral" sozunu...
            //	        12 olarsa - "Dekabr" sozunu yaz

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>=1 && num<=12){}
 
            switch (num)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;



                default:
                    Console.WriteLine("Uygun deil");
                    
                    break;

            }

            Console.ReadKey();


        }
    }
}
