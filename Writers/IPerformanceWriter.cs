using AlgoLabRecursion.Calculator;

namespace AlgoLabRecursion.Writers
{
	public interface IPerformanceWriter
	{
		public void WritePerformance(IActionCalculator actionCalculator);
	}
}