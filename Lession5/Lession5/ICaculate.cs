using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5
{
	internal interface ICaculate
	{
		int Sum (int x, int y);
		int Mul (int x, int y);

	}
	internal interface ICaculator2 {
	int Sub(int x, int y);
		int Div(int x, int y);
	}
	public class Caculator : ICaculate, ICaculator2
	{
		public int Sum (int x, int y)
		{
			return x + y;
		}
		public int Mul (int x, int y)
		{
			return x * y;
		}
		public int Sub(int x, int y)
		{
			return x - y;
		}
		public int Div(int x, int y)
		{
			return x / y;
		}
	}
}
