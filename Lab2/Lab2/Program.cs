namespace Lab2
{
	internal class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public DateTime Birthday { get; set; }
		public decimal Salary { get; set; }
		public decimal Bonus { get; set; }
		public decimal TotalSalary => Salary + Bonus;

		public void DisplayInfo()
		{
			Console.WriteLine("=====================================");
			Console.WriteLine($"ID: {Id}");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Address: {Address}");
			Console.WriteLine($"Birthday: {Birthday:dd/MM/yyyy}");
			Console.WriteLine($"Salary: {Salary:C}");
			Console.WriteLine($"Bonus: {Bonus:C}");
			Console.WriteLine($"Total Salary: {TotalSalary:C}");
			Console.WriteLine("=====================================");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of employees: ");
			int n = int.Parse(Console.ReadLine());

			Employee[] employees = new Employee[n];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"\nEnter details for Employee {i + 1}:");
				employees[i] = new Employee();

				Console.Write("Enter ID: ");
				employees[i].Id = int.Parse(Console.ReadLine());

				Console.Write("Enter Name: ");
				employees[i].Name = Console.ReadLine();

				Console.Write("Enter Address: ");
				employees[i].Address = Console.ReadLine();

				Console.Write("Enter Birthday (dd/MM/yyyy): ");
				employees[i].Birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

				Console.Write("Enter Salary: ");
				employees[i].Salary = decimal.Parse(Console.ReadLine());

				Console.Write("Enter Bonus: ");
				employees[i].Bonus = decimal.Parse(Console.ReadLine());
			}

			Console.WriteLine("\nEmployee Details:");
			foreach (var employee in employees)
			{
				employee.DisplayInfo();
			}
		}
	}
}