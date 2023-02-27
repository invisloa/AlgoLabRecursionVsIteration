using AlgoLabRecursion.Writers;
using System.Diagnostics;

namespace AlgoLabRecursion.Calculator
{
	public interface IActionCalculator
    {
        int ActionCounter { get; }
        long calculatedValue { get; }
        Stopwatch Stopwatch { get; set; }
        public void WriteCalculations();
	}
}