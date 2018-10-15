using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_Entity;
using EMS_DAL;
using EMS_Exception;
using System.Data;
using System.Data.SqlClient;

namespace EMS_BLL
{
    public class EmployeeValidations
    {
        EmployeeOperations empOperation;
        public DataTable LoadDeparment_BLL()
        {
            DataTable dtDept;
            try
            {
                empOperation = new EmployeeOperations();
                dtDept = empOperation.LoadDeparment();
            }
            catch (SqlException se)
            {

                throw se;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dtDept;
        }

        public DataTable GetEmployee_BLL()
        {
            DataTable dtEmp;
            try
            {
                empOperation = new EmployeeOperations();
                dtEmp = empOperation.GetEmployee();
            }
            catch (SqlException se)
            {

                throw se;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dtEmp;
        }

        public bool validateEmp(Employee newEmp)
        {
            bool isValidEmp = true;
            StringBuilder sbError = new StringBuilder();
            try
            {
                if (newEmp.EmployeeName == string.Empty)
                {
                    isValidEmp = false;
                    sbError.Append("Please enter the Employee Name");
                }
                if (!isValidEmp) throw new EmployeeException(sbError.ToString());
            }
            catch (EmployeeException ex)
            { throw ex; }

            return isValidEmp;
        }
        public int AddEmployee_BLL(Employee newEmp)
        {
            int rowsAffected = 0;
            EmployeeOperations operationObj;
            try
            {
                if (validateEmp(newEmp))
                {
                    operationObj = new EmployeeOperations();
                    rowsAffected = operationObj.AddEmployee(newEmp);
                }
            }
            catch (EmployeeException ex) { throw ex; }
            catch (SqlException se) { throw se; }
            catch (Exception ex) { throw ex; }
            return rowsAffected;

        }

    }
}



    }
}
