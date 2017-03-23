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
    public partial class DiseaseDel : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                sql = "SELECT NAME_OF_DISEASE  FROM CENTRAL_DISEASE  WHERE HOS_ID = " + Mother.hospitalId + " ORDER BY NAME_OF_DISEASE";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "NAME_OF_DISEASE";
                DropDownList1.DataValueField = "NAME_OF_DISEASE";

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
            cmd.CommandText = "DELETE FROM CENTRAL_DISEASE WHERE NAME_OF_DISEASE = '" + DropDownList1.SelectedItem.Text + "' AND HOS_ID = " + Mother.hospitalId;
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
            cmd.CommandText = "DELETE FROM CENTRAL_DISEASE WHERE  HOS_ID = " + Mother.hospitalId;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("~/OPS.aspx");

        }
    }
}