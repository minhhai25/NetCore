using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_1
{
	//chương trình này in ra tt giới thiệu bản thân
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;
			Console.WriteLine("Họ và tên :Nguyễn thị minh Hải");
			Console.WriteLine("Ngày sinh :25/5/2002");
			Console.WriteLine("Địa chỉ: Bắc Giang");
			Console.WriteLine("Điện thoại:8903829035");
			//câu lệnh dừng
			Console.ReadLine();
		}
	}
}
