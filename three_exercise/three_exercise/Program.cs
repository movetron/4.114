using System;

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int mounth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounth}.{year}");
            Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{year}");

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }


        }
    }