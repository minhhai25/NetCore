namespace Lab2_3._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Các số từ 100 đến 999 có tổng 3 chữ số là số chẵn:");

			for (int number = 100; number <= 999; number++)
			{
				// Tách 3 chữ số
				int hundreds = number / 100;           // Chữ số hàng trăm
				int tens = (number / 10) % 10;         // Chữ số hàng chục
				int units = number % 10;              // Chữ số hàng đơn vị

				// Tính tổng 3 chữ số
				int sum = hundreds + tens + units;

				// Kiểm tra nếu tổng là số chẵn
				if (sum % 2 == 0)
				{
					Console.WriteLine(number);
				}
			}

		}
	}
}
