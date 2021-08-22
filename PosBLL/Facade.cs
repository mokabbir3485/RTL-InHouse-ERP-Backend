using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PosDAL;
using DbExecutor;

namespace PosBLL
{
    public static class Facade
    {
        public static error_LogBLL ErrorLog { get { return new error_LogBLL(); } }
        public static pos_OfferBLL pos_Offer { get { return new pos_OfferBLL(); } }
        public static pos_OfferDetailBLL pos_OfferDetail { get { return new pos_OfferDetailBLL(); } }
        public static pos_SaleBLL pos_Sale { get { return new pos_SaleBLL(); } }
        public static pos_SaleDetailBLL pos_SaleDetail { get { return new pos_SaleDetailBLL(); } }
        public static pos_SaleDetailAdAttributeBLL pos_SaleDetailAdAttribute { get { return new pos_SaleDetailAdAttributeBLL(); } }
        public static pos_SaleDetailFreeBLL pos_SaleDetailFree { get { return new pos_SaleDetailFreeBLL(); } }
        public static pos_SaleDetailChargeBLL pos_SaleDetailCharge { get { return new pos_SaleDetailChargeBLL(); } }
        public static pos_SalePaymentBLL pos_SalePayment { get { return new pos_SalePaymentBLL(); } }
        public static pos_CashDepositBLL pos_CashDeposit { get { return new pos_CashDepositBLL(); } }
        public static pos_ShiftBLL pos_Shift { get { return new pos_ShiftBLL(); } }
        public static pos_SalesOrderBLL pos_SalesOrderBLL { get { return new pos_SalesOrderBLL(); } }
        public static pos_SalesOrderDetailBLL pos_SalesOrderDetailBLL { get { return new pos_SalesOrderDetailBLL(); } }
        public static pos_POReferenceBLL pos_POReferenceBLL { get { return new pos_POReferenceBLL(); } }
    }
}
