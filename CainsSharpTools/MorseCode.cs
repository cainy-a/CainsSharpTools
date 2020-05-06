using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CainsSharpTools
{
	public class MorseCode
	{
		/// <summary>
		/// The constructor for the MorseCode class.
		/// </summary>
		/// <param name="value">The value to initialise the object with</param>
		/// <param name="encode">Whether or not to encode the input as if it was plaintext.</param>
		public MorseCode(string value, bool encode = true)
		{ 
			if (encode) Value = Parse(value).Value;
			else Value = value;
		}

		/// <summary>
		/// This list contains all of the plaintext characters that can be translated into Morse Code
		/// </summary>
		static readonly List<char> AllowedMorseChars = new List<char>
		{
			'a', 'b', 'c',
			'd', 'e', 'f',
			'g', 'h', 'i',
			'j', 'k', 'l',
			'm', 'n', 'o',
			'p', 'q', 'r',
			's', 't', 'u',
			'v', 'w', 'x',
			'y', 'z',
			
			'1', '2', '3',
			'4', '5', '6',
			'7', '8', '9',
			'0',

			'.', ',', '?',
			'\'', '!', '/',
			':', ';', '=',
			'+', '-', '_',
			'"', '@'
		};
		
		/// <summary>
		/// The Encoded MorseCode message, but in string format.
		/// </summary>
		public string Value;
		/// <summary>
		/// Gets the value. You can also directly access the "value" member.
		/// </summary>
		/// <returns></returns>
		public override string ToString() => Value;
		/// <summary>
		/// Gets the Length of the decoded message.
		/// </summary>
		/// <returns>The length of the decoded message.</returns>
		public int Length()
			=> PlainText().Length;

		/// <summary>
		/// Creates a MorseCode object out of a string.
		/// </summary>
		/// <param name="plaintext">The plaintext to convert to Morse Code</param>
		/// <returns>A MorseCode object</returns>
		/// <exception cref="ArgumentOutOfRangeException">The character entered was acceptable.</exception>
		public static MorseCode Parse(string plaintext)
		{
			StringBuilder sb = new StringBuilder();

			foreach (var letter in plaintext)
			{
				if (!AllowedMorseChars.Contains(char.Parse(letter.ToString().ToLower())) && letter != ' ')
					throw new ArgumentOutOfRangeException(); // Rogue characters!
			}
			
			foreach (var letter in plaintext)
			{
				if (letter == ' ') continue;
				
				switch (letter.ToString().ToLower())
				{
					case "a":
						sb.Append(".-");
						break;
					case "b":
						sb.Append("-...");
						break;
					case "c":
						sb.Append("-.-.");
						break;
					case "d":
						sb.Append("-..");
						break;
					case "e":
						sb.Append(".");
						break;
					case "f":
						sb.Append("..-.");
						break;
					case "g":
						sb.Append("--.");
						break;
					case "h":
						sb.Append("....");
						break;
					case "i":
						sb.Append("..");
						break;
					case "j":
						sb.Append(".---");
						break;
					case "k":
						sb.Append("-.-");
						break;
					case "l":
						sb.Append(".-..");
						break;
					case "m":
						sb.Append("--");
						break;
					case "n":
						sb.Append("-.");
						break;
					case "o":
						sb.Append("---");
						break;
					case "p":
						sb.Append(".--.");
						break;
					case "q":
						sb.Append("--.-");
						break;
					case "r":
						sb.Append(".-.");
						break;
					case "s":
						sb.Append("...");
						break;
					case "t":
						sb.Append("-");
						break;
					case "u":
						sb.Append("..-");
						break;
					case "v":
						sb.Append("...-");
						break;
					case "w":
						sb.Append(".--");
						break;
					case "x":
						sb.Append("-..-");
						break;
					case "y":
						sb.Append("-.--");
						break;
					case "z":
						sb.Append("--..");
						break;
					
					case "1":
						sb.Append(".----");
						break;
					case "2":
						sb.Append("..---");
						break;
					case "3":
						sb.Append("...--");
						break;
					case "4":
						sb.Append("....-");
						break;
					case "5":
						sb.Append(".....");
						break;
					case "6":
						sb.Append("-....");
						break;
					case "7":
						sb.Append("--...");
						break;
					case "8":
						sb.Append("---..");
						break;
					case "9":
						sb.Append("----.");
						break;
					case "0":
						sb.Append("-----");
						break;

					case ".":
						sb.Append(".-.-.-");
						break;
					case ",":
						sb.Append("--..--");
						break;
					case "?":
						sb.Append("..--..");
						break;
					case "\'":
						sb.Append(".----.");
						break;
					case "!":
						sb.Append("-.-.--");
						break;
					case "/":
						sb.Append("-..-.");
						break;
					case ":":
						sb.Append("---...");
						break;
					case ";":
						sb.Append("-.-.-.");
						break;
					case "=":
						sb.Append("-...-");
						break;
					case "+":
						sb.Append(".-.-.");
						break;
					case "-":
						sb.Append("-....-");
						break;
					case "_":
						sb.Append("..--.-");
						break;
					case "\"":
						sb.Append(".-..-.");
						break;
					case "@":
						sb.Append(".--.-.");
						break;
				}

				sb.Append(" ");
			}

			return new MorseCode(sb.ToString().Trim(), false);
		}
		/// <summary>
		/// Attempts to create a MorseCode object out of a string.
		/// </summary>
		/// <param name="plaintext">The plaintext to convert to Morse Code</param>
		/// <param name="result">A MorseCode object</param>
		/// <returns>Whether or not the Parsing failed.</returns>
		public static bool TryParse(string plaintext, out MorseCode result)
		{
			try
			{
				result = Parse(plaintext);
				return true;
			}
			catch
			{
				result = new MorseCode(string.Empty);
				return false;
			}
		}

		/// <summary>
		/// Decodes myself.
		/// </summary>
		/// <returns>The plain text of the Morse Code.</returns>
		public string PlainText() => PlainText(this);
		/// <summary>
		/// Decodes a MorseCode to a plaintext string.
		/// </summary>
		/// <param name="morseCode">The MorseCode object to decode.</param>
		/// <returns>The decoded plaintext string.</returns>
		public static string PlainText(MorseCode morseCode)
		{
			StringBuilder sb = new StringBuilder();
			var substrings = new List<string>();
			
			for (int i = 0; i < morseCode.Value.Length; i++)
			{
				StringBuilder workingSb = new StringBuilder();
				while (morseCode.Value[i] == ' ')
				{
					workingSb.Append(morseCode.Value[i]);
					i++;
				}
				substrings.Add(workingSb.ToString());
			} // Separate into bits of strings
			
			foreach (var encodedChar in substrings)
			{
				switch (encodedChar.ToString().Trim())
				{
					case ".-":
						sb.Append("a");
						break;
					case "-...":
						sb.Append("b");
						break;
					case "-.-.":
						sb.Append("c");
						break;
					case "-..":
						sb.Append("d");
						break;
					case ".":
						sb.Append("e");
						break;
					case "..-.":
						sb.Append("f");
						break;
					case "--.":
						sb.Append("g");
						break;
					case "....":
						sb.Append("h");
						break;
					case "..":
						sb.Append("i");
						break;
					case ".---":
						sb.Append("j");
						break;
					case "-.-":
						sb.Append("k");
						break;
					case ".-..":
						sb.Append("l");
						break;
					case "--":
						sb.Append("m");
						break;
					case "-.":
						sb.Append("n");
						break;
					case "---":
						sb.Append("o");
						break;
					case ".--.":
						sb.Append("p");
						break;
					case "--.-":
						sb.Append("q");
						break;
					case ".-.":
						sb.Append("r");
						break;
					case "...":
						sb.Append("s");
						break;
					case "-":
						sb.Append("t");
						break;
					case "..-":
						sb.Append("u");
						break;
					case "...-":
						sb.Append("v");
						break;
					case ".--":
						sb.Append("w");
						break;
					case "-..-":
						sb.Append("x");
						break;
					case "-.--":
						sb.Append("y");
						break;
					case "--..":
						sb.Append("z");
						break;
					
					case ".----":
						sb.Append("1");
						break;
					case "..---":
						sb.Append("2");
						break;
					case "...--":
						sb.Append("3");
						break;
					case "....-":
						sb.Append("4");
						break;
					case ".....":
						sb.Append("5");
						break;
					case "-....":
						sb.Append("6");
						break;
					case "--...":
						sb.Append("7");
						break;
					case "---..":
						sb.Append("8");
						break;
					case "----.":
						sb.Append("9");
						break;
					case "-----":
						sb.Append("0");
						break;
					
					case ".-.-.-":
						sb.Append(".");
						break;
					case "--..--":
						sb.Append(",");
						break;
					case "..--..":
						sb.Append("?");
						break;
					case ".----.":
						sb.Append("\'");
						break;
					case "-.-.--":
						sb.Append("!");
						break;
					case "-..-.":
						sb.Append("/");
						break;
					case "---...":
						sb.Append(":");
						break;
					case "-.-.-.":
						sb.Append(";");
						break;
					case "-...-":
						sb.Append("=");
						break;
					case ".-.-.":
						sb.Append("+");
						break;
					case "-....-":
						sb.Append("-");
						break;
					case "..--.-":
						sb.Append("_");
						break;
					case ".-..-.":
						sb.Append("\"");
						break;
					case ".--.-.":
						sb.Append("@");
						break;
				}
			}

			return sb.ToString();
		}
	}
}