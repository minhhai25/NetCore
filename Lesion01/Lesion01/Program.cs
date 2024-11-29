using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion01
{
	internal class Program
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
			
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;
			//hiển thị ra ngaoif màn hình
			//Console.WriteLine("Hello word!!!");
			////khai báo biến
			//string name;
			///*
			// chú thích nhiều dòng
			//đoạn code sau sẽ yêu cầu bạn 
			//nhập tên của mình
			//sau đó in ra àn hình
			// */
			//Console.WriteLine("Nhập tên của bạn");
			////đọc thông tin gán giá trị name
			//name = Console.ReadLine();
			////hiện ra ngoài màn hình
			//Console.WriteLine("Tên cảu bạn là :"+name);
			//Console.InputEncoding = Encoding.Unicode;
			//Console.OutputEncoding = Encoding.Unicode;
			////string name;
			//string adress;
			////in ra ngoài màn hình yêu cầu nhập tên
			//Console.WriteLine("Nhập tên của bạn");
			////đọc dữu liệu từ bàn phím và gán dữ liệu bnawgf biến name
			//name = Console.ReadLine();
			////in ra ngoài màn hình yêu cầu nhập địa chỉ 
			//Console.WriteLine("Nhpaj địa chỉ của bạn");
			//adress = Console.ReadLine();
			////Hiển thị ra ngaoif màn hình tên và địa chỉ đã đăng nhập
			//Console.WriteLine("Tên của bạn là {0}\nĐịa chỉ của bạn là {1}", name, adress);



			//KIỂU DỮU LIỆU
			byte age;
			age = 18;
			int age2;
			//gán giá trị kiểu ngầm định

			age2 = age;
			Console.WriteLine("age2 =" + age2);
			//gán giá trị theo kiểu tường minh
			age2 = 20;
			age = (byte)age2;
			Console.WriteLine("age=" + age);
			age =Convert.ToByte(age2);
			Console.WriteLine("age=" + age);
			//nhập tuổi của bạn
			Console.WriteLine("Nhập tuổi của bạn");
			age = Convert.ToByte(Console.ReadLine());
			Console.WriteLine("Tuổi của bạn là "+ age);
			
			
		}
	}
}
