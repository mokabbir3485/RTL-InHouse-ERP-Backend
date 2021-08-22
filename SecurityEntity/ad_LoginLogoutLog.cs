using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_LoginLogoutLog
	{
		public Int64  LoginLogoutLogId { get; set; }
		public Int32  UserId { get; set; }
		public DateTime  LogInTime { get; set; }
		public DateTime?  LogOutTime { get; set; }
		public string  IpAddress { get; set; }
		public bool  IsLoggedIn { get; set; }
	}
}
