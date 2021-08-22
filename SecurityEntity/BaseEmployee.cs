using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityEntity
{
    public abstract class BaseEmployee
    {
        public Int32 EmployeeId { get; set; }
        public Int32 DesignationId { get; set; }
        public string EmployeeCode { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PresentAddress { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
