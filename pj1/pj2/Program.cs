namespace pj2
{
	internal class Program
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8; // Đảm bảo hỗ trợ tiếng Việt
			string line1 = "CONG TY DIEN LUC BAC GIANG CHAO MUNG CAC THI SINH";
			string line2 = "CHUC CAC BAN THI TUYEN THANH CONG";

			int windowWidth = Console.WindowWidth; // Lấy chiều rộng màn hình console
			int delay = 100; // Độ trễ giữa các bước di chuyển (milliseconds)

			// Vòng lặp để chạy chữ
			for (int position = 0; position < windowWidth; position++)
			{
				Console.Clear(); // Xóa màn hình trước khi in mới
								 // Dùng PadLeft để di chuyển dòng chữ ngang qua màn hình
				Console.WriteLine(line1.PadLeft(position + line1.Length));
				Console.WriteLine(line2.PadLeft(position + line2.Length));

				Thread.Sleep(delay); // Tạo độ trễ
			}
		}
	}

}
