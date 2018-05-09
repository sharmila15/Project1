using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Activities.Statements;



namespace Adodem
{
   
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String address { get; set; }
        public String phnNumber { get; set; }
        public String Gender { get; set; }
        public String HomePhn { get; set; }


        public Employee()
        {

        }
        
        public int AddEmployee()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spAddEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter IdParam = new SqlParameter();
                    IdParam.ParameterName = "@EmpId";
                    IdParam.SqlDbType = SqlDbType.Int;
                    IdParam.Direction = ParameterDirection.Output;
                    IdParam.Size = 0;
                    IdParam.Value = this.Id;
                    cmd.Parameters.Add(IdParam);

                    SqlParameter fnParam = new SqlParameter();
                    fnParam.ParameterName = "@EmpFn";
                    fnParam.SqlDbType = SqlDbType.VarChar;
                    fnParam.Direction = ParameterDirection.Input;
                    fnParam.Size = 50;
                    fnParam.Value = this.FirstName;
                    cmd.Parameters.Add(fnParam);

                    SqlParameter lnParam = new SqlParameter();
                    lnParam.ParameterName = "@EmpLn";
                    lnParam.SqlDbType = SqlDbType.VarChar;
                    lnParam.Direction = ParameterDirection.Input;
                    lnParam.Size = 50;
                    lnParam.Value = this.LastName;
                    cmd.Parameters.Add(lnParam);

                    SqlParameter addressparam = new SqlParameter();
                    addressparam.ParameterName = "@EmpAddress";
                    addressparam.SqlDbType = SqlDbType.VarChar;
                    addressparam.Direction = ParameterDirection.Input;
                    addressparam.Size = 50;
                    addressparam.Value = this.address;
                    cmd.Parameters.Add(addressparam);

                    SqlParameter phnparam = new SqlParameter();
                    phnparam.ParameterName = "@EmpPhno";
                    phnparam.SqlDbType = SqlDbType.NChar;
                    phnparam.Direction = ParameterDirection.Input;
                    phnparam.Size = 10;
                    phnparam.Value = this.phnNumber;
                    cmd.Parameters.Add(phnparam);

                    SqlParameter genderparam = new SqlParameter();
                    genderparam.ParameterName = "@Gender";
                    genderparam.SqlDbType = SqlDbType.VarChar;
                    genderparam.Direction = ParameterDirection.Input;
                    genderparam.Size = 50;
                    genderparam.Value = this.Gender;
                    cmd.Parameters.Add(genderparam);

                    cmd.ExecuteNonQuery();

                    this.Id = Convert.ToInt32(IdParam.Value);

                }
                return this.Id;
            }
            catch
            {
                return -1;
            }
        }

        public void addHomePhn(int id, String phn)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spAddIdPhn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter EmpIdParam = new SqlParameter();
                    EmpIdParam.ParameterName = "@EmpId";
                    EmpIdParam.SqlDbType = SqlDbType.Int;
                    EmpIdParam.Direction = ParameterDirection.Input;
                    EmpIdParam.Size = 0;
                    EmpIdParam.Value = this.Id;
                    cmd.Parameters.Add(EmpIdParam);

                    SqlParameter Homephnparam = new SqlParameter();
                    Homephnparam.ParameterName = "@HomePhn";
                    Homephnparam.SqlDbType = SqlDbType.NChar;
                    Homephnparam.Direction = ParameterDirection.Input;
                    Homephnparam.Size = 10;
                    Homephnparam.Value = this.HomePhn;
                    cmd.Parameters.Add(Homephnparam);

                    cmd.ExecuteNonQuery();

                    this.Id = Convert.ToInt32(EmpIdParam.Value);

                }
            }
            catch
            {

            }
            
        }
    public int SaveEmployee()
        {
            
            //using (TransactionScope scope = new TransactionScope())
           // {
    
                {
                    int empId = AddEmployee();
                    addHomePhn(empId, this.HomePhn);
                    return empId;
                }
               // scope.Complete();
          //  }
        }
    }
}