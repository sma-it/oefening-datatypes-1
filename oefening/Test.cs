using NUnit.Framework;
using NUnitLite;
using System;

namespace Tests
{
    // eerste oefening staat op 21 punten
	[TestFixture]
	public class TestOef1
	{
		[Test, Description("Oef 1.1 - InitInt1")]
		public void Test01_InitInt1()
		{
			Assert.That(First.Oef1.InitInt1(), Is.EqualTo(7), "3: Het getal is niet gelijk aan 7");
		}

		[Test, Description("Oef 1.2 - InitInt2")]
		public void Test02_InitInt2()
		{
			Assert.That(First.Oef1.InitInt2(), Is.EqualTo(-1), "3: Deze som klopt niet");
		}

		[Test, Description("Oef 1.3 - InitFloat")] 
		public void Test03_InitFloat()
		{
			 Assert.That(Math.Round(First.Oef1.InitFloat(),2), Is.EqualTo(Math.Round(3.14F,2)), "Deze float is niet gelijk aan 3.14");
		}

		[Test, Description("Oef 1.4 - Prijs")]
		public void Test04_Prijs()
		{
			Assert.That(First.Oef1.Prijs(), Is.EqualTo(1.99), "3: Dat is niet de juiste prijs");
		}

		[Test, Description("Oef 1.5 - InitNaam")]
		public void Test05_InitNaam()
		{
			Assert.That(First.Oef1.InitNaam(), Is.EqualTo("Hector"), "3: De naam is niet 'Hector'");
		}

		[Test, Description("Oef 1.6 - InitStad")]
		public void Test06_InitStad()
		{
			Assert.That(First.Oef1.InitStad(), Is.EqualTo("Aarschot"), "3: De stad is niet 'Aarschot'");
		}

		[Test, Description("Oef 1.7 - InitChar")]
		public void Test07_InitChar()
		{
			Assert.That(First.Oef1.InitChar(), Is.EqualTo('a'), "3: Het resultaat moet de letter a zijn");
		}
	}

    // tweede oefening staat op 25 punten
	[TestFixture]
	public class TestOef2
	{
		[Test, Description("Oef 2.1 - Som1")]
		public void Test01_Som1()
		{
			Assert.That(First.Oef2.Som1(50, 23), Is.EqualTo(73), "5: Je som is niet correct");
			Assert.That(First.Oef2.Som1(12, -34), Is.EqualTo(-22), "5: Je som is niet correct");
		}

		[Test, Description("Oef 2.2 - Som2")]
		public void Test02_Som2()
		{
			Assert.That(First.Oef2.Som2(3.1F, 5.4F), Is.EqualTo(8.5F), "5: Je som is niet correct");
			Assert.That(Math.Round(First.Oef2.Som2(1.0F, -2.1F), 1), Is.EqualTo(Math.Round(-1.1F, 1)), "5: Je som is niet correct");
		}

		[Test, Description("Oef 2.3 - Som3")]
		public void Test03_Som3()
		{
			Assert.That(First.Oef2.Som3(3, 5, 0, -7), Is.EqualTo(1), "5: Je som is niet correct");
			Assert.That(First.Oef2.Som3(100, 22, -9, 9), Is.EqualTo(122), "5: Je som is niet correct");
		}

		[Test, Description("Oef 2.4 - Naam1")]
		public void Test04_Naam1()
		{
			Assert.That(First.Oef2.Naam1("Test", "Name"), Is.EqualTo("TestName"), "5: Beide argumenten moeten samen het resultaat vormen");
			Assert.That(First.Oef2.Naam1("Abc", "Xyz"), Is.EqualTo("AbcXyz"), "5: Beide argumenten moeten samen het resultaat vormen");
		}
		
		[Test, Description("Oef 2.5 - Naam2")]
		public void Test05_Naam2()
		{
			Assert.That(First.Oef2.Naam2("Test", "Name"), Is.EqualTo("Test Name"), "5: Beide argumenten moeten samen het resultaat vormen, met een spatie er tussen");
			Assert.That(First.Oef2.Naam2("Abc", "Xyz"), Is.EqualTo("Abc Xyz"), "5: Beide argumenten moeten samen het resultaat vormen, met een spatie er tussen");
		}
	}

    // derde oefening staat op 25 punten
	[TestFixture]
	public class TestOef3
	{
		[Test, Description("Oef 3.1 - Convert1")]
		public void Test_Convert1()
		{
			Assert.That(First.Oef3.Convert1(7), Is.EqualTo(7.0F), "5: Dit is geen correcte float conversie");
			Assert.That(First.Oef3.Convert1(4), Is.EqualTo(4.0F), "5: Dit is geen correcte float conversie");
			Assert.That(First.Oef3.Convert1(3).GetType() == typeof(float), Is.EqualTo(true), "3: De waarde lijkt correct, maar het is geen float");
		}

		[Test, Description("Oef 3.2 - Convert2")]
		public void Test_Convert2()
		{
			Assert.That(First.Oef3.Convert2(7.3F), Is.EqualTo(7), "5: Dit is geen correcte integer conversie");
			Assert.That(First.Oef3.Convert2(-1.2F), Is.EqualTo(-1), "5: Dit is geen correcte integer conversie");
			Assert.That(First.Oef3.Convert2(3F).GetType() == typeof(int), Is.EqualTo(true), "3: De waarde lijkt correct, maar het is geen integer");
		}

		[Test, Description("Oef 3.3 - Som1")]
		public void Test_Som1()
		{
			Assert.That(First.Oef3.Som1(2.3F, 4), Is.EqualTo(6.3F), "5: De som is niet juist");
			Assert.That(First.Oef3.Som1(4.5F, -6), Is.EqualTo(-1.5F), "5: De som is niet juist");
			Assert.That(First.Oef3.Som1(4.2F, 1).GetType() == typeof(float), Is.EqualTo(true), "3: De som is juist, maar het resultaat moet een float zijn");
		}

		[Test, Description("Oef 3.4 - Som2")]
		public void Test_Som2()
		{
			Assert.That(First.Oef3.Som2(2.3F, 4), Is.EqualTo(6), "5: De som is niet juist");
			Assert.That(First.Oef3.Som2(4.5F, -6), Is.EqualTo(-1), "5: De som is niet juist");
			Assert.That(First.Oef3.Som2(4.2F, 1).GetType() == typeof(int), Is.EqualTo(true), "3: De som is juist, maar het resultaat moet een integer zijn");
		}

		[Test, Description("Oef 3.5 - Som3")]
		public void Test_Som3()
		{
			Assert.That(First.Oef3.Som3(2.3, 4.3), Is.EqualTo(6.6F), "5: De som is niet juist");
			Assert.That(First.Oef3.Som3(13, 0.1), Is.EqualTo(13.1F), "5: De som is niet juist");
			Assert.That(First.Oef3.Som3(4.2F, 1).GetType() == typeof(float), Is.EqualTo(true), "3: De som is juist, maar het resultaat moet een float zijn");
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
			Assert.That(Math.Round(First.Oef4.BerekenOmtrek(3),2), Is.EqualTo(Math.Round(18.85F,2)));
			Assert.That(Math.Round(First.Oef4.BerekenOmtrek(6.2),2), Is.EqualTo(Math.Round(38.96F,2)));
		}

		[Test] 
		public void Test_BerekenOppervlak()
		{
			Assert.That(First.Oef4.BerekenOppervlak(3, 4), Is.EqualTo(12F));
			Assert.That(First.Oef4.BerekenOppervlak(5.7, 3.2), Is.EqualTo(18.24F));
		}
	}
}
