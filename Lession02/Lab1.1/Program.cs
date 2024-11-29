using System.Text;

namespace Lab1._1
{
	internal class Program
	{
		/// <summary>
		/// bài 2.1 nhập vào tên thuê bao trên công tơ sao đó tính cước theo quy ước sau
		/// -nếu số phút gọi <=30 số thì cước phí tính 30$
		/// -nếu từ 30-50 số thì số trong khoảng (30-50) sẽ tính theo 1.2$ cho mỗi số 
		/// -nếu trên 50 số thì các con số tiếp theo 1.5$ cho mỗi số 
		/// -in ra màn hình toàn bộ thông tin 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			string name;
			int soCT;
			double soTien;
			Console.WriteLine("Nhập tên thuê bao ");
			name=Console.ReadLine();
			Console.WriteLine("Nhập số công tơ");
			soCT=Convert.ToInt32(Console.ReadLine());
			if(soCT <= 30)
			{
				soTien=30;

			}else if(soCT >30 &&  soCT <= 50)
			{
				soTien=(soCT-30)*1.2+30;
			}else
			{
				soTien = 20 * 1.2 + 30 + (soCT - 50) * 1.5;
			}
			Console.WriteLine("Tên thuê bao :{0}- Số công tơ:{1} - Tổng tiền:{2}$",name,soCT, soTien);
			//C2
		}
	}
}
