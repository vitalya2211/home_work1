using System;

namespace home_work1
{
    class Program
    {
        static void Main(string[] args)
        {/*Напишите программу, 
          * которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
            Console.WriteLine("программа принимает два числа, возвращает большее\n Введите первое число:");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("max= " + a);
            else if (a < b)
                Console.WriteLine("max= " + b);
            else Console.WriteLine("числа равны");
            Console.ReadKey();

        }
    }
}
