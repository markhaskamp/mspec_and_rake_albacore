
namespace Operand
{
    public class Operator
    {
        public decimal Add(params decimal[] operands) {
            decimal returnValue = 0m;
            foreach (decimal operand in operands) {
                returnValue += operand;
            }
            return returnValue;
        }

        public decimal Subtract(params decimal[] operands) {
            decimal value = operands[0];
            for (int i=1; i<operands.Length; i++) {
                value -= operands[i];
            }
            return value;
        }
    }
}
