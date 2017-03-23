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
    public partial class Medicine : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string sql = "SELECT DISTINCT(NAME_OF_MEDICINE) FROM CENTRAL_MEDICINE WHERE HOS_ID=" + Mother.hospitalId + "ORDER BY NAME_OF_MEDICINE ";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "NAME_OF_MEDICINE";
                DropDownList1.DataValueField = "NAME_OF_MEDICINE";

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
            string sql = "SELECT CENMADE.MED_CODE,CENMADE.NAME_OF_MEDICINE FROM CENTRAL_MEDICINE CENMADE WHERE CENMADE.NAME_OF_MEDICINE= '" + DropDownList1.SelectedItem.Text + "' AND CENMADE.HOS_ID= " + Mother.hospitalId;
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
            string sql = "SELECT CENMADE.MED_CODE,CENMADE.NAME_OF_MEDICINE FROM CENTRAL_MEDICINE CENMADE WHERE  CENMADE.HOS_ID= "+ Mother.hospitalId;
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}