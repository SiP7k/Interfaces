using System;
using System.Threading;

namespace HW2
{
    class Calculator : ISum
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Sum(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Ответ: {firstNumber + secondNumber}");
        }
        public void Calculate()
        {
            int count = 1;

            try
            {
                int firstNumber = Int32.Parse(TakeUserInput(ref count));
                int secondNumber = Int32.Parse(TakeUserInput(ref count));
                Logger.Event("Калькулятор проводит вычисления...");
                Thread.Sleep(3000);
                Logger.Event("Калькулятор закончил вычисления...");
                Sum(firstNumber, secondNumber);
            }
            catch
            {
                Logger.Error("Введено некорректное значение для слагаемого");
            }
        }
        private string TakeUserInput(ref int count)
        {
            Console.WriteLine($"Введите {count}-ое слагаемое: ");
            count++;
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
