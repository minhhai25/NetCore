namespace Lab8_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer[]
			{
				new Customer {Id= 5 , Name= "Sam"},
				new Customer {Id= 6 , Name= "Dave"},
				new Customer {Id= 7, Name= "Peter"},
				new Customer {Id= 8 , Name= "Lam"},
				new Customer {Id= 9 , Name= "hoa"}

			};
			var order = new Order[] { 
			new Order {Id= 5 ,Product= "Book"},
			new Order {Id= 6 ,Product= "Game"},


			new Order {Id= 7 ,Product= "Computer"},
			new Order {Id= 8 ,Product= "Shirt"}

			};
			var query = from c in customer
						join o in order on c.Id equals o.Id
						select new { c.Name, o.Product };
			foreach (var group in query) {
			Console.WriteLine("{0} bought {1} ", group.Name , group.Product);
			}
		}
	}
}
