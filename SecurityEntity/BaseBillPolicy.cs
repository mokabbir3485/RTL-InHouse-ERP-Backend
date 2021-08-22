using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityEntity
{
    public abstract class BaseBillPolicy
    {
        public int PolicyId { get; set; }
        public string PolicyDescription { get; set; }
    }
}