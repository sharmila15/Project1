using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;






namespace Adodem
{
  
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtEmployeeFName.Text;
            emp.LastName = txtEmployeeLName.Text;
            emp.address = TextArea1.InnerText;
            emp.phnNumber = txtphn.Text;
            emp.Gender = ddlGender.SelectedItem.Value;
            emp.HomePhn = hphn.Text;

            int empId = emp.SaveEmployee();
           


            //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{

            //    SqlCommand cmd = new SqlCommand("spAddEmployee", conn);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@EmpFn", txtEmployeeFName.Text);
            //    cmd.Parameters.AddWithValue("@EmpLn", txtEmployeeLName.Text);
            //    cmd.Parameters.AddWithValue("@EmpAddress", TextArea1.InnerText);
            //    cmd.Parameters.AddWithValue("@EmpPhno", txtphn.Text);
            //    cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedItem.Value);


            //    SqlParameter outputParameter = new SqlParameter();
            //    outputParameter.ParameterName = "@EmpId";
            //    outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            //    outputParameter.Direction = System.Data.ParameterDirection.Output;
            //    cmd.Parameters.Add(outputParameter);

            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    String EmId = outputParameter.Value.ToString();
                lblMessage.Text = "Employee Id is" + empId.ToString();

            //}

        }
    }
}