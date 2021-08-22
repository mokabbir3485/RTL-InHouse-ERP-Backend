using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_OfferDetailBLL //: IDisposible
	{
		public pos_OfferDetailDAO  pos_OfferDetailDAO { get; set; }

		public pos_OfferDetailBLL()
		{
			//pos_OfferDetailDAO = pos_OfferDetail.GetInstanceThreadSafe;
			pos_OfferDetailDAO = new pos_OfferDetailDAO();
		}

		public List<pos_OfferDetail> GetByOfferId(Int64 offerId)
		{
			try
			{
                return pos_OfferDetailDAO.GetByOfferId(offerId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_OfferDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_OfferDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_OfferDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_OfferDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_OfferDetail _pos_OfferDetail)
		{
			try
			{
				return pos_OfferDetailDAO.Add(_pos_OfferDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_OfferDetail _pos_OfferDetail)
		{
			try
			{
				return pos_OfferDetailDAO.Update(_pos_OfferDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 offerDetailId)
		{
			try
			{
				return pos_OfferDetailDAO.Delete(offerDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
