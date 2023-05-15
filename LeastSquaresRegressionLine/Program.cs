using System;

public class Program
{
	public static void Main()
	{
		// Trénovací data
		double[][] data = new double[][]
		{
			new double[] {1, 3},
			new double[] {2, 5},
			new double[] {3, 7},
			new double[] {4, 9},
			new double[] {5, 11}
		};

		double sumX = 0, sumY = 0, sumX2 = 0, sumXY = 0;
		int n = data.Length;

		foreach (var pair in data)
		{
			sumX += pair[0];
			sumY += pair[1];
			sumX2 += pair[0] * pair[0];
			sumXY += pair[0] * pair[1];
		}

		// Výpočet směrnice a a úseku průsečíku b
		double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
		double b = (sumY - a * sumX) / n;

		Console.WriteLine($"Model: y = {a}x + {b}");

		// Predikce pro novou hodnotu x
		double newX = 6;
		double predictedY = a * newX + b;

		Console.WriteLine($"Predikce pro x={newX}: y = {predictedY}");
	}
}
