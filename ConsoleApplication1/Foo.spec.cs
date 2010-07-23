
using System;
using Machine.Specifications;

namespace ConsoleApplication1
{
    [Subject("Operator")]
    public class Add
    {
        private It should_add_two_operands = () => new Operator().Add(42, 42).ShouldEqual(84.0m);
        private It should_add_all_operands = () =>
                             {
                                 decimal expected_value = 6m;
                                 new Operator().Add(1, 2, 3.0m).ShouldEqual(expected_value);
                             };
    }

    [Subject("Operator")]
    public class Substract
    {
        private It should_substract_second_operand_from_first_operand = () =>
                            {
                                new Operator().Substract(42, 20).ShouldEqual(22m);
                            };
    }


    public class Operator
    {
        public decimal Add(decimal firstOp, decimal secondOp) {
            return firstOp + secondOp;
        }

        public decimal Add(params decimal[] operands) {
            decimal value = 0m;

            foreach (decimal operand in operands) {
                value += operand;
            }
            return value;
        }

        public decimal Substract(decimal firstOp, decimal secondOp) {
            return firstOp - secondOp;
        }
    }
}
