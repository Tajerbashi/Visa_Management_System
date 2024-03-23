using Blazor_Domain_Library_Test.Security.Repositories;

namespace Blazor_Domain_Library_Test.Security.Services
{
    public class CalculatorService : ICalculatorRepository
    {
        public int Sum(int a, int b) => a + b;
        public int Sub(int a, int b) => (a > b ? a - b : b - a);
        public int Multiple(int a, int b) => a * b;
        public int Divided(int a, int b) => (a > b ? a / b : b / a);
    }
}
