using Store;

namespace Lab7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Supply.Manufacturer dealer = new Supply.Manufacturer();
			dealer.Name = "Coca Cola";
			dealer.Email = "asdf@gmail.com";
			dealer.Phone = "1234567890";
			Console.WriteLine("Dealer Ìnormation");
			Console.WriteLine("\t Name"+  dealer.Name);
			Console.WriteLine("\t Email"+ dealer.Email);
			Console.WriteLine("\t Phone"+ dealer.Phone);

			StoreItem si = new StoreItem();

			si.ItemNo = 32543;
			si.ItemName = "Fanta";
			si.Price = 80.00M;

			Console.WriteLine("Store Inventory");
			Console.WriteLine("\t Item # :        ");
			Console.WriteLine(si.ItemNo);
			Console.WriteLine("\t Item Name");
			Console.WriteLine(si.ItemName);
			Console.WriteLine("\t Unit Price");
			Console.WriteLine(si.Price);

			Console.Read();

		}
	}
}
