public class Program
{
	static void Main()
	{
		Console.Write("Zadejte pořadí kruhového prvočísla: ");
		int n = int.Parse(Console.ReadLine());
		int count = 0;
		int number = 2;
		while (true)
		{
			if (IsCircularPrime(number))
			{
				count++;
				if (count == n)
				{
					Console.WriteLine($"N-té kruhové prvočíslo je: {number}");
					break;
				}
			}
			number++;
		}
	}

	static bool IsCircularPrime(int number)
	{
		int temp = number;
		int digits = CountDigits(number);

		do
		{
			if (!IsPrime(number))
			{
				return false;
			}

			int remainder = number % 10;
			int div = number / 10;
			number = (int)((Math.Pow(10, digits - 1)) * remainder + div);

		} while (number != temp);

		return true;
	}

	static int CountDigits(int number)
	{
		int count = 0;
		while (number != 0)
		{
			count++;
			number = number / 10;
		}
		return count;
	}

	static bool IsPrime(int number)
	{
		if (number <= 1)
		{
			return false;
		}
		if (number == 2)
		{
			return true;
		}
		if (number % 2 == 0)
		{
			return false;
		}

		int boundary = (int)Math.Floor(Math.Sqrt(number));

		for (int i = 3; i <= boundary; i += 2)
		{
			if (number % i == 0)
			{
				return false;
			}
		}

		return true;
	}
}
