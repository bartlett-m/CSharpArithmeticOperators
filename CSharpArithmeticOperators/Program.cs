using System;
using System.Numerics;

namespace CSharpArithmeticOperators
{
	internal class Program
	{
		static void Main()
		{
			double circumferenceCircle = ArithmeticOperators.CalcCircleCircumference(1.2);
			Console.WriteLine($"The circumference of the circle is {Math.Round(circumferenceCircle, 2, MidpointRounding.AwayFromZero)}");

			double areaCircle = ArithmeticOperators.CalcCircleArea(1.2);
			Console.WriteLine($"The area of the circle is {Math.Round(areaCircle, 2, MidpointRounding.AwayFromZero)}");

			Console.WriteLine(ArithmeticOperators.IsDivisibleBy(8, 4));

			Console.WriteLine(ArithmeticOperators.CalcHypotenuse(3d, 4d));

			ArithmeticOperators.Division();

			decimal eatInCost = ArithmeticOperators.CalculateEatInCost(13);
			Console.WriteLine($"The cost with VAT added is {eatInCost}");

			ArithmeticOperators.Remainders();

			ArithmeticOperators.Rounding();

			ArithmeticOperators.CalcBookSharing();

			Console.WriteLine(ArithmeticOperators.CalcNumBlocks(1024));

			ArithmeticOperators.CalcSavings();

			ArithmeticOperators.DifferentRoundingOptions(areaCircle);
		}
	}
}