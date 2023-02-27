using AlgoLabRecursion.Writers;
using System.Diagnostics;

namespace AlgoLabRecursion.Calculator
{
	public class FibonacciCalculator : IActionCalculator
	{
		int actionCounter = 0;
		int valueToGet = 0;
		long fibValue = 0;
		Stopwatch stopwatch = new Stopwatch();
		IPerformanceWriter performanceWriter = Factory.CreatePerformacneWriter;
		public int ActionCounter { get => actionCounter; }
		public long calculatedValue { get => fibValue; }
		public Stopwatch Stopwatch { get => stopwatch;}
		long CalculateIterationalFibonacci(int n)
		{
			long fibValue = 0;
			long fibFirst = 0;
			long fibSecond = 1;
			stopwatch.Start();

			for (int i = 1; i < n; i++)
			{
				fibValue = fibFirst + fibSecond;
				fibFirst = fibSecond;
				fibSecond = fibValue;
				actionCounter++;
			}
			stopwatch.Stop();

			return fibValue;
		}

		long CalculateRecursiveFibonacci(int n)
		{
			stopwatch.Start();

			if (n == 0)
			{
				actionCounter++;
				stopwatch.Stop();
				return 0;
			}
			else if (n == 1)
			{
				actionCounter++;
				stopwatch.Stop();
				return 1;
			}
			actionCounter++;
			return CalculateRecursiveFibonacci(n - 1) + CalculateRecursiveFibonacci(n - 2);
		}


		public void WriteCalculations()
		{
			if (SetValueToCalculate())
			{
				Console.WriteLine("************************************************");
				Console.WriteLine("Calculated n-th value by the iteration method:");
				Console.WriteLine($"{CalculateIterationalFibonacci(valueToGet)}");
				performanceWriter.WritePerformance(this);
				resetCurrentScores();
				Console.WriteLine("##############################################");
				Console.WriteLine("Calculated value with recursion method:");
				Console.WriteLine($"{CalculateRecursiveFibonacci(valueToGet)}");
				performanceWriter.WritePerformance(this);
			}
			else
			{
				Console.WriteLine("I think, You should check the value that was entered...");
			}

		}
		void resetCurrentScores()
		{
			actionCounter = 0;
			fibValue = 0;
		}

		bool SetValueToCalculate()
		{

			Console.Write("Type the Fibonacci n-th value that You want to calculate: ");
			if (int.TryParse(Console.ReadLine(), out valueToGet))
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}
}
