using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanSach
{
	internal class TacGia
	{
		public TacGia() { }
		public TacGia(int Id,string Ten_TG) { 
		
			this.Id = Id;
			this.Ten_TG=Ten_TG;
		}
		public int Id {  get; set; }
		public string Ten_TG { get; set; }
		public void Input()
		{
			Console.Write("Nhap Id:");
			this.Id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhập Tên tác giả: ");
			this.Ten_TG = Console.ReadLine();
		}
		public override string ToString()
		{
			return Id + "|" + Ten_TG;
		}
	}
}
