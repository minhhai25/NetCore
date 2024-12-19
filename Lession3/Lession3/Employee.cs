using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession3
{
	internal class Employee
	{
		private int id;
		private string name;
		private int age;
		//thuộc tính chỉ đọc 
		//chỉ cho đọc dữu liệu à không được ghi dữ liệu
		public Employee() {
			this.id = 1;
			this.name = "";
			this.age = 1;
		}
		public Employee(int id , string name , int age)
		{
			this.id = id;
			this.name = name;
			this.age = age;
		}
		public int ID { get { return id; } }
		//thuộc tính chỉ ghi
		public string Name { set { name = value; } }
		//thuộc tính chỉ đọc/ghi
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public void Display()
		{
			Console.WriteLine("Id:" + id);
			Console.WriteLine("Name:" + name);
			Console.WriteLine("Age:" + age);
		}
	}
}
