using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndTeacher
{
    public class ExpressionOperands
    {
        public int Lhs { get; }
        public int Rhs { get; }

        /// <summary>
        /// Constructor for AnswerOperands
        /// </summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        public ExpressionOperands(int lhs, int rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }
    }

    interface IAnswer
    {
        int Answer(ExpressionOperands operands);
    }
}
