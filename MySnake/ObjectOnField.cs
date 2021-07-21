using System;

namespace MySnake
{
    public class ObjectOnField
    {
        Random rnd = new Random();
        Point point;
        GameField field = new GameField();


        public ObjectOnField()
        {
            point = new Point(rnd.Next(1, field.Size - 1), rnd.Next(1, field.Size - 1));
        }

        public void SetObject(int countObject, string nameObject)
        {
            switch (nameObject)
            {
                case "S":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        for (int i = 0; i < countObject; i++)
                        {
                            Console.SetCursorPosition(point.X, point.Y);
                            Console.WriteLine(nameObject);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "P":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int i = 0; i < countObject; i++)
                        {
                            Console.SetCursorPosition(point.X, point.Y);
                            Console.WriteLine(nameObject);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "T":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < countObject; i++)
                        {
                            Console.SetCursorPosition(point.X, point.Y);
                            Console.WriteLine(nameObject);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "W":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        for (int i = 0; i < countObject; i++)
                        {
                            Console.SetCursorPosition(point.X, point.Y);
                            Console.WriteLine(nameObject);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "A":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < countObject; i++)
                        {
                            Console.SetCursorPosition(point.X, point.Y);
                            Console.WriteLine(nameObject);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
            }

        }
        public Point LocationObject() => point;
        public void ObjectNewPosition() => point = new Point(rnd.Next(1, field.Size - 1), rnd.Next(1, field.Size - 1));
    }
}
