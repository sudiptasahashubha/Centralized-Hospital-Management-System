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
    public partial class Doctor : System.Web.UI.Page
    {

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string sql = "SELECT DOC_ID FROM DOCTOR WHERE HOS_ID = "+ Mother.hospitalId +" ORDER BY DOC_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "DOC_ID";
                DropDownList1.DataValueField = "DOC_ID";

                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                dt.Clear();
                // do
                con.Close();
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

            string sql = "SELECT D.DOC_ID,D.DOC_NAME,D.DOC_SEX,D.DOC_NID,D.DOC_CONTACT_NO,D.DOC_MONTHLY_SALARY,D_SP.SPECIALIZED_FIELD" +
                " FROM DOCTOR D LEFT OUTER JOIN DOCTOR_SPECIALITY D_SP ON(D.DOC_ID=D_SP.DOC_ID AND D.HOS_ID=D_SP.HOS_ID) WHERE D.DOC_ID="+ DropDownList1.SelectedItem.Text +" AND D.HOS_ID=" + Mother.hospitalId;
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.Visible = true;
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

            string sql = "SELECT D.DOC_ID,D.DOC_NAME,D.DOC_SEX,D.DOC_NID,D.DOC_CONTACT_NO,D.DOC_MONTHLY_SALARY,D_SP.SPECIALIZED_FIELD" +
                " FROM DOCTOR D LEFT OUTER JOIN DOCTOR_SPECIALITY D_SP ON(D.DOC_ID=D_SP.DOC_ID AND D.HOS_ID=D_SP.HOS_ID) WHERE  D.HOS_ID=" + Mother.hospitalId;
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.Visible = true;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}