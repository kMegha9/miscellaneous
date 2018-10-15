using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_Entity;
using EMS_Exception;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace EMS_DAL
{
    public class EmployeeOperations
    {
        static string empConnStr = ConfigurationManager.ConnectionStrings["conStr"].ToString();
        static SqlConnection empConnObj;
         SqlCommand Empcommand;
         DataTable dtemp, dtdept;
         SqlDataReader emprdr = null;
         public EmployeeOperations()
{
       empConnObj = new SqlConnection();
       empConnObj.ConnectionString = empConnStr;

        
}
public DataTable LoadDepartment()
try
{ 
  dtdept = new DataTable();
Empcommand =new SqlCommand("Megha.usp_GetDepartment",empConnObj);
EmpCommand.CommandType = CommandType.StoredProcedure;
empConnObj.Open();
emprdr = Empcommand.ExecuteReader();
dtDept.Load(emprdr);
}
catch(SqlException)
{
throw;
}
catch(Exception)
{
throw;
}
finally
{
emprdr.Close();
if (empConnObj.State == ConnectionState.Open)
     empConnObj.Close();

}

return dtdept;
}

public int AddEmployee(Employee emp)
{
 int rowsAffected = 0;
try
{
EmpCommand =new SqlCommand("Megha.usp_AddEmployee",empConnObj);
EmpCommand.CommandType = CommandType.StoredProcedure;
EmpCommand.Parameters.AddWithValue("@eName", emp.EmployeeName);
EmpCommand.Parameters.AddWithValue("@eLoc", emp.EmployeeLoc);
EmpCommand.Parameters.AddWithValue("@ePhone", emp.EmployeeContact);
EmpCommand.Parameters.AddWithValue("@edepId", emp.EmployeeDept);
empConnObj.Open();
rowsAffected = EmpCommand.ExecuteNonQuery();
}
catch(SqlException)
{
 throw;
}
catch(Exception)
{
throw;
}
finally
{
if (empConnObj.State == ConnectionState.Open)
     empConnObj.Close();
}
return rowsAffected;
}

public DataTable GetEmployee()
try
{ 
  dtdEmp = new DataTable();
Empcommand =new SqlCommand("Megha.usp_GetEmployee",empConnObj);
EmpCommand.CommandType = CommandType.StoredProcedure;
empConnObj.Open();
emprdr = Empcommand.ExecuteReader();
if(emprdr=HasRows)
{
dtEmp.Load(emprdr);
}
catch(SqlException ex)
{
 throw;
}
catch(Exception ex)
{
throw;
}
finally
{
if (empConnObj.State == ConnectionState.Open)
     empConnObj.Close();
}
return dtemp;
}

     }  
    }







         



    

