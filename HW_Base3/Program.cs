using System;

namespace HW_Base3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b;
                string c;

                try
                {
                    Console.WriteLine("Введите число 1");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Неверный ввод!");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Введите действие: '+', '-', '*', '/'");
                c = Console.ReadLine();


                switch (c)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Делить на 0 нельзя!");
                        }
                        else
                        {
                            Console.WriteLine(a / b);
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: Неверный ввод!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
