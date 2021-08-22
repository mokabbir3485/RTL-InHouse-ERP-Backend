namespace PayableBLL
{
    public static class Facade
    {
        public static pay_SupplierOpeningBalanceBLL pay_SupplierOpeningBalance { get { return new pay_SupplierOpeningBalanceBLL(); } }
        //public static rcv_SaleAdjustmentBLL rcv_SaleAdjustment { get { return new rcv_SaleAdjustmentBLL(); } }
        public static pay_PurchaseRealizationBLL pay_PurchaseRealization { get { return new pay_PurchaseRealizationBLL(); } }
        public static pay_SupplierAdvanceBLL pay_SupplierAdvance { get { return new pay_SupplierAdvanceBLL(); } }
    }
}
