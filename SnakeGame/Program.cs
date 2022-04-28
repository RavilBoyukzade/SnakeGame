using System;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;//coordinates of dot on absiss
            int y1 = 3;//coordinates of dot on ordinate
            char sym1 = '*';//dot
            Draw(x1,y1,sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Draw(x2,y2,sym2);
            Console.ReadLine();//stay in programm
        }

        static void Draw(int x,int y,char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
            
        }
    }
}
 