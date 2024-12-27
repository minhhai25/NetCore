namespace BT1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>()
			{
				new Student() { StudId = 1, StudName = "Nguyen Van A", StudGender = "Male", StudAge = 20, StudClass = "12A1" },
				new Student() { StudId = 2, StudName = "Tran Thi B", StudGender = "Female", StudAge = 19, StudClass = "11B2" },
				new Student() { StudId = 3, StudName = "Le Van C", StudGender = "Male", StudAge = 21, StudClass = "12C3" },
				new Student() { StudId = 4, StudName = "Pham Thi D", StudGender = "Female", StudAge = 18, StudClass = "10D4" },
				new Student() { StudId = 5, StudName = "Hoang Van E", StudGender = "Male", StudAge = 22, StudClass = "12E5" }
			}
			;

			int n;
			do
			{
				Console.WriteLine("Please select an option");
				Console.WriteLine("-----------------------");
				Console.WriteLine("1. Insert new student");
				Console.WriteLine("2. Display all the student list  ");
				Console.WriteLine("3. Calculate average mark.");
				Console.WriteLine("4. Exit.");
				Console.WriteLine("Option:");
				n = Convert.ToInt32(Console.ReadLine());
				switch (n)
				{
					case 1:
						Student student = new Student();
						student.Input();
						for (int i = 0; i < 3; i++)
						{
							Console.WriteLine("Nhap diem " + (i + 1));
							student[i] = Convert.ToInt32(Console.ReadLine());
						}
						student.CalAvg();
						students.Add(student);
						break;
					case 2:
						if (students.Count > 0)
						{
							foreach (var item in students)
							{
								item.Print();
							}
						}
						else
						{
							Console.WriteLine("List is null Please choose option 1 to enter student information");
						}
						break;
					case 3:
						//Console.WriteLine("Enter ID:");
						////var item1 = new Student();
						////int id;
						//id= Convert.ToInt32(Console.ReadLine());
						if (students.Count > 0)
						{
							foreach (var item in students)
							{

								item.CalAvg();
								Console.WriteLine("Student:{0} | Avg Mark:{1}", item.StudName, item.StudAvgMark);
							};
						}
						else
						{
							Console.WriteLine("Please choose option 1 to enter student information ");
						}
						break;
					case 4:
						Console.WriteLine("Exting...");
						break;
					default:
						break;
				}
			} while (n != 4);
		}
	}
}
