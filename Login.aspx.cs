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

    public partial class Login : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void LoginAdmin_Click1(object sender, EventArgs e)
        {


            string hosId = TextBoxano.Text;
            string hosPs = TextBox2.Text;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM HOSPITAL WHERE HOS_ID = " + hosId + " AND PASSWORD = '" + hosPs + "'";
            cmd.Connection = con;


            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("Login SuccessFul");
                Mother.hospitalId = Convert.ToInt32( hosId);
                Response.Redirect("~/Options.aspx");

            }

            else
            {
                Response.Write("Hospital ID or Password MisMatch !!!");
            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
       
    }
}