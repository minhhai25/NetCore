using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4
{
	/// <summary>
	/// 
	/// OVERLOADING
	/// </summary>
	internal static class NapChong
	{
		/// <summary>
		/// phương thức Sum
		/// </summary>
		/// <param name="a"> số a</param>
		/// <param name="b">số b</param>
		/// <returns>số a+số b</returns>

		public static int Sum(int a, int b)
		{
			return a + b;
		}
		//tên gioonsg nhau giá trị trả về khác nhau
		public static double Sum(double a, double b) 
		{ 
			return a + b; 
		}
		public static int Add(int a, int b)
		{
			return a + b;
		}
		//tên giống nhau số lượng tham số truyền vào khác nhau

		public static int Add(int a, int b, int c)
		{
			return (a + b) + c;
		}
	}
}
