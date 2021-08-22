using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ExportEntity;
using ExportDAL;

namespace ExportBLL
{
	public class exp_PackingInfoBLL //: IDisposible
	{
		public exp_PackingInfoDAO  exp_PackingInfoDAO { get; set; }

		public exp_PackingInfoBLL()
		{
			//exp_PackingInfoDAO = exp_PackingInfo.GetInstanceThreadSafe;
			exp_PackingInfoDAO = new exp_PackingInfoDAO();
		}

		public List<exp_PackingInfo> GetAll()
		{
			try
			{
				return exp_PackingInfoDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_PackingInfo> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return exp_PackingInfoDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_PackingInfo> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return exp_PackingInfoDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(exp_PackingInfo _exp_PackingInfo)
		{
			try
			{
				return exp_PackingInfoDAO.Add(_exp_PackingInfo);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(exp_PackingInfo _exp_PackingInfo)
		{
			try
			{
				return exp_PackingInfoDAO.Update(_exp_PackingInfo);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateCertificateOfOrigin(exp_PackingInfo _exp_PackingInfo)
        {
            try
            {
                return exp_PackingInfoDAO.UpdateCertificateOfOrigin(_exp_PackingInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Delete(Int64 packingInfoId)
		{
			try
			{
				return exp_PackingInfoDAO.Delete(packingInfoId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
