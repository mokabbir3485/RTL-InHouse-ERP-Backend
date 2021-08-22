using System;
using System.Text;

namespace PosEntity
{
	public class pos_OfferDetail
	{
		public Int64  OfferDetailId { get; set; }
		public Int64  OfferId { get; set; }
        public Int32 ItemId { get; set; }
        public Int32 SaleUnitId { get; set; }
        public Int32 FreeUnitId { get; set; }
	}
}
