using AlgoLabRecursion.Calculator;
using AlgoLabRecursion.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLabRecursion
{
	public static class Factory
	{
		public static IPerformanceWriter CreatePerformacneWriter { get => new PerformanceWriter(); }
		public static IActionCalculator CreateFactorialCalculator { get => new FactorialCalculator(); }
		public static IActionCalculator CreateFibonacciCalculator { get => new FibonacciCalculator(); }


	}
}
