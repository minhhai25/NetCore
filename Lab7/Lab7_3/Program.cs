namespace Lab7_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte[] a = new byte[5];
			try
			{
				for(int i=0; i<=5; i++)
				{
					Console.WriteLine("a[{0}]=",i+1);
					a[i]= Convert.ToByte(Console.ReadLine());
				}
			}catch (FormatException ex) {
				Console.WriteLine("khong duoc nhap ki tu vao mang");
			}catch(OverflowException ex)
			{
				Console.WriteLine("khong duoc nhap ki tu ngoia mien 0-255");
			}catch(IndexOutOfRangeException ex)
			{
				Console.WriteLine("Loi vuot qua pham vi cua mang");
			}
			Console.WriteLine("Noi dung mang");
			for(int i=0; i<=5;i++)
			{
				Console.WriteLine("{0}", a[i]);
			}
		}
	}
}
