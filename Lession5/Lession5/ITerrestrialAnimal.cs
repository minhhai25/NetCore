using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5
{
	internal interface ITerrestrialAnimal
	{
		void Eat();
	}
	internal interface IMarineAnimal
	{
		void Eat();
	}
	public class Crocodie : ITerrestrialAnimal, IMarineAnimal
	{
		void ITerrestrialAnimal.Eat()
		{
			Console.WriteLine("ITerrestrialAnimal eat");
		}
		void IMarineAnimal.Eat()
		{
			Console.WriteLine("IMarineAnimal eat");
		}
		public void TerrestrialAnimalEat()
		{
			ITerrestrialAnimal ta = this;
			ta.Eat();
		}
		public void MarineAnimalEat()
		{
			IMarineAnimal ma = this;
			ma.Eat();
		}
	}
}
