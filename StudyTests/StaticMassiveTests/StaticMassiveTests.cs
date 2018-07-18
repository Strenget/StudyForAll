using System;
using NUnit.Framework;
using System.Linq;

namespace StaticMassiveTests
{
	[TestFixture]
	public class StaticMassiveTests
	{
		[SetUp]
		public void SetUp()
		{
			_static = new StaticMassive();
		}

		private StaticMassive _static;

		[Test]
		public void AddEvenNumbers_FromNumbersMassive_OneThousand()
		{
			var numbersForTest = new int[1000];
			for (var i = 0; i < 1000; i++)
			{
				numbersForTest[i] = i;
			}

			Assert.That(numbersForTest.Where(s => s % 2 == 0).Select(s => s).ToArray(), Is.EqualTo(_static.AddEvenNumbers(numbersForTest)));
		}

		[Test]
		public void AddEvenNumbers_FromNumbersMassive_TenThousand()
		{
			var numbersForTest = new int[10000];
			for (var i = 0; i < 10000; i++)
			{
				numbersForTest[i] = i;
			}

			Assert.That(numbersForTest.Where(s => s % 2 == 0).Select(s => s).ToArray(), Is.EqualTo(_static.AddEvenNumbers(numbersForTest)));
		}

		[Test]
		public void AddEvenNumbers_FromNumbersMassive_Billion()
		{
			var numbersForTest = new int[1000000];
			for (var i = 0; i < 1000000; i++)
			{
				numbersForTest[i] = i;
			}

			Assert.That(numbersForTest.Where(s => s % 2 == 0).Select(s => s).ToArray(), Is.EqualTo(_static.AddEvenNumbers(numbersForTest)));
		}

		[Test]
		public void AddOddNumbers_FromNumbersMassive_OneThousand()
		{
			var numbersForTest = new int[1000];
			for (var i = 0; i < 1000; i++)
			{
				numbersForTest[i] = i;
			}

			Assert.That(numbersForTest.Where(s => s % 2 != 0).Select(s => s).ToArray(), Is.EqualTo(_static.AddOddNumbers(numbersForTest)));
		}

		[Test]
		public void AddOddNumbers_FromNumbersMassive_TenThousand()
		{
			var numbersForTest = new int[10000];
			for (var i = 0; i < 10000; i++)
			{
				numbersForTest[i] = i;
			}

			Assert.That(numbersForTest.Where(s => s % 2 != 0).Select(s => s).ToArray(), Is.EqualTo(_static.AddOddNumbers(numbersForTest)));
		}

		[Test]
		public void AddOddNumbers_FromNumbersMassive_BillionThousand()
		{
			var numbersForTest = new int[1000000];
			for (var i = 0; i < 1000000; i++)
			{
				numbersForTest[i] = i;
			}

			Assert.That(numbersForTest.Where(s => s % 2 != 0).Select(s => s).ToArray(), Is.EqualTo(_static.AddOddNumbers(numbersForTest)));
		}

		[Test]
		public void BreakingPassword_BruteForce_ThreeNumbers()
		{
			var password = new int[] {1, 0, 9};
			Assert.That(password, Is.EqualTo(_static.BreakingPassword(3)));
		}

		[Test]
		public void BreakingPassword_BruteForce_SevenNumbers()
		{
			var password = new int[] { 1, 0, 9, 4, 5, 6, 8 };
			Assert.That(password, Is.EqualTo(_static.BreakingPassword(7)));
		}

		[Test]
		public void BreakingPassword_BruteForce_TwelveNumbers()
		{
			var password = new int[] { 1, 0, 9, 4, 5, 6, 8, 5, 2, 0, 0, 3 };
			Assert.That(password, Is.EqualTo(_static.BreakingPassword(12)));
		}

		[Test]
		public void FindDifferents_FirstAlign()
		{
			var first = "C# is a general-purpose, object-oriented programming language.[15] Its development team is led by Anders Hejlsberg.";
			var second = "C+ is a ganeral-purpose, object-oriented programming language.[18] Pts Development teKm is led by Anders HPjlsberg.";

			Assert.That(_static.FindDifferents(first, second), Is.EqualTo("-^-------^------------------------------------------------------^--^---^-------------^--------------------^--------"));
		}

	}
}
