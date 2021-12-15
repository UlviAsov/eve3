using System;

namespace task3_tap12_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmis 6 reqemli ededin evveline ve axirina 8 artir.
            //Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyis.
            //reqemlerini 0 reqemi ile evez et.Neticenin tek yerde dayanan 

            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 100000 && num > 1000000){}

            num = (num + 8000000) * 10 + 8;

            num = (num % 10000) * 10000 + (num / 10000);

            


           
            


        }
    }
}
