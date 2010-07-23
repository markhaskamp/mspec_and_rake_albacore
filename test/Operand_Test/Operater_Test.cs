using System;
using Machine.Specifications;
using Operand;

namespace Operand_Test
{
    [Subject("Operator")]
    public class Add
    {
        private It should_add_two_operands = () =>
                     {
                        Operator o = new Operator();
                         o.Add(42, 42).ShouldEqual(84.0m);
                     };

        private It should_add_all_operands = () =>
                     {
                         Operator o = new Operator();
                         o.Add(1m, 2m, 3m).ShouldEqual(6m);
                     };
    }

    public class Substract
    {
        private It should_subtract_second_operand_from_first_operand = () =>
                                                   new Operator().Subtract(42, 20).ShouldEqual(22m);

        private It should_subtract_all_operands_from_the_first_operand = () =>
                new Operator().Subtract(10m, 1, 2, 3).ShouldEqual(4m);


    }

    [Subject("Subtract")]
    public class matching_for_exceptions_in_mspec_is_a_hack
    {
        private static Exception Exception;

        private Because of = () =>
                             Exception = Catch.Exception(() => new Operator().Subtract(10m));

        private It with_0_operands_Subtract_will_throw_ArgumentException = () => 
            Exception.ShouldBeOfType<ArgumentException>();

        private It with_1_operand_Subtract_will_throw_ArgumentException = () => 
            Exception.ShouldBeOfType<ArgumentException>();

    }
}
