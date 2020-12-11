using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class Default3 : System.Web.UI.Page
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
    protected void Button2_Click(object sender, EventArgs e)
    {

       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
        con.Open();
        string sql = "select student_id,student_name,bus_no from student where student_id='" + this.DropDownList1.Text + "'";
        da = new OdbcDataAdapter(sql, con);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            this.TextBox3.Text = ds.Tables[0].Rows[0][0].ToString();
            this.TextBox4.Text = ds.Tables[0].Rows[0][1].ToString();
            this.TextBox5.Text = ds.Tables[0].Rows[0][2].ToString();
        }
        con.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
       
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if (this.TextBox5.Text == "")
        {
            Response.Write("<script>alert('This student does not select bus service yet');</script>"); 
        }
        else
        {
            con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
            con.Open();
            string sql = "insert into bus values('" + this.TextBox3.Text + "','" + this.TextBox5.Text + "','" + this.TextBox7.Text + "','" + this.TextBox8.Text + "','" + this.TextBox9.Text + "')";
            com = new OdbcCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data inserted successfully');</script>");
            this.TextBox7.Text = "";
            this.TextBox8.Text = "";
            this.TextBox9.Text = "";
        }
    }
}