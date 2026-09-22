using System;
using System.Linq;

namespace Final.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatures = { 22.5, 23.1, 19.8, 21.3, 24.0, 25.2, 20.7 };
            double avg = temperatures.Average();
            Console.WriteLine($"Средняя температура: {avg:F1}°C");
            Console.WriteLine($"Максимум: {temperatures.Max()}°C");
            Console.WriteLine($"Минимум: {temperatures.Min()}°C");
            int above20 = temperatures.Count(t => t > 20);
            Console.WriteLine($"Дней выше 20°C: {above20}");
        }
    }
}

