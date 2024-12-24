namespace Lab8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] data = { "To","ve","hon","nguoi","tro","thanh","ke","thu","cua","ta","chiu","nhuong","nguoi","se","tro","thanh","ban","cua","ta"};
			IEnumerable<string> result1 = from m in data select m;
			Console.WriteLine("Hien thi tat ca ket qua");
			foreach (var item in result1) Console.Write(item + "");

			IEnumerable<string > result2 = from m in data where m.Equals("nguoi")
										   select m;
			Console.WriteLine("Truy van theo dieu kien");
            foreach (var item in result2)
            {
				Console.Write(item + "");
            }

			IEnumerable<string> result3 = from m in data orderby m select m;
			Console.WriteLine("Hien thi tat ca ket qua qua sap xep ");
            foreach (var item in result3)
            {
				Console.Write(item + "");
            }
			var result4 = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };
			Console.WriteLine("Chu thuong va hoa");
            foreach (var item in result4)
            {
				Console.WriteLine(item.Thuong + " " + item.Hoa);

            }

        }
	}
}
