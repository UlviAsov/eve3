using System;

namespace task3_tap2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) 2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart.Eks halda  "bolunmur" sozunu cap et
            Console.Write("1ci ededi daxil edin: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2ci ededi daxil edin: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int a = num1 / num2;
            if (num1%num2==0)
            {
                
                Console.WriteLine(a);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Tam bolunmur");
            }

            Console.ReadKey();



        }
    }
}
