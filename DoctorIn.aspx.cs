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
    public partial class DoctorIn : System.Web.UI.Page
    {

        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if(TextBox1.Text.Equals("") || TextBox2.Text.Equals("") || TextBox3.Text.Equals("") || TextBox4.Text.Equals("")
                || TextBox5.Text.Equals("") || DropDownList1.SelectedItem.Text.Equals("Choose"))
            {
                Response.Write("A FEILD CAN NOT BE EMPTY !!!\n\n");
                return;
            }
            string id = TextBox2.Text;
            string name = TextBox1.Text;
            string sex = DropDownList2.SelectedItem.Text;
            string NID = TextBox5.Text;
            string contact = TextBox4.Text;
            string sal = TextBox3.Text;

           // Mother.hospitalId = 1;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            con.Open();

            cmd.CommandText = "SELECT COUNT(*) FROM DOCTOR WHERE HOS_ID = " + Mother.hospitalId + " AND DOC_ID = " + TextBox2.Text;
            cmd.Connection = con;


            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            con.Close();

            
            if (temp == 1)
            {
                Response.Write("DOCTOR ID ALREADY IN USE. PLEASE SELECT NEW!!!");
               

            }

            else
            {
                    cmd.Connection = con;
               
                    cmd.CommandText = "CALL FOR_DOCTOR_INSERT ('" + TextBox2.Text + "',' " + Mother.hospitalId + "',' " + TextBox1.Text + "','" + DropDownList2.SelectedItem.Text + "',' " + TextBox5.Text + "',' " + TextBox4.Text + "','" + TextBox3.Text + "')";
               
                //cmd.CommandText = "INSERT into DOCTOR ( DOC_ID, HOS_ID,DOC_NAME, DOC_SEX,DOC_NID ,DOC_CONTACT_NO ,DOC_MONTHLY_SALARY ) VALUES( '" + TextBox2.Text + "',' " + Mother.hospitalId + "',' " + TextBox1.Text + "','" + DropDownList2.SelectedItem.Text + "',' " + TextBox5.Text + "',' " + TextBox4.Text + "','" + TextBox3.Text + "')";
               

                
                
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    cmd.CommandText = "INSERT INTO DOCTOR_SPECIALITY VALUES (" + Mother.hospitalId + ",FOR_DOC_SP_ID.NEXTVAL," + TextBox2.Text + ",'" + DropDownList1.SelectedItem.Text + "')";
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Redirect("~/OPS.aspx");
                    

                }
                catch (Exception oi)
                {
                   // Response.Write(oi.ToString());
                    Response.Write("DOCTOR SALARY CAN NOT BE LESS THAN ZERO\n");
                    return;
                }
                

                
                
                con.Open();
                string sql = "select * from DOCTOR";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                con.Close();

              
            }


            
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}