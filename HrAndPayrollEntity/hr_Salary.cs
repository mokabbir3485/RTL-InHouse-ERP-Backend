using System;
using System.Collections.Generic;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_Salary
	{
		public Int64 SalaryId { get; set; }
		public Int32 GradeId { get; set; }
		public Int32 MonthId { get; set; }
		public Int32 YearId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
		public Decimal USDRate { get; set; }
		public string BasicFormula { get; set; }
		public string HouseRentFormula { get; set; }
		public string MedicalFormula { get; set; }
		public string ConveyanceFormula { get; set; }
		public string LunchFormula { get; set; }
		public string FirstSignLabel { get; set; }
		public string SecondSignLabel { get; set; }
		public string ThirdSignLabel { get; set; }
		public string FourthSignLabel { get; set; }
		public string FifthSignLabel { get; set; }
		public Int32 CreatorId { get; set; }
		public DateTime CreateDate { get; set; }
		public Int32? UpdatorId { get; set; }
		public DateTime? UpdateDate { get; set; }
        public List<hr_SalaryDetail> SalaryDetailList { get; set; }
	}
}
