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
    public partial class Employee : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string sql = "SELECT EMP_ID FROM EMPLOYEEHOS  WHERE HOS_ID = " + Mother.hospitalId + " ORDER BY EMP_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "EMP_ID";
                DropDownList1.DataValueField = "EMP_ID";

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
            
            con.Open();
            string sql = "SELECT E.EMP_ID,E.HOS_ID,E.EMP_NAME,E.EMP_JOB_FIELD,E.EMP_SEX,E.EMP_NID,E.EMP_CONTACT_NO,E.EMP_MONTHLY_SALARY FROM EMPLOYEEHOS E WHERE E.EMP_ID=" + DropDownList1.SelectedItem.Text + " AND E.HOS_ID= " + Mother.hospitalId;
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            con.Open();
            string sql = "SELECT E.EMP_ID,E.HOS_ID,E.EMP_NAME,E.EMP_JOB_FIELD,E.EMP_SEX,E.EMP_NID,E.EMP_CONTACT_NO,E.EMP_MONTHLY_SALARY FROM EMPLOYEEHOS E WHERE E.HOS_ID= " + Mother.hospitalId;
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}