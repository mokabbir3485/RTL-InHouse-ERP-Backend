using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemCategory
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string ShortName { get; set; }
		public bool IsActive { get; set; }
		public int CreatorId { get; set; }
		public DateTime CreateDate { get; set; }
		public Nullable<int> UpdatorId { get; set; }
		public Nullable<DateTime> UpdateDate { get; set; }
        public string Status { get; set; }
	}
}
