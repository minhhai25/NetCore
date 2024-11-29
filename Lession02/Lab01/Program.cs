using System.Text;

namespace Lab01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;


			//chưng trình minh họa về nhập xuất dữ liệu 
			//nhập xuất mã sinh viên,tên sinh viên, ngày sinh và điểm 3 môn
			//int ra thông tin và điểm trung bình
			//khai báo biến
			string MSV, tenSV;
			DateTime ngaySinh;
			float diem1,diem2,diem3;
			//yêu cầu người nhập thông tin 
			// in ra màn hình yêu cầu nhập mã sinh viên
			Console.WriteLine("Nhập mã sinh viên");
			//đọc dữ liệu và gán giá trị cho MSV
			MSV=Console.ReadLine();
			//In ra màn hình và nhaoaj tên dinh viên
			Console.WriteLine("Nhập tên sinh viên");
			tenSV=Console.ReadLine();
			Console.WriteLine("Nhập ngày sinh");
			ngaySinh=Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine("Nhập điểm môn 1");
			diem1 = (float)Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhập điểm môn 2");
			diem2 = (float)Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhập điểm môn 3");
			diem3 = (float)Convert.ToDouble(Console.ReadLine());
			double diemTB=(diem1+diem2+diem3)/3;
			Console.WriteLine("MSV:{0} -Họ tên: {1}-Ngày sinh:{2 :dd/mm/yyyy}-Điểm trung bình{3}",MSV,tenSV,ngaySinh,diemTB);
		}
	}
}
