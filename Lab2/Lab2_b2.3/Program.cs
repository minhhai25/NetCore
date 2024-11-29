namespace Lab2_b2._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhập vào số nguyên dương (số giây): ");
			int tongSoGiay = int.Parse(Console.ReadLine());

			if (tongSoGiay < 0)
			{
				Console.WriteLine("Lỗi! Vui lòng nhập một số nguyên dương.");
				return;
			}

			// Chuyển đổi số giây thành giờ, phút và giây
			int gio = tongSoGiay / 3600;
			int phut = (tongSoGiay % 3600) / 60;
			int giay = tongSoGiay % 60;

			// Hiển thị kết quả với định dạng hh:mm:ss
			Console.WriteLine($"Thời gian (hh:mm:ss): {gio:D2}:{phut:D2}:{giay:D2}");
		}
	}
}
