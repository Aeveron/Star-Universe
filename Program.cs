using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleStars
{
    class Program
    {      
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new Star[]
            {
                new Star(5, 10, 1, 2, 0),
                new Star(10, 5, 2, 1, 0),
                new Star(25, 10, 3, 0, 1),
                new Star(52, 10, 4, -1, 0),
                new Star(12, 5, 5, 1, 1),
                new Star(5, 10, 1, 2, 0),
                new Star(10, 5, 2, 1, 0),
                new Star(25, 10, 3, 0, 1),
                new Star(52, 10, 4, -1, 0),
                new Star(12, 5, 5, 1, 1),
                new Star(5, 10, 1, 2, 0),
                new Star(10, 5, 2, 1, 0),
                new Star(25, 10, 3, 0, 1),
                new Star(52, 10, 4, -1, 0),
                new Star(12, 5, 5, 1, 1),
                new Star(5, 10, 1, 2, 0),
                new Star(10, 5, 2, 1, 0),
                new Star(25, 10, 3, 0, 1),
                new Star(52, 10, 4, -1, 0),
                new Star(12, 5, 5, 1, 1),
            };
            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(100);
            }
        }
    }
}
