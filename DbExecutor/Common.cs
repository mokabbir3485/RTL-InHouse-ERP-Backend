﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExecutor
{
    public class Common
    {
        public FiscalYear GetFiscalFormDateAndToDate(DateTime date)
        {
            try
            {
                if (date!=DateTime.MinValue)
                {
                    FiscalYear aFiscalYear = new FiscalYear();
                    if (date.Month >2)
                    {
                        aFiscalYear.FromDate = new DateTime(date.Year, 3, 1); //changed 7 to 3
                        aFiscalYear.ToDate = new DateTime(date.Year + 1, 2, 28); //6 to 2 // day 30 to 28
                    }
                    else
                    {
                        aFiscalYear.FromDate = new DateTime(date.Year - 1, 3, 1); //7 to3
                        aFiscalYear.ToDate = new DateTime(date.Year, 2, 28); //6 to 2 // day 30 to 28
                    }

                    return aFiscalYear;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string GetFiscalFormDateAndToDateString(DateTime date)
        {
            try
            {
                if (date != DateTime.MinValue)
                {
                    FiscalYear aFiscalYear = new FiscalYear();
                    if (date.Month > 2)
                    {
                        aFiscalYear.FromDate = new DateTime(date.Year, 3, 1); //7 to 3
                        aFiscalYear.ToDate = new DateTime(date.Year + 1, 2, 28); //6 to 2 // day 30 to 28
                    }
                    else
                    {
                        aFiscalYear.FromDate = new DateTime(date.Year - 1, 3, 1); //7 to 3
                        aFiscalYear.ToDate = new DateTime(date.Year, 2, 28); //6 to 2 // day 30 to 28
                    }

                    return aFiscalYear.FromDate.Year.ToString().Substring(2, 2) + "-" + aFiscalYear.ToDate.Year.ToString().Substring(2, 2);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
    public class FiscalYear
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
