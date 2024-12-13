using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4
{
	internal class Employee2
	{
		public string name;
		protected decimal basepay ;
		public Employee2(string name,decimal basepay)
		{
			this.name = name;
			this.basepay = basepay;
		}
		public virtual decimal Caculatorpay (){  return basepay;  }
	}
	internal class SalesEmployee: Employee2
	{
		private decimal salesbonus;
		public SalesEmployee(string name,decimal basepay,decimal salesbonus) : base (name,basepay)
		{

			this.salesbonus = salesbonus;
		}
		public override decimal Caculatorpay()
		{
			return basepay + salesbonus;
		}
	}
}
