using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // ( ЄЄЄ РОООКККК)
            {
                Random rnd = new Random();
                int a = rnd.Next(1, 100), b = rnd.Next(1, 100), c = rnd.Next(1, 4);
                Console.WriteLine(a);
                int ans = 0;
                switch (c)
                {
                    case 1:
                        Console.WriteLine('+'); ans = a + b;
                        break;
                    case 2:
                        Console.WriteLine('-'); ans = a - b;
                        break;
                    case 3:
                        Console.WriteLine('*'); ans = a * b;
                        break;
                    case 4:
                        Console.WriteLine('^'); ans = a ^ b;
                        break;
                }
                Console.WriteLine(b);
                int x = int.Parse(Console.ReadLine());

                if (x == ans)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

                Console.WriteLine("\r");
            }
        }
    }
}
