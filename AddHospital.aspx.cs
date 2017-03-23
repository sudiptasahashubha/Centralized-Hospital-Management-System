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
using System.Collections;
namespace Hospital_Management_Database
{
    public partial class AddHospital : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals("") || TextBox2.Text.Equals("") || TextBox3.Text.Equals("") || TextBox4.Text.Equals(""))
            {
                Response.Redirect("~/EMPTY_FIELD");
                return;
            }
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT COUNT(*) FROM HOSPITAL WHERE HOS_ID = " + TextBox1.Text;
            cmd.Connection = con;

            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();


            if (temp == 1)
            {
                Response.Redirect("~/ID_IN_USE");
                return;

            }
            else
            {
                cmd.CommandText = "INSERT into HOSPITAL VALUES(" + TextBox1.Text + ",'" + TextBox3.Text + "','"
                + TextBox2.Text + "','" + TextBox4.Text + "')";


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                foreach (ListItem i in CheckBoxList1.Items)
                {
                    if (i.Selected == true)
                    {
                        cmd.CommandText = "INSERT INTO HOSPITAL_SPECIALITY VALUES (FOR_HOS_SP_ID.NEXTVAL, " + TextBox1.Text + ",'" +
                            i.Text + "')";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                con.Open();
                string sql = "select * from HOSPITAL_SPECIALITY";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                con.Close();

                Response.Redirect("~/OPS.aspx");
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}