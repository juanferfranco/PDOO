using System;

namespace Facade
{
	/// <summary>
	/// MainApp startup class for .NET optimized 
	/// Facade Design Pattern.
	/// </summary>
	class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// Facade
			var hipoteca = new Hipoteca();

			// Evaluate mortgage eligibility for customer
			var cliente = new Cliente { Name = "Ana Gomez" };
			bool eligible = hipoteca.IsEligible(cliente, 250000);

			Console.WriteLine("\n" + cliente.Name +
				" ha sido " + (eligible ? "Aprobado" : "Rechazado"));

			// Wait for user
			Console.ReadKey();
		}
	}

	/// <summary>
	/// The 'Subsystem ClassA' class
	/// </summary>
	class Banco
	{
		public bool HasSufficientSavings(Cliente c, int amount)
		{
			Console.WriteLine("Check bank for " + c.Name);
			return true;
		}
	}

	/// <summary>
	/// The 'Subsystem ClassB' class
	/// </summary>
	class Credito
	{
		public bool HasGoodCredit(Cliente c)
		{
			Console.WriteLine("Check credit for " + c.Name);
			return true;
		}
	}

	/// <summary>
	/// The 'Subsystem ClassC' class
	/// </summary>
	class Prestamo
	{
		public bool HasNoBadLoans(Cliente c)
		{
			Console.WriteLine("Check loans for " + c.Name);
			return true;
		}
	}

	/// <summary>
	/// The 'Facade' class
	/// </summary>
	class Hipoteca
	{
		Banco bank = new Banco();
		Prestamo loan = new Prestamo();
		Credito credit = new Credito();

		public bool IsEligible(Cliente cust, int amount)
		{
			Console.WriteLine("{0} applies for {1:C} loan\n",
				cust.Name, amount);

			bool eligible = true;

			// Check creditworthyness of applicant
			if (!bank.HasSufficientSavings(cust, amount))
			{
				eligible = false;
			}
			else if (!loan.HasNoBadLoans(cust))
			{
				eligible = false;
			}
			else if (!credit.HasGoodCredit(cust))
			{
				eligible = false;
			}

			return eligible;
		}
	}

	/// <summary>
	/// Customer class
	/// </summary>
	class Cliente
	{
		// Gets or sets the name
		public string Name { get; set; }
	}
}
