namespace Lab2__b2._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the year (X): ");
			int year = int.Parse(Console.ReadLine());

			Console.Write("Enter the month (Y): ");
			int month = int.Parse(Console.ReadLine());

			if (month < 1 || month > 12)
			{
				Console.WriteLine("Invalid month! Please enter a month between 1 and 12.");
				return;
			}

			int daysInMonth = DateTime.DaysInMonth(year, month);

			Console.WriteLine($"Year {year}, Month {month} has {daysInMonth} days.");
		}
	}
}
