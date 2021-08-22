using System;
using System.Text;

namespace SecurityEntity
{

	public class s_Module
	{
		public Int32  ModuleId { get; set; }
		public Int32  DomainId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleNameCustom { get; set; }
        public bool IsActive { get; set; }
        public Int16 DisplayOrder { get; set; }
        public Int32 CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32?  UpdatorId { get; set; }
		public DateTime?  UpdateDate { get; set; }
	}
}
