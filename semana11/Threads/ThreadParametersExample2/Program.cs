using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Threading.Tasks;
namespace ThreadParametersExample2
{
	public class DivisionProblem
	{
		public double Dividend { get; set; } // the top
		public double Divisor { get; set; } // the bottom
		public double Quotient { get; set; } // the result (normally would be returned)
	}
	class Program
	{
		static void Main(string[] args)
		{
			Thread thread = new Thread(Divide);
			DivisionProblem problem = new DivisionProblem();
			problem.Dividend = 8;
			problem.Divisor = 2;
			thread.Start(problem);
			thread.Join();
			Console.WriteLine("Result: " + problem.Quotient);
			Console.ReadKey();
		}
		public static void Divide(object input)
		{
			DivisionProblem problem = (DivisionProblem)input;
			problem.Quotient = problem.Dividend / problem.Divisor;
		}
	}
}
