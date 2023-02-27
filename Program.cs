using AlgoLabRecursion;
using AlgoLabRecursion.Calculator;
using System.Diagnostics;


IActionCalculator factCalculator = Factory.CreateFactorialCalculator;
IActionCalculator fibCalculator = Factory.CreateFibonacciCalculator;
factCalculator.WriteCalculations();
fibCalculator.WriteCalculations();