using System;

namespace Lesson4_Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Чистка циклов
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            Console.WriteLine("Start:");
            double x = -10, y = -20, z, m1 = 34.0/17, m2;
            // z = 15*x^2 - 34*y/17 + x*y;
            for (x = -10; x < 20; x += 0.001)
            {
                // m2 = 15 * x * x;
                for (y = -20; y < 40; y += 0.01)
                {
                    // z = 15 * Math.Pow(x, 2) - 34 * y / 17 + x * y;  // 42000 mS
                    // z = 15 * x * x - 34 * y / 17 + x * y;  // 10000 mS
                    // z = 15 * x * x - y * m1 + y * x;  // 6300 mS
                    // z = m2 - m1 * y + x * y;  // ухудшает до 7100 mS
                     z = 15 * x * x + y * (-m1 + x);  // 6300 mS -> 5900 mS

                    //Console.WriteLine($"{x}, {y}");
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            // конец чистки циклов
            


            // Счастливый билет

            int ticket = Convert.ToInt32(Console.ReadLine());
            ;
            int n = 0, t = ticket, sum1 = 0, sum2 = 0;
            while (t > 0)
            {
                t /= 10;
                n++;
            }
            Console.WriteLine($"Кол-во разрядов: {n}");
            Console.WriteLine(ticket);
            int number = 0, div = (int)Math.Pow(10, n-1);
            for (int i = 1; i <= n; i++)
            {
                number = (ticket / div) % 10;
                Console.Write($"{number} ");
                div /= 10;
                if (i <= n / 2)
                    sum1 += number;
                else if (i > Math.Ceiling(n/2.0))
                    sum2 += number;
            }

            Console.WriteLine($"\n{sum1}  {sum2}");

            if (sum1 == sum2)
                Console.WriteLine("Счастливый билет!");

        }
    }
}
