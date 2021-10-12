using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndTeacher
{
    public enum Operation { Plus, Minus, Multiply, Divide };

    public class Expression
    {
        private Operation operation;
        private ExpressionOperands operands;

        const double EPS = 0.00001;

        /// <summary>
        /// Expression constructor
        /// </summary>
        /// <param name="op">Operation type</param>
        /// <param name="ops">Operation operands</param>
        public Expression(Operation op, ExpressionOperands ops)
        {
            operation = op;
            operands = ops;
        }

        /// <summary>
        /// Evaluates expression using expression type and operands
        /// </summary>
        /// <returns>Expression evaluated</returns>
        public double Evaluate()
        {
            switch (operation)
            {
                case Operation.Plus:
                    return operands.Lhs + operands.Rhs;

                case Operation.Minus:
                    return operands.Lhs - operands.Rhs;

                case Operation.Multiply:
                    return operands.Lhs * operands.Rhs;

                case Operation.Divide:

                    if (WithinEps(operands.Rhs, 0, EPS))
                    {
                        throw new ArgumentException("Error! " +
                            "Unable to perform division operation, " +
                            "while right hand side operand is zero!");
                    }

                    return operands.Lhs / operands.Rhs;
            }

            return 0;
        }

        /// <summary>
        /// Checks, if two float point numbers are equal with defined epsilon.
        /// </summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        public static bool WithinEps(double lhs, double rhs, double eps)
        {
            if (Math.Abs(lhs - rhs) < eps)
            {
                return true;
            }

            return false;
        }
    }

    interface IMemorize
    {
        void Memorize(Expression expr);
    }
}
