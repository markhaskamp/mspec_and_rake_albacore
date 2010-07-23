using Machine.Specifications;

namespace Operand_Test
{
    [Subject("Operator")]
    public class Add
    {
        private It should_add_two_operands = () => new Operand.Operand().Add(42, 42).ShouldEqual(84.0m);
    }
}
