using AlgoLabRecursion.Writers;
using System.Diagnostics;

namespace AlgoLabRecursion.Calculator
{
    internal class FactorialCalculator : IActionCalculator
    {

        int actionCounter = 0;
        int factorialValueToGet = 0;
        Stopwatch stopwatch = new Stopwatch();

		public int ActionCounter { get => actionCounter; }
		public long calculatedValue { get => factorialValueToGet; }
		public Stopwatch Stopwatch { get => stopwatch; set { stopwatch = value; } }

		IPerformanceWriter performanceWriter = Factory.CreatePerformacneWriter;

		long CalculateIterationalFactorial(int n)
        {
            stopwatch.Start();
            long suma = 1;
            if (n == 0 || n == 1)
            {
                actionCounter++;
                return 1;
            }
            for (int i = 0; i < n; i++)
            {
                suma += suma * i;
                actionCounter++;

            }
            stopwatch.Stop();
            return suma;
        }
        long CalculateRecursionFactorial(int n)
        {
            actionCounter++;
            return n <= 1 ? 1 : n * CalculateRecursionFactorial(n - 1);
        }
        public void WriteCalculations()
        {
            Console.Write("Type the factorial number that You want to calculate: ");
            if (int.TryParse(Console.ReadLine(), out factorialValueToGet))
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("Calculated value by the iteration method:");
                Console.WriteLine($"{CalculateIterationalFactorial(factorialValueToGet)}");
				performanceWriter.WritePerformance(this);
                Console.WriteLine("##############################################");
                Console.WriteLine("Calculated value by the recursion method:");
                Console.WriteLine($"{CalculateRecursionFactorial(factorialValueToGet)}");
				performanceWriter.WritePerformance(this);
            }
            else
            {
                Console.WriteLine("I think, You should check the value that was entered...");
            }
        }
	}
}
