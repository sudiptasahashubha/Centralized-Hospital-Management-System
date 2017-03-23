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
    public partial class RecordIn : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                
                string sql = " SELECT DOC_ID FROM DOCTOR WHERE HOS_ID = " + Mother.hospitalId;


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "DOC_ID";
                DropDownList1.DataValueField = "DOC_ID";

                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();

                con.Close();

                con.Open();
                sql = " SELECT DISEASE_ID  FROM CENTRAL_DISEASE WHERE HOS_ID = " + Mother.hospitalId;


                oda = new OleDbDataAdapter(sql, con);
                dt = new DataTable();
                oda.Fill(dt);
                DropDownList2.DataTextField = "DISEASE_ID";
                DropDownList2.DataValueField = "DISEASE_ID";

                DropDownList2.DataSource = dt;
                DropDownList2.DataBind();

                con.Close();


                con.Open();
                sql = " SELECT MED_CODE   FROM CENTRAL_MEDICINE WHERE HOS_ID = " + Mother.hospitalId;


                oda = new OleDbDataAdapter(sql, con);
                dt = new DataTable();
                oda.Fill(dt);
                DropDownList3.DataTextField = "MED_CODE";
                DropDownList3.DataValueField = "MED_CODE";

                DropDownList3.DataSource = dt;
                DropDownList3.DataBind();

                con.Close();
                con.Open();
                sql = " SELECT PATIENT_ID   FROM PATIENT WHERE HOS_ID = " + Mother.hospitalId;


                oda = new OleDbDataAdapter(sql, con);
                dt = new DataTable();
                oda.Fill(dt);
                DropDownList4.DataTextField = "PATIENT_ID";
                DropDownList4.DataValueField = "PATIENT_ID";

                DropDownList4.DataSource = dt;
                DropDownList4.DataBind();

                con.Close();

                con.Open();

                sql = " SELECT DURATION_ID   FROM ADMISSION_AND_RELEASE_INFO WHERE HOS_ID = " + Mother.hospitalId;

                oda = new OleDbDataAdapter(sql, con);
                dt = new DataTable();
                oda.Fill(dt);
                DropDownList5.DataTextField = "DURATION_ID";
                DropDownList5.DataValueField = "DURATION_ID";
                DropDownList5.DataSource = dt;
                DropDownList5.DataBind();
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem == null || DropDownList2.SelectedItem == null || DropDownList3.SelectedItem == null || DropDownList4.SelectedItem == null || DropDownList5.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(DURATION_ID) FROM ADMISSION_AND_RELEASE_INFO WHERE HOS_ID = " + Mother.hospitalId + " AND PATIENT_ID = " + DropDownList4.SelectedItem.Text + 
                " AND DURATION_ID = " + DropDownList5.SelectedItem.Text;
            cmd.Connection = con;


            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (temp == 1)
            {

                cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                string sql = "INSERT INTO RECORD1 VALUES(FOR_AUTO_INC_REC.NEXTVAL," + DropDownList4.SelectedItem.Text + "," + Mother.hospitalId + "," + DropDownList4.Text + "," + DropDownList1.SelectedItem.Text + "," + DropDownList5.SelectedItem.Text + ")";



                con.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();


                sql = "INSERT INTO DISEASE VALUES (FOR_AUTO_INC_DIS.NEXTVAL," + Mother.hospitalId + "," + DropDownList2.SelectedItem.Text + ","
                    + DropDownList4.SelectedItem.Text + "," + DropDownList5.SelectedItem.Text + ")";


                con.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();

                sql = "INSERT INTO MEDICINE VALUES (FOR_AUTO_INC_MED.NEXTVAL," + Mother.hospitalId + "," + DropDownList3.SelectedItem.Text + "," +

                     DropDownList4.SelectedItem.Text + "," + DropDownList5.SelectedItem.Text + ")";

                con.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                sql = "select * from RECORD1";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                con.Close();

                con.Open();
                sql = "select * from MEDICINE";


                oda = new OleDbDataAdapter(sql, con);
                dt = new DataTable();
                oda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();

                con.Close();

                con.Open();
                sql = "select * from DISEASE";


                oda = new OleDbDataAdapter(sql, con);
                dt = new DataTable();
                oda.Fill(dt);
                GridView3.DataSource = dt;
                GridView3.DataBind();

                con.Close();
                Response.Redirect("~/OPS.aspx");

            }
            else
            {
                Response.Redirect("~/Page.aspx");
            }
            
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}