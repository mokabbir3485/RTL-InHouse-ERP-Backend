using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_ItemSubCategory : IEntityBase
	{
		public Int32  SubCategoryId { get; set; }
		public Int32  CategoryId { get; set; }
		public Int32  AssetNatureId { get; set; }
		public Int32  SubCategoryTypeId { get; set; }
		public string  SubCategoryName { get; set; }
		public string  SubShortName { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string CategoryName { get; set; }
        public string AssetNatureName { get; set; }
        public string SubCategoryTypeName { get; set; }
        public string Status { get; set; }
	}
}
