using AutoMapper;
using SimpleMathOperationsAPI.DTO;
using SimpleMathOperationsAPI.Entities;
using SimpleMathOperationsAPI.Repositories;

namespace SimpleMathOperationsAPI.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IMathOperationsRepo _mathOperationsRepo;
        private readonly IMapper _mapper;

        public CalculatorService(IMathOperationsRepo mathOperationsRepo, IMapper mapper)
        {
            this._mathOperationsRepo = mathOperationsRepo;
            this._mapper = mapper;
        }
        public async Task<double> Add(double num1, double num2)
        {
            MathOperation mathOperation = new MathOperation()
            {
                Number1 = num1,
                Number2 = num2,
                Operator = Enums.Operator.Add,
                Result = num1 + num2
            };
            await _mathOperationsRepo.CreateMathOperationAsync(mathOperation);
            return mathOperation.Result;
        }

        public async Task<double> Divide(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException();
            MathOperation mathOperation = new MathOperation()
            {
                Number1 = num1,
                Number2 = num2,
                Operator = Enums.Operator.Divide,
                Result = num1/ num2
            };
            await _mathOperationsRepo.CreateMathOperationAsync(mathOperation);
            return mathOperation.Result;
        }

        public async Task<double> Multiply(double num1, double num2)
        {
            MathOperation mathOperation = new MathOperation()
            {
                Number1 = num1,
                Number2 = num2,
                Operator = Enums.Operator.Multiply,
                Result = num1 * num2
            };
            await _mathOperationsRepo.CreateMathOperationAsync(mathOperation);
            return mathOperation.Result;
        }

        public async Task<double> Subtract(double num1, double num2)
        {
            MathOperation mathOperation = new MathOperation()
            {
                Number1 = num1,
                Number2 = num2,
                Operator = Enums.Operator.Subtract,
                Result = num1 - num2
            };
            await _mathOperationsRepo.CreateMathOperationAsync(mathOperation);
            return mathOperation.Result;
        }

        public async Task<IEnumerable<MathOperationResponse>> GetLatestMathOperations(int numberOfRecords)
        {
            return _mapper.Map<IEnumerable<MathOperationResponse>>(await _mathOperationsRepo.GetLatestMathOperationsAsync(numberOfRecords));
        }
    }
}
