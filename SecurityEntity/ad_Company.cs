using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_Company
    {
        public Int32 CompanyId { get; set; }
        public Int32 CompanyTypeId { get; set; }
        public Int32 RefEmployeeId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Web { get; set; }
        public bool IsActive { get; set; }
        public bool IsPayable { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32? UpdatorId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Status { get; set; }
        public string CompanyTypeName { get; set; }
        public string RefEmail { get; set; }
        public string RefContactNo { get; set; }
       
        public string CompanyNameBilling { get; set; }
        public string AddressBilling { get; set; }
        public string CompanyNameDelivery { get; set; }
        public string AddressDelivery { get; set; }

    }
}
