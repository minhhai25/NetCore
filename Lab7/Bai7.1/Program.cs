namespace Bai7._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dongvat.Anco.Bo bo = new Dongvat.Anco.Bo();
			bo.Id = 1;
			bo.Name = "Sua";
			bo.Weight = 250;

			Console.WriteLine("Information Dongvatanco");
			Console.WriteLine("\t Name:" + bo.Name);
			Console.WriteLine("\t Weight:"+ bo.Weight);
		}
	}
}
