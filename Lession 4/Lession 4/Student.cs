using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4
{
	internal class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Student() { }
		public Student(int id, string name) { 
		this.Id = id;
			this.Name = name;
				}
		public Student(int id, string name, int age)
		{
			this.Id = id;
			this.Name = name;
			this.Age = age;
		}
		public Student (string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
		public void Display()
		{
			Console.WriteLine("Id:{0}", Id);
			Console.WriteLine("Name:{0}", Name);
			Console.WriteLine("Age:{0}", Age);
		}
	}
}
