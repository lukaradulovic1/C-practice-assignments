using System;

namespace Interfaces
{
    public interface ICalculator
    {
        public void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
