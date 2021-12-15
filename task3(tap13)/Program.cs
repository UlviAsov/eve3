using System;

namespace task3_tap13_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13) Verilmish 7 reqemli eded polindromdursa o zaman onun daxilnde nece dene 0 reqemi oldugunu tap ?
            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num>=1000000 && num<10000000){}
            int box = 0;
            int newNum = num;
            while (newNum>0)
            {
                int digit =newNum % 10;
                newNum = newNum / 10;
                box = box * 10 + digit;
              
            }
           
            int counter = 0;
            if (box==num)
            {
                for (int i = 0; i < 7; i++)
                {
                    int zero = num % 10;
                    num = num / 10;
                    if (zero ==0)
                    {
                        counter++;
                       
                    }

                }
            }
            Console.WriteLine($"Sifirlarin sayi: {counter}");
           


        }
    }
}
