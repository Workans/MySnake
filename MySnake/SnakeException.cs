using System;

namespace MySnake
{
    public class SnakeException : ApplicationException
    {
        public SnakeException(string msg) : base(msg) { }
    }
}
