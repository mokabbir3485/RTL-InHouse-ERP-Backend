using System;
using System.Text;

namespace SecurityEntity
{
	public class s_ScreenLock
	{
		public Int64  ScreenLockId { get; set; }
		public Int32  UserId { get; set; }
		public Int32  ScreenId { get; set; }
        public string Username { get; set; }
    }
}
