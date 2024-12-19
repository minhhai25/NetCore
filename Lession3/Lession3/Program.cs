using System.Text;
using System.Xml.Linq;

namespace Lession3
{
	internal class Program
	{
		/// <summary>
		/// CẤU TRÚC LẶP
		/// OOP
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			////for
			//for (int i = 0; i <= 10; i++)
			//{
			//	Console.WriteLine("vòng lặp thứ i:{0}",i);
			//}
			////do..while...
			//int j = 5;
			//do
			//{
			//	Console.WriteLine("Đây là vòng lặp do...while..");
			//	j++;
			//} while (j==5);
			//	j=5;
			//do
			//{
			//	Console.WriteLine("Đây là vòng lặp do while với j<7");
			//	j++;
			//}while (j<7);
			////while 
			//j = 5;
			//while (j != 7) { 
			//Console.WriteLine("Đây là vòng lặp while ");
			//j++;
			//}
			////foreach
			//int[] lstInt = { 1, 2, 3, 4, 56, 5 };

			//foreach (int i in lstInt) {
			//Console.WriteLine(i);
			//}
			//Category category = new Category();
			//category.ID = 1;
			//category.Name = "Test";
			//category.Display();
			//Console.WriteLine("ID : {0} \t Name: {1}", category.ID, category.Name);

			//Employee employee = new Employee();
			////employee.ID = 2;
			//employee.Name = "Devmaster";
			//employee.Age = 30;
			//employee.Display();
			//Console.WriteLine("Id:" + employee.ID);
			////Console.WriteLine("Name:" + employee.Name);
			//Console.WriteLine("Age:" + employee.Age);


			//Student student= new Student();
			//student.Mark1 = 6;
			//student.Mark2 = 7;
			//student.Mark3 = 8;
			//student.Id = 1;
			//student.Name = "Nguyễn văn a";
			//student.Display();
			//double avg = student.Aveage();
			//Console.WriteLine("Điểm trung bình là {0}", student.Aveage());
			//Console.WriteLine("Diem trung binh la {0}", avg);

			//int sum = student.Sum(1, 3);
			//double sum2 = student.Sum(1.4d, 4.5d);
			//Console.WriteLine("Tong 1:{0}", sum);
			//Console.WriteLine("Tong 2 :{0}", sum2);

			//TestTinh.Id = 1;
			//TestTinh.Name = "TestTinh";
			//TestTinh.Display();


			//int a = 10, b = 20;
			//double area;
			//// truyền tha trị 
			//Number.Swap(a, b);
			//Console.WriteLine("a:{0} \t b:{1}",a,b);
			////truyền tam chiếu
			//	Number.Swap(ref a,ref b);
			//Console.WriteLine("a:{0} \t b:{1}", a, b);

			//Number.Cal(out area , 2);
			//Console.WriteLine("area:{0}", area);
			Employee employee = new Employee(3,"Devmaster",4);
			employee.Display();

		}
	}
}
