namespace Lession_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			
			////nạp chồng phương thức
			//int tong = NapChong.Sum(1, 2);
			//Console.WriteLine("Phương thức int Sum ,Tổng của 1 và 2 là {0}", tong);
			//double tong2 = NapChong.Sum(1.46d, 2.78d);
			//Console.WriteLine("Phương thức double Sum ,Tổng của 1d và 2d là {0:0.#0}", tong2);
			//int tong3 = NapChong.Add(2, 3);
			//Console.WriteLine("Phương thức Add 2 tham số là {0}",tong3);
			//int tong4 = NapChong.Add(1,2,3);
			//Console.WriteLine("Phương thức Add 3 tham số là {0}", tong4);
			////nạp chồng contructor
			//Student student = new Student();
			//student.Id = 1;
			//student.Name = "Test";
			//student.Age = 30;
			//student.Display();

			//Student student2 = new Student(3,"Devmaster",22);
			//student2.Display();

			//Student student1 = new Student(4, "Devmater2");
			//student1.Display();

			Cat cat = new Cat();
			cat.Action();
			cat.Show();
			Department department = new Department();
			department.Display();

			Staff staff= new Staff(1,"Devmaster",22,"07997857","25 Vũ ngọc phan",123);
			staff.Display();

			Employee2 employee2 = new Employee2("Devmaster",222);
			employee2.Caculatorpay();
			
		}
	}
}
