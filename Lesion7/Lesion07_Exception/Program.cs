using System.Reflection.Metadata;
using System.Security.Authentication;

namespace Lesion07_Exception
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int number;
			//Console.WriteLine("Nhập vào 1 số:");
			//number = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(number);
			int a =1 ,b=0 ,c ;
			
			try
			{
				c = a/ b;
				Console.WriteLine(a + "/" + b+ "="+c);
			}catch (ArithmeticException ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine("Devmaster");
			try
			{
				c = a / b;
				Console.WriteLine(a + "/" + b + "=" + c);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}

			//th không biết thuộc exception nào
			try
			{
				c = a / b;
				Console.WriteLine(a + "/" + b + "=" + c);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}



			string[] names = { "devmaster", " Khoa", "Vương", "Hương", "Tiến" };
			try
			{
				Console.WriteLine("Khối try catch ngoài");
				try
				{
					c = a / b;
					Console.WriteLine(a + "/" + b + "=" + c);
				}
				catch(Exception ex)
				{
					Console.WriteLine("khoi try catch trong");
					Console.WriteLine(ex.Message);
				}
				names[9] = "Anh";
			}
			catch(IndexOutOfRangeException ex) {
				Console.WriteLine("Khối try catch ngoài");
				Console.WriteLine(ex.Message);
			}
			//nhiều khối catch
			//Lưu ý:
			//khối catch bên trên phải là tập con của khối catch bên dưới
			//hoặc khối catch bên duoiws và khối catch bên trên là 2 tập khác nhau
			try
			{
				c = a / b;
				Console.WriteLine(a + "/" + b + "=" + c);
				names[9] = "Anh";
			}
			catch (ArithmeticException ex)
			{
				//logic1
				b = 1;
				Console.WriteLine("khoi try catch trong");
				Console.WriteLine(ex.Message);
			}
			catch(IndexOutOfRangeException ex)
			{
				//logic2
				Array.Resize<string>(ref names, 10);
				names[9] = "Khoa";
				Console.WriteLine(ex.Message);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			//finally
			try
			{
				c = a / b;
				Console.WriteLine(a + "/" + b + "=" + c);
			}
			catch (ArithmeticException ex)
			{
				Console.WriteLine("khoi try catch ");
				Console.WriteLine(ex.Message);
			}
			finally { Console.WriteLine("Khối finally"); }

			//tụ xây dựng exception
			Product product = new Product();
			try
			{
				product.Price = -2;
			}catch(InvalidPriceException ex) {
			Console.WriteLine( ex.Message);
			}
		}
	}
}
