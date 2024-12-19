using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5
{
	public abstract class Person
	{

	public void Speak()
		{
			Console.WriteLine("Người việt Nam nói tiếng Việt");

		}
		public abstract void Work();
		public abstract void Run();
	}
	public class Employee : Person
	{
		public void Speak()
		{
			base.Speak();
		}
		public override void Work()
		{
		 Console.WriteLine("Làm việc vất vả");
		}
		public override void Run()
		{
			Console.WriteLine("Chạy cả ngay");
		}
	}
}



using System;

class Program
{
	// Mảng chứa cách đọc các chữ số
	static readonly string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
	static readonly string[] Places = { "", "nghìn", "triệu", "tỷ" };

	static void Main()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ tiếng Việt
		Console.Write("Nhập số cần đổi (tối đa đến hàng trăm tỷ): ");
		if (long.TryParse(Console.ReadLine(), out long number))
		{
			string result = ConvertNumberToWords(number);
			Console.WriteLine("Kết quả: " + result);
		}
		else
		{
			Console.WriteLine("Số không hợp lệ!");
		}
	}

	static string ConvertNumberToWords(long number)
	{
		if (number == 0) return "không";

		string result = "";
		if (number < 0)
		{
			result = "âm ";
			number = -number; // Đổi sang số dương để xử lý
		}

		int placeIndex = 0; // Chỉ số cho "nghìn", "triệu", "tỷ"
		while (number > 0)
		{
			int threeDigits = (int)(number % 1000); // Lấy 3 chữ số cuối cùng
			if (threeDigits > 0)
			{
				result = ConvertThreeDigits(threeDigits) + " " + Places[placeIndex] + " " + result;
			}
			number /= 1000; // Bỏ 3 chữ số cuối
			placeIndex++;
		}

		return result.Trim();
	}

	// Hàm đọc một khối 3 chữ số
	static string ConvertThreeDigits(int number)
	{
		string result = "";

		int hundreds = number / 100;
		int tens = (number % 100) / 10;
		int units = number % 10;

		if (hundreds > 0)
		{
			result += Units[hundreds] + " trăm ";
			if (tens == 0 && units > 0)
			{
				result += "lẻ ";
			}
		}

		if (tens > 1)
		{
			result += Units[tens] + " mươi ";
			if (units == 1) result += "mốt ";
			else if (units > 0) result += Units[units] + " ";
		}
		else if (tens == 1)
		{
			result += "mười ";
			if (units > 0) result += Units[units] + " ";
		}
		else if (units > 0)
		{
			result += Units[units] + " ";
		}

		return result.Trim();
	}
}
