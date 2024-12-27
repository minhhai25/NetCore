using QLBanSach;
using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
List<NXB> nxb = new List<NXB>()
			{
				new NXB(1,"NXB Kim Dong"),
				new NXB(2,"NXB Tre"),
				new NXB(3,"NXB Nha Nam"),
				new NXB(4,"NXB Thieu Nhi"),
			};
List<TacGia> tacGias = new List<TacGia>()
			{
				new TacGia(1,"Nam Cao"),
				new TacGia(2,"To Huu"),
				new TacGia(3,"Kim Lan"),
				new TacGia(4,"Huy Can"),
				new TacGia(5,"Xuan Dieu"),
			};
List<Sach> saches = new List<Sach>()
			{
				new Sach(1,"Lang",3,1,2009,80),
				new Sach(2,"Chiec thuyen ngoai",2,2,2009,70),
				new Sach(3,"Chi Pheo",4,3,2005,102),
				new Sach(4,"Yeu",5,1,2004,180),
				new Sach(5,"Tay Tien",2,3,2010,220),
				new Sach(6,"Lao Hac",1,3,2011,321),
			};
//Hiển thị tất cả sách 
Console.WriteLine("Hien thi tat ca cac sach");
foreach (var item in saches)
{
	Console.WriteLine($"\tID: {item.Id}, Tên: {item.Ten_Sach}, Năm XB: {item.NamXB}, So trang: {item.SoTrang}");
}
var kt = true;
int n = 0;
do
{
	try
	{
		Console.WriteLine("Chào mừng bạn đến với chương trình quản lý sách");
		Console.WriteLine("1.Nhập thông tin");
		Console.WriteLine("2.Hiển thị dữ liệu");
		Console.WriteLine("3.Xóa ");
		Console.WriteLine("4.Thoát");

		n = Convert.ToInt32(Console.ReadLine());
		int loai = 0;
		switch (n)
		{
			case 1:

				Console.WriteLine("-----------------------------");
				Console.WriteLine("1.Nhập thông tin sách");
				Console.WriteLine("2.Nhập thông tin Tác giả");
				Console.WriteLine("3.Nhập thông tin Nhà xuất bản");
				loai = Convert.ToInt32(Console.ReadLine());
				switch (loai)
				{
					case 1:
						Sach obj = new Sach();
						obj.Input();
						saches.Add(obj);
						break;
					case 2:
						TacGia obj2 = new TacGia();
						obj2.Input();
						tacGias.Add(obj2);
						break;
					case 3:
						NXB obj3 = new NXB();
						obj3.Input();
						nxb.Add(obj3);
						break;
					default:
						Console.WriteLine("Hãy nhập số từ 1 đến 3");
						break;
				}
				break;
			case 2:
				Console.WriteLine("-----------------------------");
				Console.WriteLine("1.Hiển thi thông tin nhà xuất bản");
				Console.WriteLine("2.Hiển thi  thông tin Tác giả");
				Console.WriteLine("3.Hiển thi  thông tin sách");
				Console.WriteLine("4.Hiển thị thông tin sách theo group tác giả");
				Console.WriteLine("5.Tìm kiếm theo tên sách");
				Console.WriteLine("6.Tìm kiếm sách theo id tác giả");
				loai = Convert.ToInt32(Console.ReadLine());
				switch (loai)
				{
					case 1:
						foreach (var obj in nxb)
						{
							Console.WriteLine(obj.ToString());
						}
						break;
					case 2:
						foreach (var obj in tacGias)
						{
							Console.WriteLine(obj.ToString());
						}
						break;
					case 3:
						foreach (var obj in saches)
						{
							Console.WriteLine(obj.ToString());
						}
						break;
					case 4:
						var sachTheoTacGia = saches.GroupBy(s => s.Id_TG)
												 .Select(group => new
												  {
												   TacGiaId = group.Key,
												   SachList = group.ToList()
												  });

						foreach (var group in sachTheoTacGia)
						{
							var tacGia = tacGias.FirstOrDefault(tg => tg.Id == group.TacGiaId);
							Console.WriteLine($"Tác giả: {tacGia?.Ten_TG ?? "Không xác định"}");

							foreach (var sach in group.SachList)
							{
								Console.WriteLine($"\tID: {sach.Id}, Tên: {sach.Ten_Sach}, Năm XB: {sach.NamXB}, Số trang: {sach.SoTrang}");
							}
						}
						break;
					case 5:
						string tenSachTimKiem = Console.ReadLine();

						var sachTimThay = saches
							.Where(s => s.Ten_Sach.IndexOf(tenSachTimKiem, StringComparison.OrdinalIgnoreCase) >= 0)
							.ToList();

						if (sachTimThay.Any())
						{
							Console.WriteLine("Các sách tìm thấy:");
							foreach (var sach in sachTimThay)
							{
								Console.WriteLine($"\tID: {sach.Id}, Tên: {sach.Ten_Sach}, Năm XB: {sach.NamXB}, Số trang: {sach.SoTrang}");
							}
						}
						else
						{
							Console.WriteLine("Không tìm thấy sách nào phù hợp.");
						}
						break;
					case 6:
						break;
					default:
						Console.WriteLine("Hãu nhập số từ 1 đến 3");
						break;
				}
				break;
			case 3:
				Console.WriteLine("-----------------------------");
				Console.WriteLine("1.Xóa thông tin nhà xuất bản");
				Console.WriteLine("2.Xóa thông tin Tác giả");
				Console.WriteLine("3.Xóa thông tin sách");
				loai = Convert.ToInt32(Console.ReadLine());
				int id;
				switch (loai)
				{
					case 1:
						foreach (var obj in nxb)
						{
							Console.WriteLine(obj.ToString());
						}
						Console.WriteLine("Chọn Id");
						var obj1 = new NXB();
						id = Convert.ToInt32(Console.ReadLine());
						foreach (var obj in nxb)
						{
							if (obj.Id.Equals(id)) { obj1 = obj; }

						}
						nxb.Remove(obj1);
						break;
					case 2:
						foreach (var obj in tacGias)
						{
							Console.WriteLine(obj.ToString());
						}
						Console.WriteLine("Chọn Id");
						var obj2 = new TacGia();
						id = Convert.ToInt32(Console.ReadLine());
						foreach (var obj in tacGias)
						{
							if (obj.Id.Equals(id))
							{
								obj2 = obj;
							}

						}
						tacGias.Remove(obj2);
						break;
					case 3:
						foreach (var obj in saches)
						{
							Console.WriteLine(obj.ToString());
						}
						Console.WriteLine("Chọn Id");
						var obj3 = new Sach();
						id = Convert.ToInt32(Console.ReadLine());
						foreach (var obj in saches)
						{
							if (obj.Id.Equals(id))
							{
								obj3 = obj;
							}

						}
						saches.Remove(obj3);
						break;
					default:
						Console.WriteLine("Hãu nhập số từ 1 đến 3");
						break;
				}

				break;
			case 4:
				kt = false;
				break;
			default:

				Console.WriteLine("Hãy nhập số từ 1 đến 3");
				break;
		}
	}
	catch (Exception ex)
	{

	}


} while (kt);
