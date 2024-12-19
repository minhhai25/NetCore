
namespace pj1
{
	internal class Program
	{

		// Hàm kiểm tra số nguyên tố
		static bool IsPrime(int n)
		{
			if (n < 2) return false;
			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0) return false;
			}
			return true;
		}

		static void Main()
		{
			int sum = 0; // Biến lưu tổng

			// Duyệt qua các số từ 10 đến 99
			for (int i = 10; i <= 99; i++)
			{
				if (IsPrime(i))
				{
					sum += i; // Cộng các số nguyên tố vào tổng
				}
			}

			// Xuất kết quả
			Console.WriteLine("Tong cac so nguyen to co 2 chu so la: " + sum);
		}
	}

}
