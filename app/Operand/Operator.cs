﻿
using System;

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
            if (operands == null) {
                throw new ArgumentException("no operands were passed in to Subtract method");
            }

            if (operands.Length == 1) {
                throw new ArgumentException("no operands were passed in to Subtract method");
            }

            decimal value = operands[0];
            for (int i=1; i<operands.Length; i++) {
                value -= operands[i];
            }
            return value;
        }
    }
}
