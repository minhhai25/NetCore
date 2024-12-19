namespace Lab7_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Business.House house = new Business.House();
			house.HouseNo = "D294FF";
			house.Price = 121475;

			Console.WriteLine("House Detail");
			Console.WriteLine("\t House No: "+ house.HouseNo);
			Console.WriteLine("\t Price:"+ house.Price);

			Business.Dealership.Car car = new Business.Dealership.Car();

			car.CarNo = "A0999";
			car.Price = 35628.45M;
			Console.WriteLine("Car Detail");
			Console.WriteLine("\t Car No:"+  car.CarNo);
			Console.WriteLine("\t Ptice:" + car.Price);
		}
	}
}
