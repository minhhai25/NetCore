namespace Lab4_2
{
	// Lớp trừu tượng Student
	abstract class Student
	{
		// Các trường dữ liệu
		public string name;
		public int year;

		// Constructor của Student
		public Student(string name, int year)
		{
			this.name = name;
			this.year = year;
		}

		// Phương thức hiển thị
		public virtual void Display()
		{
			Console.WriteLine($"Student Name: {name}, Year: {year}");
		}

		// Phương thức trừu tượng Average
		public abstract double Average();
	}

	// Lớp StudentCollege kế thừa từ Student
	class StudentCollege : Student
	{
		// Các trường điểm số
		public double score1;
		public double score2;
		public double score3;

		// Constructor của StudentCollege
		public StudentCollege(string name, int year, double score1, double score2, double score3)
			: base(name, year)
		{
			this.score1 = score1;
			this.score2 = score2;
			this.score3 = score3;
		}

		// Ghi đè phương thức Average
		public override double Average()
		{
			return (score1 + score2 + score3) / 3;
		}

		// Phương thức hiển thị mới
		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Scores: {score1}, {score2}, {score3}, Average: {Average():F2}");
		}
	}

	// Lớp StudentUniversity kế thừa từ StudentCollege
	class StudentUniversity : StudentCollege
	{
		// Trường điểm số mới
		public double score4;

		// Constructor của StudentUniversity
		public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4)
			: base(name, year, score1, score2, score3)
		{
			this.score4 = score4;
		}

		// Ghi đè phương thức Average
		public override double Average()
		{
			return (score1 + score2 + score3 + score4) / 4;
		}

		// Phương thức hiển thị mới
		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Score4: {score4}, Updated Average: {Average():F2}");
		}
	}

	// Lớp chính Program để kiểm thử
	class Program
	{
		static void Main(string[] args)
		{
			// Tạo đối tượng StudentCollege
			StudentCollege collegeStudent = new StudentCollege("Alice", 2, 8.5, 7.5, 9.0);
			Console.WriteLine("College Student Info:");
			collegeStudent.Display();

			// Tạo đối tượng StudentUniversity
			StudentUniversity universityStudent = new StudentUniversity("Bob", 3, 8.0, 8.5, 9.0, 7.5);
			Console.WriteLine("\nUniversity Student Info:");
			universityStudent.Display();

			Console.ReadKey(); // Đợi nhấn phím để kết thúc chương trình
		}
	}

}
