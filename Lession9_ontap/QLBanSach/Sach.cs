using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanSach
{
	internal class Sach
	{
		public Sach() { }
		public Sach(int Id, string Ten_Sach, int Id_TG, int ID_NXB, int NamXB, int SoTrang)
		{
			this.Id = Id;
			this.Id_TG=Id_TG;
			this.Ten_Sach=Ten_Sach;
			this.Id_NXB=Id_NXB;
			this.NamXB=NamXB;
			this.SoTrang=SoTrang;
		}
		public int Id { get; set; }
		public string Ten_Sach { get; set; }
		public int Id_TG { get; set; }
		public int Id_NXB { get; set; }
		public int NamXB { get; set; }
		public int SoTrang { get; set; }
		public void Input()
		{
			Console.Write("Nhap Id:");
			this.Id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhap Ten Sach:");
			this.Ten_Sach = Console.ReadLine();
			Console.Write("Nhap Id tac gia:");
			this.Id_TG= Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhap Id NXB:");
			this.Id_NXB= Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhap Nam XB:");
			this.NamXB = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nhap so trang:");
			this.SoTrang = Convert.ToInt32(Console.ReadLine());

		}
		
		public override string ToString()
		{
			return Id +"|" + Ten_Sach+"|"+ Id_TG+"|" + Id_NXB+"|"+ NamXB+"|"+ SoTrang;
		}
	}
}
