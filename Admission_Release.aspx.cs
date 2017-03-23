using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Configuration;

namespace Hospital_Management_Database
{
    public partial class Admission_Release : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                
                string sql = " SELECT PATIENT_ID FROM PATIENT WHERE HOS_ID = " + Mother.hospitalId;


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList5.DataTextField = "PATIENT_ID";
                DropDownList5.DataValueField = "PATIENT_ID";

                DropDownList5.DataSource = dt;
                DropDownList5.DataBind();

                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if(TextBox1.Text.Equals("") || TextBox2.Text.Equals("") || TextBox3.Text.Equals("") || DropDownList1.SelectedItem.Text.Equals("Date") ||
                DropDownList2.SelectedItem.Text.Equals("Date") || DropDownList3.SelectedItem.Text.Equals("Month") ||
                DropDownList9.SelectedItem.Text.Equals("Month") || DropDownList6.SelectedItem.Text.Equals("Year") || DropDownList5.SelectedItem == null ||
                DropDownList7.SelectedItem.Text.Equals("Year")
                )
            {
                Response.Redirect("~/EMPTY_FIELD.aspx");
                return;
            }
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.CommandText = "SELECT COUNT(*) FROM ADMISSION_AND_RELEASE_INFO WHERE HOS_ID =" + Mother.hospitalId + " AND DURATION_ID = " + TextBox1.Text;

            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();

            if (temp == 1)
            {
                Response.Redirect("~/ID_IN_USE.aspx");
                return;
            }
            else
            {
                string sql = "INSERT INTO ADMISSION_AND_RELEASE_INFO VALUES (" + Mother.hospitalId + "," +
                TextBox1.Text + "," + DropDownList5.SelectedItem.Text + ",'" + DropDownList1.SelectedItem.Text + "-" +
                DropDownList3.SelectedItem.Text + "-" + DropDownList6.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text +
                "-" + DropDownList9.SelectedItem.Text + "-" + DropDownList7.SelectedItem.Text + "')";



                con.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();

                sql = "INSERT INTO ROOM VALUES (" + TextBox2.Text + "," + Mother.hospitalId + "," + DropDownList5.SelectedItem.Text
                    + ",'" + DropDownList8.SelectedItem.Text + "'," + TextBox3.Text + "," + TextBox1.Text + ")";

                con.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();



                con.Open();
                sql = "select * from ROOM";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Response.Redirect("~/OPS.aspx");
            }
            
        }
    }
}