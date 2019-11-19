using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num;
                int count = 0;
                do
                {
                    
                    Console.Write("Введите натуральное число: ");
                    if (int.TryParse(Console.ReadLine(), out num))
                        if (num > 0) break;

                } while (true);

                do
                {
                    if (num % 2 == 0) count++;
                    num /= 10;
                } while (num > 0);

                Console.WriteLine("\nЧётных чисел: " + count);

                Console.WriteLine(new string('_', 25) + "\nДля выхода нажмите ESC ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
