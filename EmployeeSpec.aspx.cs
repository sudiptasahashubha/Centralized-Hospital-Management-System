using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Configuration;

namespace Hospital_Management_Database
{
    public partial class EmployeeSpec : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "SELECT EMP_ID,HOS_ID,EMP_NAME,EMP_JOB_FIELD,EMP_SEX,EMP_NID,EMP_CONTACT_NO,EMP_MONTHLY_SALARY FROM EMPLOYEEHOS WHERE UPPER(EMP_JOB_FIELD)=UPPER('"+ DropDownList1.SelectedItem.Text+ "') AND HOS_ID="+Mother.hospitalId;

            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.Visible = true;
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }
    }
}