
namespace Operand
{
    public class Operand
    {
        public decimal Add(decimal firstOp, decimal secondOp) {
            return firstOp + secondOp;
        }

        public decimal Add(params decimal[] operands) {
            decimal returnValue = 0m;
            foreach (decimal operand in operands) {
                returnValue += operand;
            }
            return returnValue;
        }
    }
}
