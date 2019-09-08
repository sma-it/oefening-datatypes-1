using System;

namespace First
{
	class Program
	{
  	static void Main(string[] args)
		{
			Console.WriteLine("Oefenreeks 1");
			Console.WriteLine("------------");

			Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \t Jouw Resultaat");
			Console.WriteLine("InitInt1 \t 7 \t\t\t" + Oef1.InitInt1());
			Console.WriteLine("InitInt2 \t -1 \t\t\t" + Oef1.InitInt2());
			Console.WriteLine("InitFloat \t 3,14 \t\t\t" + Oef1.InitFloat());
			Console.WriteLine("Prijs \t\t 1,99 \t\t\t" + Oef1.Prijs());
			Console.WriteLine("InitNaam \t Hector \t\t\t" + Oef1.InitNaam());
			Console.WriteLine("InitStad \t Aarschot \t\t\t " + Oef1.InitStad());
			Console.WriteLine("InitChar \t a \t\t\t" + Oef1.InitChar());

			Console.Write("Verdergaan met Reeks 2? (Y/n)");
			if (Console.ReadKey().KeyChar == 'n') return;

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Oefenreeks 2");
			Console.WriteLine("------------");

			Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \t Jouw Resultaat");
			Console.WriteLine("Som1 \t\t 234 \t\t\t" + Oef2.Som1(100, 134));
			Console.WriteLine("Som2 \t\t 6,8 \t\t\t" + Oef2.Som2(2.1F, 4.7F));
			Console.WriteLine("Som3 \t\t 20 \t\t\t" + Oef2.Som3(12, 10, -2, 0));
			Console.WriteLine("Naam1 \t\t JanJanssens \t\t" + Oef2.Naam1("Jan", "Janssens"));
			Console.WriteLine("Naam2 \t\t Jan Janssens\t\t" + Oef2.Naam2("Jan", "Janssens"));

			Console.Write("Verdergaan met Reeks 3? (Y/n)");
			if (Console.ReadKey().KeyChar == 'n') return;

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Oefenreeks 3");
			Console.WriteLine("------------");

			Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \t Jouw Resultaat");
			Console.WriteLine("Convert1 \t 8,0 \t\t\t" + Oef3.Convert1(8));
			Console.WriteLine("Convert2 \t 3 \t\t\t" + Oef3.Convert2(3.4F));
			Console.WriteLine("Som1 \t\t 4,3 \t\t\t" + Oef3.Som1(2.3F, 2));
			Console.WriteLine("Som2 \t\t 4 \t\t\t" + Oef3.Som2(2.3F, 2));
			Console.WriteLine("Som3 \t\t 3,42 \t\t\t" + Oef3.Som3(1.2, 2.22));

			Console.Write("Verdergaan met Reeks 4? (Y/n)");
			if (Console.ReadKey().KeyChar == 'n') return;

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Oefenreeks 4");
			Console.WriteLine("------------");

			Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \t Jouw Resultaat");
			Console.WriteLine("ToString \t xy \t\t\t" + Oef4.ToString('x', 'y'));
			Console.WriteLine("BerekenWaarde \t 2,97 \t\t\t" + Oef4.BerekenWaarde(0.99F, 3));
			Console.WriteLine("BerekenOmtrek \t 12,57 \t\t\t" + Math.Round(Oef4.BerekenOmtrek(2),2));
			Console.WriteLine("BerekenOppervlak 6 \t\t\t" + Oef4.BerekenOppervlak(2, 3));

			Console.ReadKey();
		}
	}
}
