using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_CompanyAddress
    {
        public Int32 AddressId { get; set; }
        public Int32 CompanyId { get; set; }
        public string AddressType { get; set; }
        public string AddressCompanyName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactDesignation { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string VatRegNo { get; set; }
        public string TIN { get; set; }
        public bool IsDefault { get; set; }
    }
}
