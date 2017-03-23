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
    public partial class PatientUp : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                sql = "SELECT PATIENT_ID   FROM PATIENT  WHERE HOS_ID = " + Mother.hospitalId + " ORDER BY PATIENT_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "PATIENT_ID";
                DropDownList1.DataValueField = "PATIENT_ID";

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
            cmd.Connection = con;
            cmd.CommandText = "UPDATE PATIENT SET ";
            bool Fl = false;
            if (TextBox1.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + " NAME_OF_PATIENT  = '" + TextBox1.Text + "'";
                Fl = true;
            }

            if (TextBox2.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + " AGE = " + TextBox2.Text;
                Fl = true;
            }

            if (TextBox3.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + "CONTACT_NO   = '" + TextBox3.Text + "'";
                Fl = true;
            }

            cmd.CommandText += "WHERE PATIENT_ID = " + DropDownList1.SelectedItem.Text + " AND HOS_ID = " + Mother.hospitalId;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            string sql = "select * from PATIENT";


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