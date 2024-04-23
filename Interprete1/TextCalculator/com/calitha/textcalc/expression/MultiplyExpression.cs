using System;

namespace com.calitha.textcalc.expression
{

	public class MultiplyExpression : BinaryExpression
	{
		public MultiplyExpression(Expression left, Expression right)
			: base(left, right)
		{
		}

		public override int Evaluate(int left, int right)
		{
			return left * right;
		}

		public override double Evaluate(double left, double right)
		{
			return left * right;
		}

	}
}
