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
    public partial class Admission_ReleaseUp : System.Web.UI.Page
    {

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                sql = "SELECT DURATION_ID  FROM ADMISSION_AND_RELEASE_INFO  WHERE HOS_ID = " + Mother.hospitalId + " ORDER BY DURATION_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "DURATION_ID";
                DropDownList1.DataValueField = "DURATION_ID";

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
            cmd.CommandText = "UPDATE ADMISSION_AND_RELEASE_INFO SET ";
            bool Fl = false;
            if (DropDownList2.SelectedItem.Text.Equals("Date") || DropDownList3.SelectedItem.Text.Equals("Month") || DropDownList6.SelectedItem.Text.Equals("Year"))
            {


            }
            else
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + "DATE_OF_ADMISSION = '" + DropDownList2.SelectedItem.Text + "-" +
                    DropDownList3.SelectedItem.Text+"-" + DropDownList6.SelectedItem.Text + "'";
                Fl = true;
            }

            if (DropDownList11.SelectedItem.Text.Equals("Date") || DropDownList12.SelectedItem.Text.Equals("Month") || DropDownList13.SelectedItem.Text.Equals("Year"))
            {

            }
            else
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + "DATE_OF_RELEASE = '" + DropDownList11.SelectedItem.Text + "-" +
                    DropDownList12.SelectedItem.Text + "-" + DropDownList13.SelectedItem.Text + "'";
                Fl = true;
            }
            

            cmd.CommandText += " WHERE DURATION_ID = " + DropDownList1.SelectedItem.Text + " AND HOS_ID = " + Mother.hospitalId;
            con.Open();
            //Response.Write(cmd.CommandText);
            if (Fl) cmd.ExecuteNonQuery();
            con.Close();



            cmd.CommandText = "UPDATE ROOM SET ";

            Fl = false;
            if (!TextBox1.Text.Equals(""))
            {
                if (Fl) cmd.CommandText += ",";
                cmd.CommandText += " ROOM_ID = " + TextBox1.Text;
                Fl = true;

            }
            if (DropDownList10.SelectedItem.Text != "")
            {
                if (Fl) cmd.CommandText += ",";
                cmd.CommandText += " ROOM_TYPE = '" + DropDownList10.SelectedItem.Text + "'";
                Fl = true;

            }
            if (!TextBox3.Text.Equals(""))
            {
                if (Fl) cmd.CommandText += ",";
                cmd.CommandText += " ROOM_DAILY_CHARGE = " + TextBox3.Text;
                Fl = true;
            }
            cmd.CommandText += " WHERE DURATION_ID =" + DropDownList1.SelectedItem.Text;

            con.Open();
            //Response.Write(cmd.CommandText);
            if (Fl) cmd.ExecuteNonQuery();
            con.Close();


            con.Open();
            string sql = "select * from ADMISSION_AND_RELEASE_INFO";


            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Close();
            Response.Redirect("~/OPS.aspx");
        }
    }
}