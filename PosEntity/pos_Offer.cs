using System;
using System.Text;

namespace PosEntity
{
	public class pos_Offer
	{
		public Int64  OfferId { get; set; }
		public Int32  RoleId { get; set; }
		public string  OfferName { get; set; }
        public bool HasDateRange { get; set; }
        public DateTime StartDate { get; set; }
		public DateTime  EndDate { get; set; }
		public Int32  OfferTypeId { get; set; }
		public Int32  OffPercentage { get; set; }
		public Decimal  OffAmount { get; set; }
		public Decimal  ManualAmount { get; set; }
		public Int32  BuyCount { get; set; }
		public Int32  FreeCount { get; set; }
		public Int32  ApplyOnTypeId { get; set; }
		public Decimal  MaxLimitAmount { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
