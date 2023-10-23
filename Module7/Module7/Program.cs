using System;
using Day7__Tanks_;

namespace Module7
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                Tank t34 = new Tank("T-34", random);
                Tank pantera = new Tank("Pantera", random);

                Console.WriteLine($"Сражение {i + 1}:");
                Console.WriteLine(t34.GetTankParameters());
                Console.WriteLine(pantera.GetTankParameters());

                if (t34 * pantera)
                {
                    Console.WriteLine("Победил Т-34");
                }
                else
                {
                    Console.WriteLine("Победил Pantera");
                }
                Console.ReadLine();
            }
        }
    }
}
