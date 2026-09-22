using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём массив из 10 случайных чисел в диапазоне [1, 100]
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Next(1, 101) → от 1 до 100 включительно
            }

            // Вывод массива через string.Join
            Console.WriteLine("Массив: " + string.Join(", ", array));

            // Сумма всех элементов
            long sum = 0;
            foreach (int n in array) sum += n;
            Console.WriteLine($"Сумма: {sum}");

            // Произведение (long — чтобы не переполниться)
            long product = 1;
            foreach (int n in array) product *= n;
            Console.WriteLine($"Произведение: {product:E}");

            // Количество чётных чисел
            int evenCount = 0;
            foreach (int n in array)
                if (n % 2 == 0) evenCount++;
            Console.WriteLine($"Чётных чисел: {evenCount}");

            // Среднее арифметическое
            double average = (double)sum / array.Length;

            // Количество чисел, больших среднего
            int aboveAverage = 0;
            foreach (int n in array)
                if (n > average) aboveAverage++;
            Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverage}");
        }
    }
}
