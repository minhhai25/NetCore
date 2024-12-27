using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
	internal class Student: IStudent
	{
		public int StudId { get; set; }
		public string StudName { get; set; }
		public string StudGender { get; set; }
		public int StudAge { get; set; }
		public string StudClass { get; set; }
		public float StudAvgMark { get; set; }

		
		private int[] MarkList = new int[3];
		public int this[int index]
		{
			get
			{
				if (index >= 0 && index < MarkList.Length)
				{
					return MarkList[index];
				}
				else
				{
					throw new IndexOutOfRangeException("Index must be between 0 and 2.");
				}
			}
			set
			{
				if (index >= 0 && index < MarkList.Length)
				{
					MarkList[index] = value;
				}
				else
				{
					throw new IndexOutOfRangeException("Index must be between 0 and 2.");
				}
			}
		}

		public void CalAvg()
		{
			StudAvgMark= (MarkList[0] + MarkList[1] + MarkList[2])/3;
		}
		public void Print()
		{
			Console.WriteLine("ID:" + StudId + "| Name:" + StudName + "| Gender:" + StudGender + "| Age:" + StudAge + "| Class:" + StudClass + "| Avg Mark:" + StudAvgMark);
		}
		public void Input()
		{
			Console.Write("Enter Id:");
			this.StudId = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Name :");
			this.StudName = Console.ReadLine();
			Console.Write("Enter gender:");
			this.StudGender = Console.ReadLine();
			Console.Write("Enter class:");
			this.StudClass = Console.ReadLine();
			Console.Write("Enter age:");
			this.StudAge = Convert.ToInt32(Console.ReadLine());
		
		}
	}
}
