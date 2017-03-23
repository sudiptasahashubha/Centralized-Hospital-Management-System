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
    public partial class PatientIn : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            if(TextBox1.Text.Equals("") || TextBox2.Text.Equals("") || TextBox3.Text.Equals("") || TextBox4.Text.Equals("")){
                Response.Redirect("~/EMPTY_FIELD.aspx");
                return;
            }
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM PATIENT WHERE HOS_ID = " + Mother.hospitalId + " AND PATIENT_ID = " + TextBox1.Text;
            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();

            if (temp == 1)
            {
                Response.Redirect("~/ID_IN_USE.aspx");
                Response.Write("PATIENT ID ALREADY IN USE. PLEASE ENTER NEW !!!");
            }
            else
            {
                cmd.CommandText = "INSERT into PATIENT VALUES(" + Mother.hospitalId + "," + TextBox1.Text + ",'"
                + TextBox2.Text + "','" + DropDownList1.SelectedItem.Text + "'," + TextBox3.Text + ",'"
                + TextBox4.Text + "')";


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
}