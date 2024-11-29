using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
		

			//CẤU TRÚC DDEIEUF KIỆN
			//if...else
			//1.1 If
			//syntax 
			if (5 < 6)
			{
				Console.WriteLine("số 6 lớn hơn số 5");
			}

			int diem= 8;
			if (diem > 8)
			{
				Console.WriteLine("Học sinh giỏi");
			}else if (diem > 6)
			{
				Console.WriteLine("Học sinh khá");
			}
            else if (diem > 4) { 
			Console.WriteLine("Học sinh trung bình");
			}else
            {
				Console.WriteLine("Học ính yếu");
            }

			//SWITCH.. CASE 
			// so sanh nếu biến tham chiếu bằng giá trị so sánh bất kì thì sẽ thực hiện khối lệnh thực thi
			//ngược lại

			int thang = 12;
			switch (thang)
			{
				case 1:
					Console.WriteLine("Tháng 1");
					break;
				case 2:
					Console.WriteLine("Tháng 2");
					break;
				case 3:
					Console.WriteLine("Tháng 3");
					break;
				case 4:
					Console.WriteLine("Tháng 4");
					break;
				case 5:
					Console.WriteLine("Tháng 5");
					break;
				case 6:
					Console.WriteLine("Tháng 6");
					break;
				case 7:
					Console.WriteLine("Tháng 7");
					break;
				case 8:
					Console.WriteLine("Tháng 8");
					break;
				case 9:
					Console.WriteLine("Tháng 9");
					break;
				case 10:
					Console.WriteLine("Tháng 10");
					break;
				case 11:
					Console.WriteLine("Tháng 11");
					break;
				case 12:
					Console.WriteLine("Tháng 12");
					break;
				default: Console.WriteLine("số vừa nhập không phải tháng nào trong năm");
					break;
			}
        }
	}
}
