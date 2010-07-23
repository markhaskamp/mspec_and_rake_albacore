using Machine.Specifications;

namespace Operand_Test
{
    [Subject("Operator")]
    public class Add
    {
        private It should_add_two_operands = () =>
                     {
                        Operand.Operand o = new Operand.Operand();
                         o.Add(42, 42).ShouldEqual(84.0m);
                     };

        private It should_add_all_operands = () =>
                     {
                         Operand.Operand o = new Operand.Operand();
                         o.Add(1m, 2m, 3m).ShouldEqual(6m);
                     };
    }
}
