using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_BranchGroupBLL
	{
		public ad_BranchGroupDAO ad_BranchGroupDAO { get; set; }

        public ad_BranchGroupBLL()
		{
			ad_BranchGroupDAO = new ad_BranchGroupDAO();
		}

		public List<ad_BranchGroup> GetAll()
		{
			try
			{
				return ad_BranchGroupDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public int Add(ad_BranchGroup _ad_BranchGroup)
        {
            try
            {
                return ad_BranchGroupDAO.Add(_ad_BranchGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
