using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleMathOperationsAPI.DTO;
using SimpleMathOperationsAPI.Entities;
using SimpleMathOperationsAPI.Enums;
using SimpleMathOperationsAPI.Repositories;
using SimpleMathOperationsAPI.Services;

namespace SimpleMathOperationsAPI.Controllers
{
    [Route("api/calculator")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(MathOperationRequest mathOperationRequest)
        {
            return Ok(await _calculatorService.Add(mathOperationRequest.Num1, mathOperationRequest.Num2));

        }

        [HttpPost("subtract")]
        public async Task<IActionResult> Subtract(MathOperationRequest mathOperationRequest)
        {
            return Ok(await _calculatorService.Subtract(mathOperationRequest.Num1, mathOperationRequest.Num2));

        }

        [HttpPost("multiply")]
        public async Task<IActionResult> Multiply(MathOperationRequest mathOperationRequest)
        {
            return Ok(await _calculatorService.Multiply(mathOperationRequest.Num1, mathOperationRequest.Num2));

        }

        [HttpPost("divide")]
        public async Task<IActionResult> Divide(MathOperationRequest mathOperationRequest)
        {
            return Ok(await _calculatorService.Divide(mathOperationRequest.Num1, mathOperationRequest.Num2));

        }

        [HttpGet("getlatesttenmathoperations")]
        public async Task<IActionResult> GetLatestTenMathOperations()
        {
            return Ok(await _calculatorService.GetLatestMathOperations(10));

        }

    }
}
