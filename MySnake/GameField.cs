using System;

namespace MySnake
{
    public class GameField
    {
        public int Size { get; set; }

        public GameField()
        {
            Size = 20;
        }

        public void DrawWall()
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i <= Size; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("*");
                Console.SetCursorPosition(i, Size);
                Console.WriteLine("*");
                Console.SetCursorPosition(0, i);
                Console.WriteLine("*");
                Console.SetCursorPosition(Size, i);
                Console.WriteLine("*");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
