using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class About : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection();
    OdbcCommand com;
    OdbcDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
        con.Open();
        string sql = "select student_id from student where student_id like '%" + this.TextBox1.Text + "%' order by student_id ";
        OdbcDataReader dr = new OdbcCommand(sql, con).ExecuteReader();
        while (dr.Read())
        {
            this.DropDownList1.Items.Add(dr.GetValue(0).ToString());
        }
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
        con.Open();
        string sql = "select s.student_id,s.student_name,s.roll_no,s.class,s.sec,l.library_card_no,l.book_name,l.issue_date,l.submit_date,l.total_fine from student s, library l where s.student_id=l.student_id and s.student_id='" + this.DropDownList1.Text + "'";
        da = new OdbcDataAdapter(sql, con);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            this.GridView1.DataSource = ds.Tables[0];
            this.GridView1.DataBind();
        }
        else
        {
            Response.Write("<script>alert('Record not found');</script>");
        }
        con.Close();
    }
}
