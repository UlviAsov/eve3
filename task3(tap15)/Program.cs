using System;

namespace task3_tap15_
{
    class Program
    {
        static void Main(string[] args)
        {
            //15) IF operatoru ile yoxla. 
            //   Verilmish ededdin 1 - ile 365 arasinda olugunu yoxla(1 ve 365 ozude daxil olmaq sherti ile)
            //  Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>0 && num<=19)
            {             
                Console.WriteLine("Yanvar, Oglaq");
            }
            else if (num >=20 && num<=31)
            {
                Console.WriteLine("Yanvar, Dolca");
            }
            else if (num >=31 && num <=49)
            {
                Console.WriteLine("Fevral, Dolca");
            }
            else if (num>49 && num <=120)
            {
                Console.WriteLine("Aprel");
            }
            else if (num>120 && num<=151)
            {
                Console.WriteLine("May");
            }
            else if (num>151 && num <=181)
            {
                Console.WriteLine("Iyun");
            }
            else if (num>181 && num <=212)
            {
                Console.WriteLine("Iyul");
            }
            else if (num>212 && num<=243)
            {
                Console.WriteLine("Avqust");
            }
            else if (num>243 && num<=273)
            {
                Console.WriteLine("Sentyabr");
            }
            else if (num>273 && num<=304)
            {
                Console.WriteLine("Oktyabr");
            }
            else if (num>304 && num <=334)
            {
                Console.WriteLine("Noyabr");
            }
            else if (num>334 && num<=365)
            {
                Console.WriteLine("Dekabr");
            }
            else
            {
                Console.WriteLine("Uygun deil");
            }









        }
    }
}
