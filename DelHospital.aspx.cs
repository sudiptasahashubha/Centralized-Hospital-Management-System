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
    public partial class DelHospital : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                sql = "SELECT HOS_ID  FROM HOSPITAL  ORDER BY HOS_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "HOS_ID";
                DropDownList1.DataValueField = "HOS_ID";

                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                dt.Clear();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM HOSPITAL WHERE HOS_ID = " + DropDownList1.SelectedItem.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("~/OPS.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM HOSPITAL";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("~/OPS.aspx");

        }
    }
}