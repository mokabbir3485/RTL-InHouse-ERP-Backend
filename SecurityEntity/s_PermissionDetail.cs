using System;
using System.Text;

namespace SecurityEntity
{
	public class s_PermissionDetail
	{
		public Int64  PermissionDetailId { get; set; }
		public Int64  PermissionId { get; set; }
		public Int32  ScreenDetailId { get; set; }
		public bool  CanExecute { get; set; }
        public Int32 ScreenId { get; set; }
        public string FunctionName { get; set; }
    }
}
