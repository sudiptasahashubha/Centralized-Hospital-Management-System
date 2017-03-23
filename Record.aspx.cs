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
    public partial class Record : System.Web.UI.Page
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=orcl;Persist Security Info=True;User ID=HR;Password=hr;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string sql = "SELECT DURATION_ID  FROM ADMISSION_AND_RELEASE_INFO  WHERE HOS_ID = " + Mother.hospitalId + " ORDER BY DURATION_ID";


                OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DropDownList1.DataTextField = "DURATION_ID";
                DropDownList1.DataValueField = "DURATION_ID";

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
            con.Open();
            string sql = "SELECT P.PATIENT_ID,P.NAME_OF_PATIENT,P.SEX,P.AGE,P.CONTACT_NO, "+
            "A.DURATION_ID,A.DATE_OF_ADMISSION,A.DATE_OF_RELEASE,R.ROOM_ID,R.ROOM_TYPE,R.ROOM_DAILY_CHARGE, "+
            "D.DISEASE_ID,CN_DI.NAME_OF_DISEASE,M.MED_CODE,CN_ME.NAME_OF_MEDICINE,DO.DOC_ID,DO.DOC_NAME FROM PATIENT P LEFT OUTER JOIN ADMISSION_AND_RELEASE_INFO  A "+
            "ON(P.PATIENT_ID=A.PATIENT_ID AND P.HOS_ID=A.HOS_ID) LEFT OUTER JOIN ROOM R ON(A.PATIENT_ID=R.PATIENT_ID AND A.DURATION_ID=R.DURATION_ID AND A.HOS_ID=R.HOS_ID) "+
            "LEFT OUTER JOIN DISEASE D ON(R.PATIENT_ID=D.PATIENT_ID AND R.DURATION_ID=D.DURATION_ID AND R.HOS_ID=D.HOS_ID) LEFT OUTER JOIN CENTRAL_DISEASE CN_DI " +
            "ON(D.DISEASE_ID=CN_DI.DISEASE_ID AND D.HOS_ID=CN_DI.HOS_ID) LEFT OUTER JOIN MEDICINE M ON(D.PATIENT_ID=M.PATIENT_ID AND D.DURATION_ID=M.DURATION_ID AND D.HOS_ID=M.HOS_ID) " +
            "LEFT OUTER JOIN CENTRAL_MEDICINE CN_ME ON(M.MED_CODE=CN_ME.MED_CODE AND M.HOS_ID=CN_ME.HOS_ID) LEFT OUTER JOIN RECORD1 RE " +  
            "ON(M.PATIENT_ID=RE.PATIENT_ID AND M.DURATION_ID=RE.DURATION_ID AND M.HOS_ID=RE.HOS_ID AND M.AUTO_INC_MED=RE.AUTO_INC_REC) "+
            "LEFT OUTER JOIN DOCTOR DO ON(RE.DOC_ID=DO.DOC_ID AND RE.HOS_ID=DO.HOS_ID) WHERE A.DURATION_ID = " + DropDownList1.SelectedItem.Text + " AND P.HOS_ID=" + Mother.hospitalId;
;


            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem == null)
            {
                Response.Redirect("~/NullPointer.aspx");
                return;
            }
            con.Open();
            string sql = "SELECT P.PATIENT_ID,P.NAME_OF_PATIENT,P.SEX,P.AGE,P.CONTACT_NO, " +
            "A.DURATION_ID,A.DATE_OF_ADMISSION,A.DATE_OF_RELEASE,R.ROOM_ID,R.ROOM_TYPE,R.ROOM_DAILY_CHARGE, " +
            "D.DISEASE_ID,CN_DI.NAME_OF_DISEASE,M.MED_CODE,CN_ME.NAME_OF_MEDICINE,DO.DOC_ID,DO.DOC_NAME FROM PATIENT P LEFT OUTER JOIN ADMISSION_AND_RELEASE_INFO  A " +
            "ON(P.PATIENT_ID=A.PATIENT_ID AND P.HOS_ID=A.HOS_ID) LEFT OUTER JOIN ROOM R ON(A.PATIENT_ID=R.PATIENT_ID AND A.DURATION_ID=R.DURATION_ID AND A.HOS_ID=R.HOS_ID) " +
            "LEFT OUTER JOIN DISEASE D ON(R.PATIENT_ID=D.PATIENT_ID AND R.DURATION_ID=D.DURATION_ID AND R.HOS_ID=D.HOS_ID) LEFT OUTER JOIN CENTRAL_DISEASE CN_DI " +
            "ON(D.DISEASE_ID=CN_DI.DISEASE_ID AND D.HOS_ID=CN_DI.HOS_ID) LEFT OUTER JOIN MEDICINE M ON(D.PATIENT_ID=M.PATIENT_ID AND D.DURATION_ID=M.DURATION_ID AND D.HOS_ID=M.HOS_ID) " +
            "LEFT OUTER JOIN CENTRAL_MEDICINE CN_ME ON(M.MED_CODE=CN_ME.MED_CODE AND M.HOS_ID=CN_ME.HOS_ID) LEFT OUTER JOIN RECORD1 RE " +
            "ON(M.PATIENT_ID=RE.PATIENT_ID AND M.DURATION_ID=RE.DURATION_ID AND M.HOS_ID=RE.HOS_ID AND M.AUTO_INC_MED=RE.AUTO_INC_REC) " +
            "LEFT OUTER JOIN DOCTOR DO ON(RE.DOC_ID=DO.DOC_ID AND RE.HOS_ID=DO.HOS_ID) WHERE  P.HOS_ID=" + Mother.hospitalId;
            ;


            OleDbDataAdapter oda = new OleDbDataAdapter(sql, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Close();
        }
    }
}