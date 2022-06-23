using System;


namespace home_work1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("введите номер задачи:\n" +
                "1. программа выводит максимальное из двух чисел.\n" +
                "2. Выводит максимальное из трех чисел.\n" +
                "3. является ли число четным\n" +
                "4. выводит все четные до N\n");
            
                        /*Напишите программу, 
                      * которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
                        Console.WriteLine("программа принимает два числа, возвращает большее\n Введите первое число:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("введите второе число:");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (a > b)
                            Console.WriteLine("max= " + a);
                        else if (a < b)
                            Console.WriteLine("max= " + b);
                        else Console.WriteLine("числа равны");
                        Console.ReadKey();

            /*"2. Выводит максимальное из трех чисел*/
            Console.WriteLine("введите три числа\n первое:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("третье число:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b & a > c)
                Console.WriteLine("max = " + a);
            else if (b > a & b > c)
                Console.WriteLine("max = " + b);
            else if (c > a & c > b)
                Console.WriteLine("max = " + c);
            else Console.WriteLine("числа равны");
            Console.ReadKey();
            /*четность числа*/
            Console.WriteLine("проверка числа на четность");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("число четное");
            else Console.WriteLine("число не четное");
            Console.ReadKey();

        }
    }
}
