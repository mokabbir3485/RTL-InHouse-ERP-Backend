using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_OfferBLL //: IDisposible
	{
		public pos_OfferDAO  pos_OfferDAO { get; set; }

		public pos_OfferBLL()
		{
			//pos_OfferDAO = pos_Offer.GetInstanceThreadSafe;
			pos_OfferDAO = new pos_OfferDAO();
		}

		public List<pos_Offer> GetAll()
		{
			try
			{
				return pos_OfferDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Offer> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_OfferDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Offer> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_OfferDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_Offer _pos_Offer)
		{
			try
			{
				return pos_OfferDAO.Add(_pos_Offer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_Offer _pos_Offer)
		{
			try
			{
				return pos_OfferDAO.Update(_pos_Offer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 offerId)
		{
			try
			{
				return pos_OfferDAO.Delete(offerId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetItemOfferInfo(DateTime saleDate, int itemId, int saleUnitId, decimal quantity)
        {
            try
            {
                return pos_OfferDAO.GetItemOfferInfo(saleDate, itemId, saleUnitId, quantity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetTopPrecentageOff(DateTime saleDate)
        {
            try
            {
                return pos_OfferDAO.GetTopPrecentageOff(saleDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
