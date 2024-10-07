using MathCalculatorAPI.Interfaces;

namespace MathCalculatorAPI.Services
{
    public class CalculatorService : ICalculatorService
    {
        public T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public T Subtract<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        public T Multiply<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }

        public T Divide<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }
}
