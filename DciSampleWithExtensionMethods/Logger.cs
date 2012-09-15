using System;
using DciSampleWithExtensionMethods.Interactions.Roles;

namespace DciSampleWithExtensionMethods
{
    class Logger
    {
        public ConsoleColor Color { get; set; }

        public void Log(string message)
        {
            Console.ForegroundColor = Color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
