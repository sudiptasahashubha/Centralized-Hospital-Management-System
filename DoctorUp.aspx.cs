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
    public partial class DoctorUp : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                sql = "SELECT DOC_ID  FROM DOCTOR  WHERE HOS_ID = " + Mother.hospitalId +" ORDER BY DOC_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "DOC_ID";
                DropDownList1.DataValueField = "DOC_ID";

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
            cmd.CommandText = "UPDATE DOCTOR SET ";
            bool Fl = false;
            if (TextBox1.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + "DOC_NAME = '" + TextBox1.Text + "'";
                Fl = true;
            }

            if (TextBox2.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + "DOC_NID = " + TextBox2.Text ;
                Fl = true;
            }

            if (TextBox3.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + " DOC_CONTACT_NO  = '" + TextBox3.Text+"'";
                Fl = true;
            }


            if (TextBox4.Text != "")
            {
                if (Fl) cmd.CommandText += ',';
                cmd.CommandText = cmd.CommandText + " DOC_MONTHLY_SALARY   = " + TextBox4.Text ;
                Fl = true;
            }

            cmd.CommandText += " WHERE DOC_ID = " + DropDownList1.SelectedItem.Text + " AND HOS_ID = " + Mother.hospitalId;
            con.Open();
            //Response.Write(cmd.CommandText);
            if (Fl)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception yy)
                {
                    Response.Write("DOCTOR SALARY CAN NOT BE LESS THAN ZERO\n");
                    con.Close();
                    return;
                }
            }
            con.Close();

            


            // eKHANE BAKI ACHE KAJ
            if (!DropDownList2.SelectedItem.Text.Equals("Choose"))
            {
                
                cmd.CommandText = "UPDATE DOCTOR_SPECIALITY SET SPECIALIZED_FIELD ='" + DropDownList2.SelectedItem.Text +
                    "' WHERE DOC_ID = " + DropDownList1.SelectedItem.Text + " AND HOS_ID = " + Mother.hospitalId;

                con.Open();
               //Response.Write(cmd.CommandText);
                cmd.ExecuteNonQuery();
                con.Close();
             
            }

            con.Open();
            string sql = "select * from DOCTOR_SPECIALITY";


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