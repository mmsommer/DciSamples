using System;

namespace DciSampleWithStrategyPattern
{
    class Logger
    {
        public ConsoleColor Color { get; set; }

        public void Log(string message)
        {
            Console.ForegroundColor = this.Color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
