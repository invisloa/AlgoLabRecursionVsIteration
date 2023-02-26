using System.Runtime.CompilerServices;

int actionCounter = 0;
long fibValue = 0;
int factorialValue = 0;
int fibonacciValue = 0;

void TypeActionsTakenValue()
	{
	Console.WriteLine($"Number of actions taken by the iteration method:{actionCounter} \n \n");
	actionCounter = 0;
	}
long CalculateIterationalFactorial(int n)
{
	long suma = 1;
	if (n == 0 || n == 1)
	{
		return 1;
		actionCounter++;
	}
	else
	{
		for (int i = 0; i < n; i++)
		{
			suma += suma * i;
			actionCounter++;

		}
		return suma;
	}
}
long CalculateRecursionFactorial(int n)
{
	actionCounter++;
	return n <= 1 ? 1 : n * CalculateRecursionFactorial(n - 1);
}

long CalculateIterationalFibonacci(int n)
{
	long fibValue = 0;
	long fibFirst = 0;
	long fibSecond = 1;
	for (int i = 1; i < n; i++)
	{
		fibValue =  fibFirst + fibSecond;
		fibFirst = fibSecond;
		fibSecond = fibValue;
		actionCounter++;
	}
	return fibValue;
}

long CalculateRecursiveFibonacci(int n)
{
	if (n == 0)
	{
		actionCounter++;

		return 0;
	}
	else if (n == 1)
	{
		actionCounter++;

		return 1;
	}
	actionCounter++;
	return CalculateRecursiveFibonacci(n - 1) + CalculateRecursiveFibonacci(n - 2);
}

Console.WriteLine("Type the factorial number that You want to calculate:");
Int32.TryParse(Console.ReadLine(), out factorialValue);
Console.WriteLine("Calculated value by the iteration method:");
Console.WriteLine($"{CalculateIterationalFactorial(factorialValue)}");
TypeActionsTakenValue();
Console.WriteLine("Calculated value by the recursion method:");
Console.WriteLine($"{CalculateRecursionFactorial(factorialValue)}");
TypeActionsTakenValue();


Console.WriteLine("Type the Fibonacci n-th value that You want to calculate:");
Int32.TryParse(Console.ReadLine(), out fibonacciValue);
Console.WriteLine("Calculated n-th value by the iteration method:");
Console.WriteLine($"{CalculateIterationalFibonacci(fibonacciValue)}");
TypeActionsTakenValue();
Console.WriteLine("Calculated value with recursion method:");
Console.WriteLine($"{CalculateRecursiveFibonacci(fibonacciValue)}");
TypeActionsTakenValue();
