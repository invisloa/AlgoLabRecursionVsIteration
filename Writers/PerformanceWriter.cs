using AlgoLabRecursion.Calculator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLabRecursion.Writers
{
	internal class PerformanceWriter : IPerformanceWriter
	{
		public void WritePerformance(IActionCalculator actionCalculator)
		{
			Console.WriteLine($"Elapsed time: {actionCalculator.Stopwatch.Elapsed.TotalMilliseconds} milliseconds");
			Console.WriteLine($"Number of actions taken:{actionCalculator.ActionCounter} \n \n");
			actionCalculator.Stopwatch.Reset();
		}
	}
}
