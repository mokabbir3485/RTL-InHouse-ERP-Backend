using SecurityDAL;
using SecurityEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SecurityBLL
{
    public class ad_ItemBLL //: IDisposible
    {
        public ad_ItemDAO ad_ItemDAO { get; set; }

        public ad_ItemBLL()
        {
            //ad_ItemDAO = ad_Item.GetInstanceThreadSafe;
            ad_ItemDAO = new ad_ItemDAO();
        }
        public List<exp_RibbonInPerLabelCarton> GetAllSPCase()
        {
            try
            {
                return ad_ItemDAO.GetAllSPCase();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetAll()
        {
            try
            {
                return ad_ItemDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ad_ItemVat> GetItemVatById(Int64 ItemId)
        {

            try
            {
                return ad_ItemDAO.GetItemVatById(ItemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetLimitedProperty()
        {
            try
            {
                return ad_ItemDAO.GetLimitedProperty();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetLimitedPropertyWithAttribute(Int32 departmentId)
        {
            try
            {
                return ad_ItemDAO.GetLimitedPropertyWithAttribute(departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ad_Item GetByItemId(int ItemId)
        {
            try
            {
                return ad_ItemDAO.GetAll(ItemId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetRaw()
        {
            try
            {
                return ad_ItemDAO.GetRaw();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetRawWithoutSelectedItem(Int32 itemId)
        {
            try
            {
                return ad_ItemDAO.GetRawWithoutSelectedItem(itemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return ad_ItemDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return ad_ItemDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(ad_Item ad_Item)
        {
            try
            {
                return ad_ItemDAO.Add(ad_Item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ad_ItemVat_Add(ad_ItemVat ad_ItemVat)
        {
            try
            {
                return ad_ItemDAO.ad_ItemVat_Add(ad_ItemVat);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ad_ItemVat_Update(ad_ItemVat ad_ItemVat)
        {
            try
            {
                return ad_ItemDAO.ad_ItemVat_Update(ad_ItemVat);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(ad_Item ad_Item)
        {
            try
            {
                return ad_ItemDAO.Update(ad_Item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int32 itemId)
        {
            try
            {
                return ad_ItemDAO.Delete(itemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetNBarcode(int qty)
        {
            try
            {
                return ad_ItemDAO.GetNBarcode(qty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetRawMaterialAndCombination()
        {
            try
            {
                return ad_ItemDAO.GetRawMaterialAndCombination();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCombinationWithPrice()
        {
            try
            {
                return ad_ItemDAO.GetCombinationWithPrice();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCombinationByRequisitionId(Int64 requisitionId)
        {
            try
            {
                return ad_ItemDAO.GetCombinationByRequisitionId(requisitionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
