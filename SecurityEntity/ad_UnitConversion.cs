using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_UnitConversion
	{
		public int UnitId { get; set; }
		public string UnitSymbol { get; set; }
		public string UnitName { get; set; }
		public Decimal ConversionRate { get; set; }
		public int MinUnitId { get; set; }
	}
}
