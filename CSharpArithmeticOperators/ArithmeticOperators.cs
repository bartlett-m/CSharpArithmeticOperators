using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArithmeticOperators
{
	public class ArithmeticOperators
	{
		internal static int blocksize = 512;
		public static double CalcCircleCircumference(double radius)
		{
			return Math.PI * 2 * radius;
		}
		public static double CalcCircleArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2); // User Math.Pow to raise a number to a power
		}
		public static bool IsDivisibleBy(int n1, int n2)
		{
			return (n1 % n2) == 0;
		}
		public static double CalcHypotenuse(double a, double b)
		{
			return (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
		}
		public static void CalcBookSharing()
		{
			Console.Write("Enter the number of students\n>");
			int n_students = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the number of books\n>");
			int n_books = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Each student gets {n_books/n_students} book(s).  There will be {n_books % n_students} book(s) left over.");
		}
		public static int CalcNumBlocks(int n_KiB)
		{
			int n_blocks = (n_KiB*1024)/blocksize;
			if ((n_KiB*1024)%blocksize != 0) {
				n_blocks++;
			}
			return n_blocks;
		}
		public static void CalcSavings()
		{
			Console.Write("Enter the total amount of pocket money earned each week\n>");
			decimal amount_earned = Convert.ToDecimal(Console.ReadLine());
			Console.Write("Enter the percentage which you want to save each week\n>");
			decimal percentage_saved_as_decimal = Convert.ToDecimal(Console.ReadLine())/100;
			decimal amount_saved_per_week = amount_earned*percentage_saved_as_decimal;
			Console.WriteLine($"Each week you will save {amount_saved_per_week}.  After a year, you will have {amount_saved_per_week*52}.");
		}

		public static void Division()
		{
			int numA = 10;
			int numB = 3;

			// Dividing integers A
			// Integer division or DIV in C Sharp is just division where both numbers are integral types 
			double numC = numA / numB;
			Console.WriteLine($"When both numbers are integers: {numA} / {numB} is {numC}.");

			// Dividing integers B
			numC = numA / (double)numB;
			Console.WriteLine($"When one number is converted to a double: {numA} / {(double)numB} is {numC}.");

			Console.WriteLine();
		}

		
		// Constants are used for values that will not change whilst the program is running.
		public const decimal VatRate = 0.2m;

		public static decimal CalculateEatInCost(decimal foodCost)
		{
			return foodCost * (1 + VatRate);
		}

		public static void Remainders()
		{
			int numA = 10;
			int numB = 3;

			int remainder = numA % numB;
			Console.WriteLine($"The remainder of {numA} / {numB} (integers) is {remainder}.");

			double numC = 10.0;
			double numD = 4.4;

			double remainder2 = numC % numD;
			Console.WriteLine($"The remainder of {numC} / {numD} (doubles) is {remainder2}.");

			decimal numE = 10.0m;
			decimal numF = 4.4m;

			// We can avoid rounding errors by using the decimal data type
			// This is one of the reasons it is well suited to financial calculations
			decimal remainder3 = numE % numF;
			Console.WriteLine($"The remainder of {numE} / {numF} (decimals) is {remainder3}.");

			Console.WriteLine();
		}

		// At a midpoint Math.Round rounds to the nearest even number
		public static void Rounding()
		{
			double num1 = 12.5;
			Console.WriteLine($"{num1} rounded is {Math.Round(num1)}");

			double num2 = 13.5;
			Console.WriteLine($"{num2} rounded is {Math.Round(num2)}");

			Console.WriteLine();
		}

		// There are different options to round in c#
		public static void DifferentRoundingOptions(double number)
		{
			double roundedNumber = Math.Round(number);
			Console.WriteLine($"{number} rounded is {roundedNumber}");

			// Floor gives the nearest integral number that is lower
			double flooredNumber = Math.Floor(number);
			Console.WriteLine($"{number} floored is {flooredNumber}");

			// Ceiling gives the nearest integral number that is higher
			double ceilingNumber = Math.Ceiling(number);
			Console.WriteLine($"{number} ceiling is {ceilingNumber}");

			// Truncate gives the nearest integral number that is closer to zero
			double truncatedNumber = Math.Truncate(number);
			Console.WriteLine($"{number} truncated is {truncatedNumber}");

			Console.WriteLine();
		}
	}
}
