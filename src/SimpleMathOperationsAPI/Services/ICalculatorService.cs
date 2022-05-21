using SimpleMathOperationsAPI.DTO;

namespace SimpleMathOperationsAPI.Services
{
    public interface ICalculatorService
    {
        Task<double> Add(double num1, double num2);
        Task<double> Subtract(double num1, double num2);
        Task<double> Multiply(double num1, double num2);
        Task<double> Divide(double num1, double num2);
        Task<IEnumerable<MathOperationResponse>> GetLatestMathOperations(int numberOfRecords);
    }
}
