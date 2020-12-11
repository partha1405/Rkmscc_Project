using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
public partial class Default4 : System.Web.UI.Page
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
        string sql = "select * from login where usertype='" + this.DropDownList1.Text + "' and userid='" + this.TextBox1.Text + "' and password='" + this.TextBox2.Text + "'";
        OdbcDataAdapter da= new OdbcDataAdapter(sql, con);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Write("<script>alert('Pleasae select correct usertype and enter valid user id and password');</script>");
            this.DropDownList1.Text = "";
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
        }
        con.Close();
    }
}