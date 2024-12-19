using System.Collections;
namespace Lession6
{
	internal class Program
	{

		//internal class Overview
		//{
		//	/*
		//	 * 1.lớp trừu tượng:abstract
		//	 * -phương thức trừu tượng: abstract
		//	 * -phương thức k có trừu tượng : không có abstract
		//	 * -để kế thừa phương thức trừu tượng :override
		//	 * 2.Lớp giao diện:Interface
		//	 * -phưng thức trừu tượng: không chưa nối dung thực thi
		//	 * -kế thừa phương thức trừ tượng thì không dùng từ khóa override
		//	 * -khi kế thừa interface thì phải có thwucj thi tất cả các phương thức 
		//	 * của interface
		//	 * các phương thức chỉ thwucj thi ở class kê thừa
		//	 * -đa kế thừa   -> class sẽ phải thwucj thi tất cả các phương thức
		//	 * trong các interface khác nhau
		//	 * => thwucj thi phương thức trừu tượng tại class
		//	 * 
		//	 * -
		//	 * 3.Mảng 
		//	 * -Mảng 1 chiều 
		//	 * kiểu dữ liệu[]ten_mang
		//	 * - mảng 2 chiều
		//	 * +mảng 2 chiều hcn 
		//	 * kieu_du_lieu[,] ten_mang= new kieu_du_lieu[số_dòng,số_cột]
		//	 * {
		//	 * {}
		//	 * ...
		//	 * {}
		//	 * }
		//	 * +mảng 2 chiều ziczac
		//	 * kieu_du_lieu[] []ten_mang= new kieu_du_lieu[số_dòng][]
		//	 * ten_mảng[dòng]={...}
		//	 * -Array - nằm trong namespace Systeam 
		//	 * +Sort
		//	 * +Reverse
		//	 * +Indexof
		//	 * +LastIndexof
		//	 * 
		//	 */
		//}
		static void Main(string[] args)
		{
			ArrayList arrList = new ArrayList();
			arrList.Add(1);
			arrList.Add("devmaster");
			int[] arr = new int[9] { 1, 2, 3, 8, 5, 46, 34, 56, 3 };
			arrList.AddRange(arr);
			Console.WriteLine("Chuỗi Araylist");
			//hiể thị
			//for(int i = 0; i < arrList.Count; i++)
			//{
			//	Console.WriteLine(arrList[i]);
			//}
			//Console.WriteLine("-----------------");
			////sắp xếp
			//arrList.Sort();
			//Console.WriteLine("Chuỗi sau khi sắp xếp");
			//for (int i = 0;i < arrList.Count;i++)
			//{
			//	Console.WriteLine(arrList[i]);
			//}
			//Console.WriteLine("-----------------------");
			////sắp xếp - phải cùng kiểu dữ liệu
			//arrList.Sort();
			//Console.WriteLine("Chuỗi sau khi sắp xếp");
			//for (int i = 0; i < arrList.Count; i++)
			//{
			//	Console.WriteLine(arrList[i]);
			//}
			//Console.WriteLine("-----------------------");
			////xóa dữu liệu 
			//arrList.RemoveAt(0);
			//for (int i = 0;arrList.Count > 0;i++)
			//{
			//	Console.WriteLine(arrList[i]);
			//}
			//arrList.RemoveAt(3);
			//for (int i = 0; arrList.Count > 0; i++)
			//{
			//	Console.WriteLine(arrList[i]);
			//}
			//arrList.RemoveRange(3, 2);
			//Console.WriteLine("Chuỗi ArrayList ");
			//for( int i = 0;i<arrList.Count;i++)
			//{
			//	Console.WriteLine(arrList[i]);
			//}

			Console.WriteLine("---------------------------------------");
			//Hash table

			Hashtable hashtable = new Hashtable();
			hashtable.Add("HR", "Human Réoure");
			hashtable.Add("IT", "Information Tecnology");
			//nếu hastable đã có ley là MK thì gán value là "marketing
			//ngược lại nếu hashtable chưa có key thì add thêm cặp key và value

			hashtable["MK"] = "Makerting";
			//hiển thị dữ liệu
			foreach (var key in hashtable.Keys)
			{
				Console.WriteLine("key:" + key + "\t value:" + hashtable[key]);
			}
			//Sort list'
			SortedList sortedList = new SortedList();
			sortedList.Add(3, "Human Réource");
			sortedList.Add(2, "Information Tenology");
			sortedList[4] = "Marketing";
			for (int i = 0; i < sortedList.Count; i++)
			{
				Console.WriteLine("key " + sortedList.GetKey(i) + "\t value:" + sortedList.GetByIndex(i));
			}
			foreach (var key in sortedList.Keys)
			{
				Console.WriteLine("key:" + key + "\t value:" + sortedList[key]);
			}

			//Remove theo key
			sortedList.Remove(2);
			Console.WriteLine("Sortlisst sau khi xóa key2");
			foreach (var key in sortedList.Keys)
			{
				Console.WriteLine("key:" + key + "\t value:" + sortedList[key]);
			}
			//Xóa vị trí 
			Console.WriteLine("----------------------------");
			Console.WriteLine("sortlist sau khi xóa vị trí 2");
			sortedList.RemoveAt(1);



			//tìm kiếm
			sortedList.ContainsKey(2);
			sortedList.ContainsValue("Marketing");
			//Generic Collecttion
			//list,Dictionary,SortedList 
			List<int> numbers = new List<int>();
			numbers.Add(1);
			numbers.AddRange(arr);
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
			List<string> chuoi = new List<string>()
			{
				"Devaster","Vũ ngọc phan","Hà nội"
			};
			for (int i = 0; i < chuoi.Count; i++)
			{
				Console.WriteLine(chuoi[i]);
			}
			Dictionary<int, string> dict = new Dictionary<int, string>();
			dict.Add(1, "một");
			dict.Add(2, "hai");
			dict.Add(3, "ba");
			Dictionary<int, string> dict2 = new Dictionary<int, string>()
			{
				{1,"một" }
				, {2,"hai"},
				{3,"ba" }
			};
			foreach (var key in dict2.Keys)
			{
				Console.WriteLine();
			}
			SortedList<string, int> sortedList2 = new SortedList<string,int>();
			
		}
	}
}
