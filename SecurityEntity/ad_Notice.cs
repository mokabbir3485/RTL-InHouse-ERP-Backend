using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_Notice
	{
		public Int64  NoticeId { get; set; }
		public string  NoticeContent { get; set; }
		public Int32  SenderId { get; set; }
		public string  SenderName { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
