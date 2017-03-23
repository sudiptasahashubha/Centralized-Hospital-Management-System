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
    public partial class Searching : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "SELECT H_SP.HOS_ID,H.HOSPITAL_NAME,H.HOSPITAL_LOCATION,H_SP.SPECIALIZED_FIELD FROM HOSPITAL_SPECIALITY H_SP JOIN HOSPITAL H ON(H_SP.HOS_ID=H.HOS_ID) WHERE UPPER(H_SP.SPECIALIZED_FIELD)=UPPER( '" + DropDownList1.SelectedItem.Text +"')";
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.Visible = true;
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();

        }
    }
}