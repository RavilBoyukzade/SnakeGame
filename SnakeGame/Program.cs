using System;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,4,'#');
            p1.Draw();

            Point p2 = new Point(4,9,'#');
            p2.Draw();

            Console.ReadLine();//stay in programm
        }
    }
}
 