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
    public partial class ShowAll : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {

            con.Open();

            string sql = "SELECT H.HOS_ID,H.HOSPITAL_NAME,H.HOSPITAL_LOCATION,H_SP.SPECIALIZED_FIELD FROM HOSPITAL H LEFT OUTER JOIN HOSPITAL_SPECIALITY H_SP ON(H.HOS_ID=H_SP.HOS_ID) ORDER BY H.HOS_ID";
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.Visible = true;
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}