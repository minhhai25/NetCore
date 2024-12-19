using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lession3
{
	internal class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Mark1 { get; set; }
		public int Mark2 { get; set; }
		public int Mark3 { get; set; }
		public void Display()
		{
			Console.WriteLine("Id:" + Id);
			Console.WriteLine("Name:" + Name);
			Console.WriteLine("Mark1:{0} \tMark2:{1} \tMark2:{2} \t", Mark1, Mark2, Mark3);
		}
		public double Aveage()
		{
			double avg = (Mark1+Mark2+ Mark3)/3;
			return avg;
		}
		public int Sum(int a, int b)
		{
			return (a + b);
		}
		public double Sum(double a, double b)
		{
			return (a + b);
		}
	}
}
