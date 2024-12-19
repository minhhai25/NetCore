using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession3
{
	internal class Category
	{
		//khai báo các trường
		private int id;
		private string name;
		//khai báo thuộc tính
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		//khai báo phương thức 
		public void Display()
		{
			Console.WriteLine("Id:" + id);
			Console.WriteLine("Name:" + name);
		}
	}
}
