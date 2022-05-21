using Microsoft.EntityFrameworkCore;
using SimpleMathOperationsAPI.Data;
using SimpleMathOperationsAPI.Entities;

namespace SimpleMathOperationsAPI.Repositories
{
    public class MathOperationsRepo : IMathOperationsRepo
    {
        private readonly MathOperationsDbContext _dbContext;

        public MathOperationsRepo(MathOperationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<MathOperation> CreateMathOperationAsync(MathOperation mathOperation)
        {
            await _dbContext.MathOperations.AddAsync(mathOperation);
            await _dbContext.SaveChangesAsync();

            return mathOperation;
        }

        public async Task<IEnumerable<MathOperation>> GetLatestMathOperationsAsync(int numberOfRecords)
        {
            return await _dbContext.MathOperations.OrderByDescending(x => x.Id).Take(numberOfRecords).ToListAsync();
        }
    }
}
