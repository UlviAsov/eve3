using System;

namespace task3_tap14_
{
    class Program
    {
        static void Main(string[] args)
        {
            //        14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler(bu o demekdirki 1, 2, 3, 4, 5, 6, 7 reqemlide ola biler)
            //Bu ededin evvelin 1 reqemini artir.

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num >0  && num <=9)
            {
                num = 10 + num;
                Console.WriteLine(num);
            }
            else if (num>=10 && num<100)
            {
                num = 100 + num;
                Console.WriteLine(num);
            }
            else if (num>=100 && num<1000)
            {
                num = 1000 + num;
                Console.WriteLine(num);
            }
            else if (num>=1000 && num<10000)
            {
                num = 10000 + num;
                Console.WriteLine(num);
            }
            else if (num >=10000 && num <100000)
            {
                num = 100000 + num;
                Console.WriteLine(num);
            }
            else if (num >=100000 && num <1000000 )
            {
                num = 1000000 + num;
                Console.WriteLine(num);
            }
            else if (num >= 1000000 && num <10000000)
            {
                num = 10000000 + num;
                Console.WriteLine(num);
            }
            else if (num >=10000000 && num <100000000)
            {
                num = 100000000 + num;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Uygun deil");
            }










        }
    }
}
