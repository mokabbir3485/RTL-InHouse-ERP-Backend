using System;
using System.Text;

namespace SecurityEntity
{
	public class s_ScreenDetail
	{
		public Int32  ScreenDetailId { get; set; }
        public Int32 ScreenId { get; set; }
        public Int32 FunctionId { get; set; }
		public string  FunctionName { get; set; }
        //public bool CanExecute { get; set; }
	}
}
