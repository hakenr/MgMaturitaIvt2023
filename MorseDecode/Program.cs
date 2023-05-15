public class MorseCode
{
	private static readonly Dictionary<string, char> MorseAlphabet = new Dictionary<string, char>
	{
		{".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'}, {"..-.", 'F'},
		{"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'},
		{"--", 'M'}, {"-.", 'N'}, {"---", 'O'}, {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'},
		{"...", 'S'}, {"-", 'T'}, {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'},
		{"-.--", 'Y'}, {"--..", 'Z'}
	};

	public static void Main()
	{
		string morseCode = "...";
		var results = new List<string>();
		DecodeMorse(morseCode, "", results);
		Console.WriteLine("Number of possible messages: " + results.Count);
		Console.WriteLine("Possible messages:");
		foreach (var message in results)
		{
			Console.WriteLine(message);
		}
	}

	private static void DecodeMorse(string remainingMorse, string currentMessage, List<string> results)
	{
		if (remainingMorse.Length == 0)
		{
			results.Add(currentMessage);
			return;
		}

		for (int i = 1; i <= remainingMorse.Length; i++)
		{
			string part = remainingMorse.Substring(0, i);
			if (MorseAlphabet.ContainsKey(part))
			{
				string newMessage = currentMessage + MorseAlphabet[part];
				string newRemainingMorse = remainingMorse.Substring(i);
				DecodeMorse(newRemainingMorse, newMessage, results);
			}
		}
	}
}
