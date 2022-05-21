using SimpleMathOperationsAPI.Enums;

namespace SimpleMathOperationsAPI.Entities
{
    public class MathOperation: BaseEntity
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public Operator Operator { get; set; }
    }
}
