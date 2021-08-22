using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_CustomerAddress : BaseAddress, IEntityBase
	{
        public string CustomerCode { get; set; }
        public string Fax { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
	}
}
