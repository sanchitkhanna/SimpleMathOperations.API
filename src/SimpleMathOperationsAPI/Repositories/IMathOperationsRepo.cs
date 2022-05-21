using SimpleMathOperationsAPI.Entities;

namespace SimpleMathOperationsAPI.Repositories
{
    public interface IMathOperationsRepo
    {
        Task<IEnumerable<MathOperation>> GetLatestMathOperationsAsync(int numberOfRecords);

        Task<MathOperation> CreateMathOperationAsync(MathOperation mathOperation);
    }
}
