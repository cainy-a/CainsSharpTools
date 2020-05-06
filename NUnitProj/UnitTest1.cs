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
		public void HelloEncodeTest() =>
			Assert.AreEqual(
				".... . .-.. .-.. ---",
				MorseCode.Parse("Hello").Value);
		
		[Test]
		public void HelloDecodeTest() =>
			Assert.AreEqual(
				"hello",
				new MorseCode(".... . .-.. .-.. ---", false).PlainText());
	}
}