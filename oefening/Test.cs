using NUnit.Framework;
using NUnitLite;

namespace Tests
{
	[TestFixture]
	public class TestOef1
	{
		// deze functie is nodig om de testen achteraf via de webinterface uit te voeren
		public static int Run(string resultPath)
		{
			string[] args = { "--work=" + resultPath };
			return new AutoRun().Execute(args);
		}

		[Test]
		public void Test_InitInt1()
		{
			Assert.That(First.Oef1.InitInt1(), Is.EqualTo(7));
		}

		[Test]
		public void Test_InitInt2()
		{
			Assert.That(First.Oef1.InitInt2(), Is.EqualTo(-1));
		}

		[Test] 
		public void Test_InitFloat()
		{
			Assert.That(First.Oef1.InitFloat(), Is.EqualTo(3.14));
		}

		[Test]
		public void Test_Prijs()
		{
			Assert.That(First.Oef1.Prijs(), Is.EqualTo(1.99));
		}

		[Test]
		public void Test_InitNaam()
		{
			Assert.That(First.Oef1.InitNaam(), Is.EqualTo("Hector"));
		}

		[Test]
		public void Test_InitStad()
		{
			Assert.That(First.Oef1.InitStad(), Is.EqualTo("Aarschot"));
		}

		[Test]
		public void Test_InitChar()
		{
			Assert.That(First.Oef1.InitChar(), Is.EqualTo('a'));
		}
	}

	[TestFixture]
	public class TestOef2
	{
		[Test]
		public void Test_Som1()
		{
			Assert.That(First.Oef2.Som1(50, 23), Is.EqualTo(73));
			Assert.That(First.Oef2.Som1(12, -34), Is.EqualTo(-22));
		}

		[Test]
		public void Test_Som2()
		{
			Assert.That(First.Oef2.Som2(3.1F, 5.4F), Is.EqualTo(8.5F));
			Assert.That(First.Oef2.Som2(1.0F, -2.1F), Is.EqualTo(-1.1F));
		}

		[Test]
		public void Test_Som3()
		{
			Assert.That(First.Oef2.Som3(3, 5, 0, -7), Is.EqualTo(1));
			Assert.That(First.Oef2.Som3(100, 22, -9, 9), Is.EqualTo(122));
		}

		[Test]
		public void Test_Naam1()
		{
			Assert.That(First.Oef2.Naam1("Test", "Name"), Is.EqualTo("TestName"));
			Assert.That(First.Oef2.Naam1("Abc", "Xyz"), Is.EqualTo("AbcXyz"));
		}
		
		[Test]
		public void Test_Naam2()
		{
			Assert.That(First.Oef2.Naam1("Test", "Name"), Is.EqualTo("Test Name"));
			Assert.That(First.Oef2.Naam1("Abc", "Xyz"), Is.EqualTo("Abc Xyz"));
		}
	}

	[TestFixture]
	public class TestOef3
	{
		[Test]
		public void Test_Convert1()
		{
			Assert.That(First.Oef3.Convert1(7), Is.EqualTo(7.0F));
			Assert.That(First.Oef3.Convert1(4), Is.EqualTo(4.0F));
			Assert.That(First.Oef3.Convert1(3).GetType() == typeof(float), Is.EqualTo(true));
		}

		[Test]
		public void Test_Convert2()
		{
			Assert.That(First.Oef3.Convert2(7.3F), Is.EqualTo(7));
			Assert.That(First.Oef3.Convert2(-1.2F), Is.EqualTo(-1));
			Assert.That(First.Oef3.Convert2(3F).GetType() == typeof(int), Is.EqualTo(true));
		}

		[Test]
		public void Test_Som1()
		{
			Assert.That(First.Oef3.Som1(2.3F, 4), Is.EqualTo(6.3F));
			Assert.That(First.Oef3.Som1(4.5F, -6), Is.EqualTo(-1.5F));
			Assert.That(First.Oef3.Som1(4.2F, 1).GetType() == typeof(float), Is.EqualTo(true));
		}

		[Test]
		public void Test_Som2()
		{
			Assert.That(First.Oef3.Som2(2.3F, 4), Is.EqualTo(6));
			Assert.That(First.Oef3.Som2(4.5F, -6), Is.EqualTo(-1));
			Assert.That(First.Oef3.Som2(4.2F, 1).GetType() == typeof(int), Is.EqualTo(true));
		}

		[Test]
		public void Test_Som3()
		{
			Assert.That(First.Oef3.Som3(2.3, 4.3), Is.EqualTo(6.6F));
			Assert.That(First.Oef3.Som3(13, 0.1), Is.EqualTo(13.1F));
			Assert.That(First.Oef3.Som3(4.2F, 1).GetType() == typeof(float), Is.EqualTo(true));
		}
	}

	[TestFixture]
	public class TestOef4
	{
		[Test]
		public void Test_ToString()
		{
			Assert.That(First.Oef4.ToString('x', 'z'), Is.EqualTo("xz"));
			Assert.That(First.Oef4.ToString('b', '.'), Is.EqualTo("b."));
		}

		[Test]
		public void Test_BerekenWaarde()
		{
			Assert.That(First.Oef4.BerekenWaarde(1.25F, 4), Is.EqualTo(5F));
			Assert.That(First.Oef4.BerekenWaarde(0.95F, 10), Is.EqualTo(9.5F));
		}

		[Test]
		public void Test_BerekenOmtrek()
		{
			Assert.That(First.Oef4.BerekenOmtrek(3), Is.EqualTo(18.85F));
			Assert.That(First.Oef4.BerekenOmtrek(6.2), Is.EqualTo(38.96F));
		}

		[Test] 
		public void Test_BerekenOppervlak()
		{
			Assert.That(First.Oef4.BerekenOppervlak(3, 4), Is.EqualTo(12F));
			Assert.That(First.Oef4.BerekenOppervlak(5.7, 3.2), Is.EqualTo(18.24F));
		}
	}
}
