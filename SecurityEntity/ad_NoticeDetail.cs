using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_NoticeDetail
	{
		public Int64  NoticeDetailId { get; set; }
		public Int64  NoticeId { get; set; }
		public Int32  UserId { get; set; }
		public bool  IsRead { get; set; }
	}
}
