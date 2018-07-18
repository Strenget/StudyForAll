using NUnit.Framework;
using System.Linq;
using System;
namespace StaticMassiveTests
{
	[TestFixture]
	public class StaticMassiveTests
	{
		[SetUp]
		public void SetUp()
		{
			//_static = new ();
		}

		//private StaticMassive _static;

		[Test]
		public void AddEvenNunbers_FromNumbersMassive()
		{
			var numbersForTest = new int[1000];
			for (var i = 0; i < 1000; i++)
			{
				numbersForTest[i] = i;
			}

			//Assert.That(numbersForTest.Where(s => s % 2 == 0).Select(s => s).ToArray().Equals(_static.AddEvenNumbers(numbersForTest)));
		}
	}
}
