using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
	internal interface IStudent
	{
		public int StudId { get; set; }
		public string StudName { get; set; }
		public string StudGender {  get; set; }
		public int StudAge { get; set; }
		public string StudClass {  get; set; }
		public float StudAvgMark {  get;  }
		public void Print();
		
	}
}
