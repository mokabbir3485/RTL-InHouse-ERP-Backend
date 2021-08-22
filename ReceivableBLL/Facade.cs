namespace ReceivableBLL
{
    public static class Facade
    {
        public static rcv_CompanyOpeningBalanceBLL rcv_CompanyOpeningBalance { get { return new rcv_CompanyOpeningBalanceBLL(); } }
        public static rcv_SaleAdjustmentBLL rcv_SaleAdjustment { get { return new rcv_SaleAdjustmentBLL(); } }
        public static rcv_SaleRealizationBLL rcv_SaleRealization { get { return new rcv_SaleRealizationBLL(); } }
        public static rcv_CompanyAdvanceBLL rcv_CompanyAdvance { get { return new rcv_CompanyAdvanceBLL(); } }
    }
}
