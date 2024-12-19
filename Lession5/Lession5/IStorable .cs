using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5
{
	internal interface IStorable 
	{
		void Read();
		void Write( object value);
	}
	public class Document: IStorable
	{
		public void Read() {
			Console.WriteLine("Doc du lieu tu tai lieu");
		}
		public void Write( object value ) {
			Console.WriteLine("Ghi du lieu " + value + "vao file");

		}
	}
}
