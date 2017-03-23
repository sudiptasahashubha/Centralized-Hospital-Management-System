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
    public partial class Disease : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string sql = "SELECT NAME_OF_DISEASE FROM CENTRAL_DISEASE WHERE HOS_ID = " + Mother.hospitalId + " ORDER BY NAME_OF_DISEASE";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList2.DataTextField = "NAME_OF_DISEASE";
                DropDownList2.DataValueField = "NAME_OF_DISEASE";

                DropDownList2.DataSource = dt;
                DropDownList2.DataBind();
                dt.Clear();
                // do
               
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            con.Open();
            string sql = "SELECT CEN.DISEASE_ID,CEN.NAME_OF_DISEASE FROM CENTRAL_DISEASE CEN WHERE CEN.NAME_OF_DISEASE='" + DropDownList2.SelectedItem.Text + "' AND CEN.HOS_ID= " + Mother.hospitalId;


            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            if (DropDownList2.SelectedItem == null) return;
            con.Open();
            string sql = "SELECT CEN.DISEASE_ID,CEN.NAME_OF_DISEASE FROM CENTRAL_DISEASE CEN WHERE  CEN.HOS_ID= " + Mother.hospitalId;


            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}