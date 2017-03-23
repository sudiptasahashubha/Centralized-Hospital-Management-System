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
    public partial class DiseaseIn : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals("") || TextBox2.Text.Equals(""))
            {
                Response.Redirect("~/EMPTY_FIELD.aspx");
                return; 
            }

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.CommandText = "SELECT COUNT(*) FROM CENTRAL_DISEASE WHERE HOS_ID =" + Mother.hospitalId + " AND DISEASE_ID  = " + TextBox1.Text;

            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (temp == 1)
            {
                Response.Redirect("~/ID_IN_USE.aspx");
                Response.Write("DISEASE ID ALREDY IN USE.PLEASE SELECT NEW !!!");
            }
            else
            {

                con.Open();

                string sql = "SELECT FOR_DISEASE('" + TextBox2.Text + "') FROM EMPLOYEES";
                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                int K = (int)(decimal)dt.Rows[0][0];
                con.Close();
                if (K == 1)
                {
                     sql = "INSERT INTO CENTRAL_DISEASE VALUES (" + Mother.hospitalId + "," + TextBox1.Text + ",'" +
               TextBox2.Text + "')";



                    con.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    con.Close();



                    con.Open();
                    sql = "select * from central_disease";


                    oda = new OleDbDataAdapter(sql, con);
                    dt = new DataTable();
                    oda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    con.Close();
                    Response.Redirect("~/OPS.aspx");
                }
                else
                {
                    Response.Redirect("~/NameCol.aspx");
                }

            }
            
        }
    }
}