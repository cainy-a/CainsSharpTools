using NUnit.Framework;
using CainsSharpTools;
using static CainsSharpTools.Misc;

namespace NUnitProj
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void HelloTest()
			=> Assert.AreEqual(
				".... . .-.. .-.. ---",
				MorseCode.Parse("Hello").Value);
	}
}