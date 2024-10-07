using MathCalculatorAPI.Interfaces;

namespace MathCalculatorAPI.Services
{
    public class CalculatorService : ICalculatorService<int>
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b) => a / b;
    }
}


