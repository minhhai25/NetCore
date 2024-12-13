using Lession_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4
{
	internal class Animal
	{
		public Animal() { }
		public Animal(string food , string activity) {
		this.food = food;
			this.activity = activity;
		}
		protected string food;
		protected string activity;

		public void Eat()
		{
			Console.WriteLine("Động vật ăn gì đó");

		}
		public void Dosomething ( ) {
			Console.WriteLine("Động vật làm gì đó");

		}
	}
	internal class Cat : Animal
	{
		//kế thừa contructor
		public Cat() : base("","") { }
		public void Eat()
		{
			Console.WriteLine("mèo ăn gì đó");
		}
		public void Action()
		{
			//Cat c = new Cat();
			//c.Eat();
			Eat();
			//kế thừa phương thức
			base .Dosomething();
			base.Eat();
		}
		public void Show()
		{
			food = "cá";
			activity = "chạy";
			Console.WriteLine("Mèo ăn " + food);
			Console.WriteLine("Mèo " + activity);
		}
	}
}
