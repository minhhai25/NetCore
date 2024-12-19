using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5
{
	internal class Animal
	{
		protected int id {  get; set; }
		protected string name { get; set; }
		protected void Display()
		{
			Console.WriteLine("id:" + id);
			Console.WriteLine("Name" + name);
		}
	}
internal class Cat:Animal { 
	
	}
}
