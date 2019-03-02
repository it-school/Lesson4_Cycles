using System;

namespace Lesson4_Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                double d = Convert.ToDouble(Console.ReadLine().ToLower().Replace('.', ','));
            }
            catch (Exception exc)
            {
                Console.WriteLine("Sorry!" + exc.Message);
            }
            */

            int number = 1234;
            int t = number / 1000 % 10;
            int s = number / 100 % 10;
            int d = number / 10 % 10;
            int e = number / 1 % 10;

            if (e % 2 == 0)
            {
                Console.WriteLine("Odd");
            }
            else
                Console.WriteLine("Even");

            Console.WriteLine(e % 2 == 0 ? "Odd" : "Even");

            int a = 1, b = 3, c = 0;
            if (a < 0 && b < 0 && c < 0)
                Console.WriteLine(3);
            else
                if ((a < 0 && b < 0 && c >= 0) || (a < 0 && b >= 0 && c < 0) || (a >= 0 && b < 0 && c < 0))

                Console.WriteLine(2);
            else
                if ((a < 0 && b >= 0 & c >= 0) || (a >= 0 && b < 0 & c >= 0) || (a >= 0 && b >= 0 & c < 0))
                Console.WriteLine(1);
            else
                Console.WriteLine(10 + "\b\b\a" + '*' + (int)7);

            task1();

            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i++);
            }

            
            
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

            //isTicketHappy();
            /*
            Console.WriteLine(isTicketHappy2(123454321) ? "Happy!" : "UnHappy");

            switcher(68);
            task2(100);
            multtable();
            */

            /*
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int ks = 0;
            for (int k = 0; k < 300000; k++)
                if (simple(k) == true)
                    ks++;

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            Console.WriteLine($"Number of simles is: {ks}");
            */
        }

        private static bool simple(int n)
        {
            if (n % 2 == 0 && n%5 == 0)
                return false;
            for (int i = 2; i < n/2; i++)
            {
                if (n % i == 0)
                {
                    //Console.WriteLine("Not simple");
                    return false;
                }
            }
            //Console.WriteLine(n + " is simple");
            return true;
        }


        private static void multtable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void task2(int n)
        {
            Console.WriteLine($"All dividers of {n}");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
        }

        private static void isTicketHappy()
        {
            int ticket = Convert.ToInt32(Console.ReadLine());

            int n = 0, t = ticket, sum1 = 0, sum2 = 0;
            while (t > 0)
            {
                t /= 10;
                n++;
            }
            Console.WriteLine($"Кол-во разрядов: {n}");
            Console.WriteLine(ticket);
            int number = 0, div = (int)Math.Pow(10, n - 1);
            for (int i = 1; i <= n; i++)
            {
                number = (ticket / div) % 10;
                Console.Write($"{number} ");
                div /= 10;
                if (i <= n / 2)
                    sum1 += number;
                else if (i > Math.Ceiling(n / 2.0))
                    sum2 += number;
            }

            Console.WriteLine($"\n{sum1}  {sum2}");

            if (sum1 == sum2)
                Console.WriteLine("Счастливый билет!");

        }



        private static bool isTicketHappy2(int number)
        {
            //   Console.WriteLine(number);
            int n = 0, t = number, sum1 = 0, sum2 = 0;
            while (t > 0)
            {
                t /= 10;
                n++;
            }
            // Console.WriteLine($"Кол-во разрядов: {n}");

            int n2 = 0;
            while (number > 0 && n2 < n / 2)
            {
                sum2 += number % 10;    // sum2 = sum2 + number % 10;
                number /= 10;           // number = number / 10;
                n2++;
                //   Console.WriteLine(sum2);
            }

            if (n % 2 == 1)
                number /= 10;
            while (number > 0)
            {
                sum1 += number % 10;    // sum2 = sum2 + number % 10;
                number /= 10;           // number = number / 10;
                                        // Console.WriteLine(sum1);
            }

            /*
            if (sum1 == sum2)
                return true;
            else
                return false;
                */

            return (sum1 == sum2) ? true : false;
        }


        private static void task1()
        {
            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                    return;
                Console.WriteLine(j);
            }

        }

        private static void switcher(int n)
        {

            if (n == 1)
                Console.WriteLine("Monday");
            else
            {
                if (n == 2)
                    Console.WriteLine("Tuesday");
                else
                {
                    if (n == 3)
                        Console.WriteLine("Wednesday");
                    else
                        Console.WriteLine("Wrong day");
                }
            }
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Other working days");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Free days");
                    break;
                default:
                    Console.WriteLine("Wrong day");
                    break;
            }

        }
    }
}
