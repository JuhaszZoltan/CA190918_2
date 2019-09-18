using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190918_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //BudapestenAt();
            //RndHely();
            //Legnagyobb();
            //Leghosszabb();
            Sorbaba();
            Console.ReadKey();
        }

        private static void Sorbaba()
        {
            Console.Write("gyerekek száma: ");
            int n = int.Parse(Console.ReadLine());

            string[] nevek = new string[n];
            int[] korok = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. gyerek neve: ");
                nevek[i] = Console.ReadLine();
                Console.Write($"{i + 1}. gyerek kora: ");
                korok[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("------------");
            }

            //Array.Sort(korok, nevek);

            for (int i = 0; i < korok.Length - 1; i++)
            {
                for (int j = i + 1; j < korok.Length; j++)
                {
                    if (korok[j] < korok[i])
                    {
                        var s1 = korok[i];
                        korok[i] = korok[j];
                        korok[j] = s1;

                        var s2 = nevek[i];
                        nevek[i] = nevek[j];
                        nevek[j] = s2;
                    }
                }
            }

            foreach (var nn in nevek)
            {
                Console.Write($"{nn} ");
            }
        }

        private static void Leghosszabb()
        {
            string[] t = new string[3];
            int maxi = 0;
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{i+1}. szó: ");
                t[i] = Console.ReadLine();
                if (i != 0 && t[i].Length > t[maxi].Length) maxi = i;
            }
            Console.WriteLine($"A leghosszabb szó a(z) {t[maxi]}");
        }
        private static void Legnagyobb()
        {
            int[][] t = new int[3][];

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"T{i+1}: ");
                t[i] = new int[5];
                for (int j = 0; j < t[i].Length; j++)
                {
                    t[i][j] = rnd.Next(1, 1001);
                    Console.Write("{0,3}, ", t[i][j]);
                }
                Console.Write("\n");
            }

            int maxi = 0;

            for (int i = 0; i < t.Length; i++)
                if (t[i].Sum() > t[maxi].Sum()) maxi = i;
            Console.WriteLine($"A T{maxi+1}-ben a legnagyobb az elemek összege");
        }
        private static void RndHely()
        {
            Console.Write("írj be valamit: ");
            var s = Console.ReadLine();
            Console.Clear();

            foreach (char c in s)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.Write(c);
            }

        }
        private static void BudapestenAt()
        {
            Console.Write("Első város neve: ");
            var v1 = Console.ReadLine();
            Console.Write("Bp.-től való távolsága: ");
            var t1 = int.Parse(Console.ReadLine());

            Console.Write("Második város neve: ");
            var v2 = Console.ReadLine();
            Console.Write("Bp.-től való távolsága: ");
            var t2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{v1}-ből {v2}-be Budapesten keresztül {t1 + t2} km az út.");
        }
    }
}
