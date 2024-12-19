using Electronic.Sony;
using System.Collections;
using Samsung = Electronic.Samsung;
namespace Lesion7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//review 
			//collection
			//ArrayList arrlist = new ArrayList();
			//arrlist.Add(1);
			//arrlist.AddRange(arrlist);
			//arrlist.Remove(1);
			//Hashtable ht = new Hashtable();
			//ht.Add("a", 1);
			//SortedList sortedList = new SortedList();
			//sortedList.Add(1, 1);
			//sủ dung using Elictronic.Sony bên ngoài namespace và sử dụng đến nó
			//
			XperiaZ xperiaZ = new XperiaZ();
			//cách 2 : sủ dụng tên namespace.tên class 
			Electronic.Tivi tivi = new Electronic.Tivi();
			//cách 3 " sử dụng tên alisat bí danh
			//đặt tên aliat cho namespace -> aliat.ten_class 
			Samsung.GalaxyA galaxyA = new Samsung.GalaxyA();
			Samsung.GalaxyS galaxyS = new Samsung.GalaxyS();
			galaxyA.Display();
			galaxyS.Display();
			


			//NGOẠI LỆ
		}
	}
}
