using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Введите количество элементов: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.WriteLine("Ошибка: введите целое число больше 0.");
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");
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
            Console.WriteLine("\nИсходный массив:  " + string.Join(", ", array));
            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
                reversed[i] = array[n - 1 - i];
            Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

            Array.Sort(array);
            Console.WriteLine("Отсортированный:  " + string.Join(", ", array));

            int max = array[0];
            int min = array[0];
            foreach (int x in array)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}
