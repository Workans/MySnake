using System;
using System.Collections.Generic;
using System.Threading;

namespace MySnake
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char dest = 'q';
        public int X { get; set; }
        public int Y { get; set; }
        public List<Point> points { get; set; }
        GameField field;

        public Snake()
        {
            field = new GameField();
            X = 10;
            Y = 10;
            points = new List<Point>();
            points.Add(new Point(X, Y));
            Console.CursorVisible = false;
        }

        public void DrawSnake()
        {
            foreach (Point p in points)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("☻");
            }

        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void SetDest()
        {
            if (key == 'w' && dest != 'd') dest = 'u';
            else if (key == 's' && dest != 'u') dest = 'd';
            else if (key == 'a' && dest != 'r') dest = 'l';
            else if (key == 'd' && dest != 'l') dest = 'r';
        }

        public void Move()
        {
            int tmpX = points[0].X;
            int tmpY = points[0].Y;
            SetDest();
            if (key == 'w') Y--;
            else if (key == 's') Y++;
            else if (key == 'a') X--;
            else if (key == 'd') X++;
            points.Add(new Point(X, Y));
            points.RemoveAt(0);
            Thread.Sleep(100);
            Console.SetCursorPosition(tmpX, tmpY);
            Console.WriteLine(" ");
        }
        public void SnakeEat(Point frutPos, ObjectOnField obj)
        {
            Point headSnake = points[points.Count - 1];
            if (headSnake.X == frutPos.X && headSnake.Y == frutPos.Y)
            {
                points.Add(new Point(X, Y));
                obj.ObjectNewPosition();
            }
        }
        public void SnakeBroke()
        {
            Point headSnake = points[points.Count - 1];
            for (int i = 0; i < points.Count - 2; i++)
            {
                Point bodySnake = points[i];
                if (headSnake.X == bodySnake.X && headSnake.Y == bodySnake.Y)
                {
                    throw new SnakeException("GAME OVER");
                }
            }
        }
        public void SnakeHitWall()
        {
            Point headSnake = points[points.Count - 1];
            if (headSnake.X >= field.Size || headSnake.X <= 0 || headSnake.Y >= 20 || headSnake.Y <= 0)
                throw new SnakeException("GAME OVER");
        }
        public void SnakeHitStone(Point stonePos, ObjectOnField obj)
        {
            Point headSnake = points[points.Count - 1];
            if (headSnake.X == stonePos.X && headSnake.Y == stonePos.Y)
            {
                throw new SnakeException("GAME OVER");
            }
        }
    }
}
