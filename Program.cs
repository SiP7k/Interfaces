using System;

namespace HW2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] agrs)
        {
            Logger = new Logger();
            var calculator = new Calculator(Logger);

            calculator.Calculate();
            
            
        }
        
        
    }
    public interface ISum
    {
        public void Sum(){}
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
