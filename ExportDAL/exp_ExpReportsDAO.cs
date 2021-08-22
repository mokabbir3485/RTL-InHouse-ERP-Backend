using DbExecutor;
using ExportEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExportDAL
{
    public class exp_ExpReportsDAO //: IDisposible
    {
        private static volatile exp_ExpReportsDAO instance;
        private static readonly object lockObj = new object();
        public static exp_ExpReportsDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new exp_ExpReportsDAO();
            }
            return instance;
        }
        public static exp_ExpReportsDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new exp_ExpReportsDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public exp_ExpReportsDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<exp_ExportReports> LoadCI()
        {
            try
            {
                List<exp_ExportReports> exp_ExportReportsList = new List<exp_ExportReports>();
                exp_ExportReportsList = dbExecutor.FetchData<exp_ExportReports>(CommandType.StoredProcedure, "xRpt_loadCI");
                return exp_ExportReportsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //PI html report
        public List<xRpt_exp_PI_Master> GetPiMasterForReport(Int64 invoiceId)
        {
            try
            {
                List<xRpt_exp_PI_Master> exp_InvoiceLst = new List<xRpt_exp_PI_Master>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@InvoiceId", invoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_InvoiceLst = dbExecutor.FetchData<xRpt_exp_PI_Master>(CommandType.StoredProcedure, "xRpt_exp_PI_Master", colparameters);
                return exp_InvoiceLst;
            }
            catch (Exception ex)
            {
                throw ex; 
            }  
        }
        public List<xRpt_exp_CI_Master> GetCiMasterForReport(Int64 commercialInvoiceId)
        {
            try 
            {
                List<xRpt_exp_CI_Master> exp_CommercialInvoiceLst = new List<xRpt_exp_CI_Master>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                }; 
                exp_CommercialInvoiceLst = dbExecutor.FetchData<xRpt_exp_CI_Master>(CommandType.StoredProcedure, "xRpt_exp_CI_Master", colparameters);
                return exp_CommercialInvoiceLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public List<xRpt_exp_CI_Info_Detail> GetCIInfoDetailReport(Int64 commercialInvoiceId)
        {
            try
            {
                List<xRpt_exp_CI_Info_Detail> exp_CommercialInvoiceInfoDetailList = new List<xRpt_exp_CI_Info_Detail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_CommercialInvoiceInfoDetailList = dbExecutor.FetchData<xRpt_exp_CI_Info_Detail>(CommandType.StoredProcedure, "xRpt_exp_CI_Info_Detail", colparameters);
                return exp_CommercialInvoiceInfoDetailList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<xRpt_exp_PI_Detail> GetPiDetailForReport(Int64 invoiceId)
        {
            try
            {
                List<xRpt_exp_PI_Detail> exp_InvoiceDetailList = new List<xRpt_exp_PI_Detail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@InvoiceId", invoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_InvoiceDetailList = dbExecutor.FetchData<xRpt_exp_PI_Detail>(CommandType.StoredProcedure, "xRpt_exp_PI_Detail", colparameters);
                return exp_InvoiceDetailList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_BankDocument> GetBankDocForReport(Int64 commercialInvoiceId)
        {
            try
            {
                List<exp_BankDocument> exp_BankDocument = new List<exp_BankDocument>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_BankDocument = dbExecutor.FetchData<exp_BankDocument>(CommandType.StoredProcedure, "xRpt_exp_BankDocument", colparameters);
                return exp_BankDocument;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_CommercialInvoice> GetBillOfExchangeForReport(Int64 commercialInvoiceId,string DocType)
        {
            try
            {
                List<exp_CommercialInvoice> exp_CommercialInvoice = new List<exp_CommercialInvoice>();
                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@DocType", DocType, DbType.String, ParameterDirection.Input)
                };
                exp_CommercialInvoice = dbExecutor.FetchData<exp_CommercialInvoice>(CommandType.StoredProcedure, "xRpt_exp_BillOfExchange", colparameters);
                return exp_CommercialInvoice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<xRpt_exp_ConsumptionCertificate> GetConsumptionCertificateReport(Int64 commercialInvoiceId)
        {
            try
            {
                List<xRpt_exp_ConsumptionCertificate> exp_CommercialInvoiceConsumptionCertificates = new List<xRpt_exp_ConsumptionCertificate>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_CommercialInvoiceConsumptionCertificates = dbExecutor.FetchData<xRpt_exp_ConsumptionCertificate>(CommandType.StoredProcedure, "xRpt_exp_ConsumptionCertificate", colparameters);
                return exp_CommercialInvoiceConsumptionCertificates;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificateDescription> GetConsumptionCertificateDescriptionReport(Int64 commercialInvoiceId)
        {
            try
            {
                List<exp_ConsumptionCertificateDescription> exp_ConsumptionCertificateDescription = new List<exp_ConsumptionCertificateDescription>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_ConsumptionCertificateDescription = dbExecutor.FetchData<exp_ConsumptionCertificateDescription>(CommandType.StoredProcedure, "xRpt_exp_ConsumptionCertificateDescription", colparameters);
                return exp_ConsumptionCertificateDescription;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificateRawMaterials> GetConsumptionCertificateRawMaterialsReport(Int64 commercialInvoiceId)
        {
            try
            {
                List<exp_ConsumptionCertificateRawMaterials> exp_ConsumptionCertificateRawMaterials = new List<exp_ConsumptionCertificateRawMaterials>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_ConsumptionCertificateRawMaterials = dbExecutor.FetchData<exp_ConsumptionCertificateRawMaterials>(CommandType.StoredProcedure, "xRpt_exp_ConsumptionCertificateRawMaterials", colparameters);
                return exp_ConsumptionCertificateRawMaterials;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<exp_ExportReports> GetCertificateOfOrigin(Int64 CommercialInvoiceId, string CertificateType)
        {
            try
            {
                List<exp_ExportReports> exp_ExportReportsList = new List<exp_ExportReports>();
                Parameters[] colparameters = new Parameters[2]
                {
                    new Parameters("@CommercialInvoiceId",CommercialInvoiceId,DbType.Int64,ParameterDirection.Input),
                    new Parameters("@CertificateType",CertificateType,DbType.String,ParameterDirection.Input)


                };
                exp_ExportReportsList = dbExecutor.FetchData<exp_ExportReports>(CommandType.StoredProcedure, "xRpt_exp_CertificateOfOriginOrPreInspection", colparameters);
                return exp_ExportReportsList;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public List<exp_ExportReports> GetDeliveryChalanGetReport(Int64 CommercialInvoiceId)
        {
            try
            {
                List<exp_ExportReports> chalan2Report = new List<exp_ExportReports>();
                Parameters[] colsprameter = new Parameters[1] {
                    new Parameters("@CommercialInvoiceId",CommercialInvoiceId,DbType.Int64,ParameterDirection.Input)
                };

                chalan2Report = dbExecutor.FetchData<exp_ExportReports>(CommandType.StoredProcedure, "xRpt_exp_DeliveryChallan", colsprameter);
                return chalan2Report;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<exp_ExportReports> GetDeliveryChalanGetReportDetails(Int64 CommercialInvoiceId)
        {
            try
            {
                List<exp_ExportReports> chalan2Report = new List<exp_ExportReports>();
                Parameters[] colsprameter = new Parameters[1] {
                    new Parameters("@CommercialInvoiceId",CommercialInvoiceId,DbType.Int64,ParameterDirection.Input)
                };

                chalan2Report = dbExecutor.FetchData<exp_ExportReports>(CommandType.StoredProcedure, "xRpt_exp_DeliveryChallan_Details", colsprameter);
                return chalan2Report;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
