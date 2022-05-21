using SimpleMathOperationsAPI.Enums;

namespace SimpleMathOperationsAPI.DTO
{
    public class MathOperationResponse
    {
        public int Id { get; set; }
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public string MathOperator { get; set; }
    }
}
