using Microsoft.EntityFrameworkCore;
using SimpleMathOperationsAPI.Entities;

namespace SimpleMathOperationsAPI.Data
{
    public class MathOperationsDbContext: DbContext
    {
        public MathOperationsDbContext(DbContextOptions<MathOperationsDbContext> dbContextOptions): base(dbContextOptions)
        {

        }
        public DbSet<MathOperation> MathOperations { get; set; }
    }
}
