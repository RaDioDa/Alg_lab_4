using System;

namespace Alg_lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(100);

            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                queue.insert("Element " + (i + 1));
                Console.WriteLine("Element {0}", i + 1);
            }
            Console.WriteLine("=================================");
            Random random = new Random();
            int min = random.Next(0, 80);
            int max = random.Next(20, 100);
            int control = random.Next(0, 100);
            if (min > max)
            {
                int tmp = max;
                max = min;
                min = tmp;
            }

            for (int i = 0; i < 100; i++)
            {
                if (control >= min && control <= max)
                {
                    string tmp = queue.remove();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(tmp + " PASS");
                    min = random.Next(0, 100);
                    max = random.Next(0, 100);
                    control = random.Next(0, 100);
                    counter++;
                }
                else
                {
                    string tmp = queue.remove();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(tmp + " NULL");
                    min = random.Next(0, 100);
                    max = random.Next(0, 100);
                    control = random.Next(0, 100);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("======================\n" +
                              "= Served: {0} objects =" +
                            "\n======================", counter);
        }
    }
}
