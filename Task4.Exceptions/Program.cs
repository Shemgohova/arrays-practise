using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }
            while (true)
            {
                Console.Write($"Введите индекс для вывода (0-{array.Length - 1}): ");
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Элемент [{index}] = {array[index]}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }
        }
    }
}
