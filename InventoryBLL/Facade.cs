using DbExecutor;

namespace InventoryBLL
{
    public static class Facade
    {
        public static error_LogBLL ErrorLog { get { return new error_LogBLL(); } }
        public static inv_OpeningQuantityBLL OpeningQuantity { get { return new inv_OpeningQuantityBLL(); } }
        public static inv_PurchaseBillBLL PurchaseBill { get { return new inv_PurchaseBillBLL(); } }
        public static inv_PurchaseBillDetailBLL PurchaseBillDetail { get { return new inv_PurchaseBillDetailBLL(); } }
        public static inv_PurchaseBillDetailAdAttributeBLL PurchaseBillDetailAdAttribute { get { return new inv_PurchaseBillDetailAdAttributeBLL(); } }
        public static inv_PurchaseBillDetailAdAttributeDetailBLL PurchaseBillDetailAdAttributeDetail { get { return new inv_PurchaseBillDetailAdAttributeDetailBLL(); } }
        public static inv_PurchaseBillDetailChargeBLL PurchaseBillDetailCharge { get { return new inv_PurchaseBillDetailChargeBLL(); } }
        public static inv_PurchaseBillOverHeadBLL PurchaseBillOverHead { get { return new inv_PurchaseBillOverHeadBLL(); } }
        public static inv_PurchaseOrderBLL PurchaseOrder { get { return new inv_PurchaseOrderBLL(); } }
        public static inv_PurchaseOrderDetailBLL PurchaseOrderDetail { get { return new inv_PurchaseOrderDetailBLL(); } }
        public static inv_PurchaseOrderDetailAdAttributeBLL PurchaseOrderDetailAdAttribute { get { return new inv_PurchaseOrderDetailAdAttributeBLL(); } }
        public static inv_PurchaseOrderDetailAdAttributeDetailBLL PurchaseOrderDetailAdAttributeDetail { get { return new inv_PurchaseOrderDetailAdAttributeDetailBLL(); } }
        public static inv_RequisitionBLL Requisition { get { return new inv_RequisitionBLL(); } }
        public static inv_RequisitionDetailBLL RequisitionDetail { get { return new inv_RequisitionDetailBLL(); } }
        public static inv_ReturnFromDepartmentBLL ReturnFromDepartment { get { return new inv_ReturnFromDepartmentBLL(); } }
        public static inv_ReturnFromDepartmentDetailBLL ReturnFromDepartmentDetail { get { return new inv_ReturnFromDepartmentDetailBLL(); } }
        public static inv_ReturnToSupplierBLL ReturnToSupplier { get { return new inv_ReturnToSupplierBLL(); } }
        public static inv_ReturnToSupplierDetailBLL ReturnToSupplierDetail { get { return new inv_ReturnToSupplierDetailBLL(); } }
        public static inv_StockAuditBLL StockAudit { get { return new inv_StockAuditBLL(); } }
        public static inv_StockAuditDetailBLL StockAuditDetail { get { return new inv_StockAuditDetailBLL(); } }
        public static inv_StockDeclarationBLL StockDeclaration { get { return new inv_StockDeclarationBLL(); } }
        public static inv_StockDeclarationDetailBLL StockDeclarationDetail { get { return new inv_StockDeclarationDetailBLL(); } }
        public static inv_StockIssueBLL StockIssue { get { return new inv_StockIssueBLL(); } }
        public static inv_StockIssueDetailBLL StockIssueDetail { get { return new inv_StockIssueDetailBLL(); } }
        public static inv_StockReceiveBLL StockReceive { get { return new inv_StockReceiveBLL(); } }
        public static inv_StockReceiveDetailBLL StockReceiveDetail { get { return new inv_StockReceiveDetailBLL(); } }
        public static inv_StockValuationBLL StockValuation { get { return new inv_StockValuationBLL(); } }
        public static inv_StockValuationAttributeBLL StockValuationAttribute { get { return new inv_StockValuationAttributeBLL(); } }
        public static inv_StockValuationSetupBLL StockValuationSetup { get { return new inv_StockValuationSetupBLL(); } }
        public static inv_StockValuationTestBLL StockValuationTest { get { return new inv_StockValuationTestBLL(); } }
        public static inv_StoreWiseItemReorderLevelBLL StoreWiseItemReorderLevel { get { return new inv_StoreWiseItemReorderLevelBLL(); } }
        public static inv_StoreWiseItemReorderLevelLogBLL StoreWiseItemReorderLevelLog { get { return new inv_StoreWiseItemReorderLevelLogBLL(); } }
        public static inv_StockDeliveryBLL StockDelivery { get { return new inv_StockDeliveryBLL(); } }
        public static inv_StockDeliveryDetailBLL StockDeliveryDetail { get { return new inv_StockDeliveryDetailBLL(); } }
        public static inv_StockDeclarationDetailAdAttributeBLL StockDeclarationDetailAdAttribute { get { return new inv_StockDeclarationDetailAdAttributeBLL(); } }
        public static inv_StockDeclarationDetailAdAttributeDetailBLL StockDeclarationDetailAdAttributeDetail { get { return new inv_StockDeclarationDetailAdAttributeDetailBLL(); } }
        public static inv_StockDeliveryDetailAdAttributeBLL StockDeliveryDetailAdAttribute { get { return new inv_StockDeliveryDetailAdAttributeBLL(); } }
        public static inv_StockDeliveryDetailAdAttributeDetailBLL StockDeliveryDetailAdAttributeDetail { get { return new inv_StockDeliveryDetailAdAttributeDetailBLL(); } }
        public static inv_RequisitionDetailAdAttributeBLL RequisitionDetailAdAttribute { get { return new inv_RequisitionDetailAdAttributeBLL(); } }
        public static inv_RequisitionDetailAdAttributeDetailBLL RequisitionDetailAdAttributeDetail { get { return new inv_RequisitionDetailAdAttributeDetailBLL(); } }
        public static inv_StockIssueDetailAdAttributeBLL StockIssueDetailAdAttribute { get { return new inv_StockIssueDetailAdAttributeBLL(); } }
        public static inv_ReturnToSupplierDetailAdAttributeBLL ReturnToSupplierDetailAdAttribute { get { return new inv_ReturnToSupplierDetailAdAttributeBLL(); } }
        public static inv_ReturnToSupplierDetailAdAttributeDetailBLL ReturnToSupplierDetailAdAttributeDetail { get { return new inv_ReturnToSupplierDetailAdAttributeDetailBLL(); } }
        public static inv_ReturnFromDepartmentDetailAdAttributeBLL ReturnFromDepartmentDetailAdAttribute { get { return new inv_ReturnFromDepartmentDetailAdAttributeBLL(); } }
        public static inv_ReturnFromDepartmentDetailAdAttributeDetailBLL ReturnFromDepartmentDetailAdAttributeDetail { get { return new inv_ReturnFromDepartmentDetailAdAttributeDetailBLL(); } }
        public static inv_InternalWorkOrderBLL inv_InternalWorkOrderBLL { get { return new inv_InternalWorkOrderBLL(); } }
        public static inv_InternalWorkOrderDetailBLL inv_InternalWorkOrderDetailBLL { get { return new inv_InternalWorkOrderDetailBLL(); } }
        public static inv_InternalWorkOrderDetailReportBLL inv_InternalWorkOrderDetailReportBLL { get { return new inv_InternalWorkOrderDetailReportBLL(); } }
        public static inv_PurchaseRequisitionBLL inv_PurchaseRequisitionBLL { get { return new inv_PurchaseRequisitionBLL(); } }
        public static inv_PurchaseBillDetailSerialBLL inv_PurchaseBillDetailSerialBLL { get { return new inv_PurchaseBillDetailSerialBLL(); } }
        public static pro_ProductionBLL pro_Production { get { return new pro_ProductionBLL(); } }
        public static pro_ProductionDetailBLL pro_ProductionDetail { get { return new pro_ProductionDetailBLL(); } }
        public static inv_StockDeliveryNonSOBLL StockDeliveryNonSO { get { return new inv_StockDeliveryNonSOBLL(); } }
        public static inv_StockDeliveryNonSODetailBLL StockDeliveryNonSODetail { get { return new inv_StockDeliveryNonSODetailBLL(); } }
        public static inv_BillOfMaterialBLL inv_BillOfMaterialBLL { get { return new inv_BillOfMaterialBLL(); } }
        public static proc_SupplierPaymentAndAdjustmentBLL proc_SupplierPaymentAndAdjustmentBLL { get { return new proc_SupplierPaymentAndAdjustmentBLL(); } }

    }
}