public class Program
{
	static List<int> GenerateFibonacciSequence(int n)
	{
		List<int> fibonacci = new List<int> { 0, 1 };
		while (true)
		{
			int nextNumber = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
			if (nextNumber > n)
			{
				break;
			}
			fibonacci.Add(nextNumber);
		}
		return fibonacci;
	}

	static List<int> FindFibonacciSum(int n)
	{
		List<int> fibonacci = GenerateFibonacciSequence(n);
		List<int> result = new List<int>();

		for (int i = fibonacci.Count - 1; i > 0; i--)
		{
			if (fibonacci[i] <= n)
			{
				result.Add(fibonacci[i]);
				n -= fibonacci[i];
				i = i - 1; // optimalizace - víme, že žádné dvě po sobě jdoucí čísla v posloupnosti nemůžou být součástí výsledku
			}
		}

		return result;
	}

	static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		List<int> result = FindFibonacciSum(n);
		Console.WriteLine("Fibonacci representation of the number is:");
		foreach (var num in result)
		{
			Console.Write(num + " ");
		}
	}
}

/* 
 * Příklady:
 *	1111=987+89+34+1
 *	71=55+13+3
 *	64 = 55 + 8 + 1
 *	
 * Alternativní název: Zeckendorf Representation (Zeckendorfova reprezentace)
 *  
 */