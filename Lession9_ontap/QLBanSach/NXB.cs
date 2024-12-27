using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanSach
{
	internal class NXB
	{
		public NXB() { }
		public NXB(int Id,string Ten_NXB) {
		this.Id = Id;
			this.Ten_NXB = Ten_NXB;
		}
		public int Id {  get; set; }
		public string Ten_NXB { get; set; }
		public void Input()
		{
			Console.Write("Nhap Id:");
			this.Id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhập Tên NXB: ");
			this.Ten_NXB = Console.ReadLine();
		}
		public override string ToString()
		{
			return Id+"|" + Ten_NXB;
		}
	}
}
