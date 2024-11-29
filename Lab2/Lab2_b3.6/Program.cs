namespace Lab2_b3._6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhập cạnh a: ");
			int a = int.Parse(Console.ReadLine());

			Console.Write("Nhập cạnh b: ");
			int b = int.Parse(Console.ReadLine());

			Console.Write("Nhập cạnh c: ");
			int c = int.Parse(Console.ReadLine());

			// Kiểm tra điều kiện tam giác
			if (a + b > c && a + c > b && b + c > a)
			{
				Console.WriteLine($"Ba cạnh {a}, {b}, {c} tạo thành một tam giác.");

				// Kiểm tra loại tam giác
				if (a == b && b == c)
				{
					Console.WriteLine("Đây là tam giác đều.");
				}
				else if (a == b || a == c || b == c)
				{
					if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
					{
						Console.WriteLine("Đây là tam giác vuông cân.");
					}
					else
					{
						Console.WriteLine("Đây là tam giác cân.");
					}
				}
				else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
				{
					Console.WriteLine("Đây là tam giác vuông.");
				}
				else
				{
					Console.WriteLine("Đây là tam giác thường.");
				}
			}
			else
			{
				Console.WriteLine($"Ba cạnh {a}, {b}, {c} không tạo thành một tam giác.");
			}
		}
	}
}
