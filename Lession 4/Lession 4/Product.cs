using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4
{
	/// <summary>
	/// khai báo class sealed không cho kế thừa
	/// </summary>
	sealed class Product
	{
		string id;
		string name;
		string description;
		float price;
		public Product(string id , string name, string description, float price)
		{
			this.id = id;	
			this.name = name;
			this.description = description;
			this.price = price;

		}
	}
	//biên dịch báo lỗi
	//class Pen : Product
	//{

	//}

}
