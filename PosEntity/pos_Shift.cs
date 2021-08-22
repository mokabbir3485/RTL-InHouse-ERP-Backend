using System;
using System.Text;

namespace PosEntity
{
	public class pos_Shift
	{
		public Int64  ShiftId { get; set; }
		public Int32  DepartmentId { get; set; }
		public Int32  UserId { get; set; }
		public Int32  CurrencyId { get; set; }
		public DateTime  OpenTime { get; set; }
		public Decimal  SystemOpenCash { get; set; }
		public Decimal  InputOpenCash { get; set; }
		public Decimal  OwnCashIn { get; set; }
		public bool  IsClose { get; set; }
		public DateTime?  CloseTime { get; set; }
		public Decimal?  WithdrawnCash { get; set; }
		public Decimal?  SystemCloseBalance { get; set; }
		public Decimal?  InputCloseBalance { get; set; }
		public Decimal?  SystemCloseCash { get; set; }
		public Decimal?  InputCloseCash { get; set; }
        public Decimal? OwnCashOut { get; set; }
        public Int32 BranchId { get; set; }
        public string GroupName { get; set; }
        public string BranchName { get; set; }
        public string DepartmentName { get; set; }
        public string EmployeeName { get; set; }
    }
}
