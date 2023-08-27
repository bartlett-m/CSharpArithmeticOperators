using System.Numerics;

namespace CSharpArithmeticOperators
{
	internal class Program
	{
		static void Main()
		{
			double areaCircle = ArithmeticOperators.CalcCircleArea(1.2);
			Console.WriteLine($"The area of the circle is {areaCircle}\n");

			ArithmeticOperators.Division();

			decimal eatInCost = ArithmeticOperators.CalculateEatInCost(13);
			Console.WriteLine($"The cost with VAT added is {eatInCost}\n");

			ArithmeticOperators.Remainders();

			ArithmeticOperators.Rounding();

			ArithmeticOperators.DifferentRoundingOptions(areaCircle);
		}
	}
}