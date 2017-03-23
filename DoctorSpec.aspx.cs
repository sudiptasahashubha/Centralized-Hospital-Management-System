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
    public partial class DoctorSpec : System.Web.UI.Page
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

            string sql = "SELECT D.DOC_ID,D.DOC_NAME,D_SP.SPECIALIZED_FIELD,D.DOC_SEX,D.DOC_NID,D.DOC_CONTACT_NO,D.DOC_MONTHLY_SALARY FROM DOCTOR D JOIN DOCTOR_SPECIALITY D_SP ON(D.DOC_ID=D_SP.DOC_ID AND D.HOS_ID=D_SP.HOS_ID) WHERE D_SP.SPECIALIZED_FIELD='" + 
                DropDownList1.SelectedItem.Text + "' AND D.HOS_ID=" + Mother.hospitalId;
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.Visible = true;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}