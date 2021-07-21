using System.Threading;

namespace MySnake
{

    class Program
    {


        static void Main(string[] args)
        {


            GameField wall = new GameField();
            Snake snake = new Snake();
            ObjectOnField apple = new ObjectOnField();
            Thread.Sleep(300);
            ObjectOnField stone = new ObjectOnField();
            Thread.Sleep(300);
            ObjectOnField tree = new ObjectOnField();
            Thread.Sleep(300);
            ObjectOnField plain = new ObjectOnField();
            Thread.Sleep(300);
            ObjectOnField water = new ObjectOnField();

            while (true)
            {
                wall.DrawWall();
                apple.SetObject(1, "A");
                stone.SetObject(1, "S");
                tree.SetObject(1, "T");
                water.SetObject(1, "W");
                plain.SetObject(1, "P");
                snake.Input();
                snake.DrawSnake();
                snake.Move();
            }


        }




    }
}
