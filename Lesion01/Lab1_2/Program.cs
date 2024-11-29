using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int id = 1;
			string name = "Minh Hải";
			byte age = 18;
			char gender = 'M';
			//khia báo biến hằng
			const float percent = 75.50F;
			Console.WriteLine("StudentId : {0}", id);
			Console.WriteLine("Student Name:{0}", name);
			Console.WriteLine("Age" + age);
			Console.WriteLine("Gender:" + gender);
			Console.WriteLine("Percentage:{0}", percent);
			//
		}
	}
}
