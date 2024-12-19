namespace Lession5
{
	internal class Program
	{
		static void Main(string[] args)
		{
				
			Employee employee = new Employee();
			employee.Work();
			employee.Run();
			employee.Speak();

			// mảng
			//mảng 1 chiều
			//Khai báo mnagr 1 chiều 
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			int[] number;
			//kha báo và khởi tạo số pahanf tử
			int[] number1 = new int[6];
			//khai báo mảng 1 chiều và khởi tạo giá trị
			int[] number2= new int[] { 1,3,5,7,4,9};
			int[] number3 = { 1, 3, 4, 5, 6, 7, 8, 9 };


			//truy cập các phần tử mảng

			Console.WriteLine("Vị trí số 4 của mảng number2[3]là{0}", number2[3]);
			//lấy số lượng phần tử của mảng
			Console.WriteLine("Số lượng phần tử của mảng number2:{0}",number2.Length);
			//duyệt mảng
			for(int i = 0; i < number2.Length; i++)
			{
				Console.WriteLine(number2[i]);
			}
			for(int i = 0;i < number2.Length; i++)
			{
				number2[i]++;
				Console.WriteLine(i+""+number2[i]);
			}
			Console.WriteLine("----------------");
			foreach(int nb in number2) {
			Console.WriteLine(nb);

			}

			// khai báo mảng 2 chiều hình chữ nhật
			// 2 chiều hình chữ nhật
			int[,] mang2chieu = new int[3, 4];
			//khai báo mnagr 2 chiều và khởi tạo giá trị 
			int[,] mang2chieu2 =
			{
				{3,5,6,9 },
				{5,7,8,10},
				{6,9,10,11},
			};
			for(int i = 0;i<mang2chieu2.GetLength(0);i++)
			{
				Console.WriteLine("Dong:{0}\t", i);
				for(int j = 0; j < mang2chieu2.GetLength(1); j++)
				{
					Console.WriteLine(mang2chieu2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			//2 chiều zic zac 
			int[][] mang2chieu3= new int[3][];
			mang2chieu3[0] = new int[] { 8, 68, 34, 54 };
			mang2chieu3[1] = new int[] { 44, 55 };
			mang2chieu3[2] = new int[] { 43 };
			//duyet mang 2 chiều zic zac
			Console.WriteLine();
			for(int i = 0; i < mang2chieu3.GetLength(0); i++)
			{

				Console.WriteLine("Dong{0}", i);
				for(int j = 0; j < mang2chieu3[i].Length; j++)
				{
					Console.WriteLine(mang2chieu3[i][ j] + "\t");
				}
				Console.WriteLine();
			}
			//Array
			int[] numbers = new int[] { 23, 34, 56, 65, 32, 23 };
			//Sort- sắp xếp
			Array.Sort(numbers);
			for(int i = 0;i < numbers.Length; i++)
			{
				Console.WriteLine("vị trí thứ " + i + "\t" + numbers[i]);

			}
			//phương thức đảo ngược
			Array.Reverse(numbers);
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine("vị trí thứ " + i + "\t" + numbers[i]);

			}
			//Tìm kiếm trong Array
			Console.WriteLine("-------------") ;
			int index1 = Array.IndexOf(numbers, 11);
			int index2= Array.LastIndexOf(numbers, 11);

			Console.WriteLine("Vị trí của số" + numbers[index1] + "Sử dụng IndexOf" + index1);
			Console.WriteLine("Vị trí của số" + numbers[index2] + "Sử dụng LastIndexOf" + index2);

			//Thay đổi số phần tủ
			Console.WriteLine("Số phần tử trong mnagr numbers:" + numbers.Length);
			Array.Resize(ref numbers, 9);
			Console.WriteLine("Số lượng pphanaf tử trong mảng sau khi resize:" + numbers.Length);
			numbers[8] = 55;
		}
	}
}
