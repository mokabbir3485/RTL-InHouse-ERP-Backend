using HrAndPayrollDAL;
using HrAndPayrollEntity;
using System;
using System.Collections.Generic;

namespace HrAndPayrollBLL
{
    public class hr_ShiftBLL //: IDisposible
    {
        public hr_ShiftDAO hr_ShiftDAO { get; set; }

        public hr_ShiftBLL()
        {
            //hr_ShiftDAO = hr_Shift.GetInstanceThreadSafe;
            hr_ShiftDAO = new hr_ShiftDAO();
        }

        public List<hr_Shift> GetAll()
        {
            try
            {
                return hr_ShiftDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_Shift> GetForEntry(Int32 branchId, Int32 attPolicyId, DateTime from, DateTime to, string empIds)
        {
            try
            {
                return hr_ShiftDAO.GetForEntry(branchId, attPolicyId, from, to, empIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_Shift> GetForFinalise(Int32 branchId, Int32 employeeId, DateTime from, DateTime to)
        {
            try
            {
                return hr_ShiftDAO.GetForFinalise(branchId, employeeId, from, to);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_Shift> GetForExcelExport(Int32 branchId, DateTime from, DateTime to)
        {
            try
            {
                return hr_ShiftDAO.GetForExcelExport(branchId, from, to);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_Shift> GetForView(Int32 branchId, Int32 employeeId, DateTime from, DateTime to)
        {
            try
            {
                return hr_ShiftDAO.GetForView(branchId, employeeId, from, to);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_Shift> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return hr_ShiftDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_Shift> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return hr_ShiftDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(hr_Shift _hr_Shift)
        {
            try
            {
                return hr_ShiftDAO.Add(_hr_Shift);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateShift(hr_Shift _hr_Shift)
        {
            try
            {
                return hr_ShiftDAO.UpdateShift(_hr_Shift);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 shiftId)
        {
            try
            {
                return hr_ShiftDAO.Delete(shiftId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_AttendanceSummary> GetAttendanceSummary(DateTime from, DateTime to, Int32 branchId, int gradeId, int employeeId, string departmentId, int sectionId)
        {
            try
            {
                return hr_ShiftDAO.GetAttendanceSummary(from, to, branchId, gradeId, employeeId, departmentId, sectionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_AttendanceDetail> GetAttendanceDetail(DateTime from, DateTime to, int empId)
        {
            try
            {
                return hr_ShiftDAO.GetAttendanceDetail(from, to, empId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_RawPunch> GetRawPunch(int empId, DateTime from, DateTime to)
        {
            try
            {
                return hr_ShiftDAO.GetRawPunch(empId, from, to);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_AttendanceTypeCount> GetAttendanceTypeCount(DateTime date)
        {
            try
            {
                return hr_ShiftDAO.GetAttendanceTypeCount(date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
