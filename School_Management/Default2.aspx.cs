using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class Default2 : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection();
    OdbcCommand com;
    OdbcDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
            con.Open();
            string sql = "select student_id from student where student_id like '%" + this.TextBox1.Text + "%' order by student_id ";
            OdbcDataReader dr = new OdbcCommand(sql, con).ExecuteReader();
        while(dr.Read())
        {
                this.DropDownList1.Items.Add(dr.GetValue(0).ToString());  
            }
            con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
            con.Open();
            string sql = "select library_card_no from student where library_card_no like '%" + this.TextBox2.Text + "%' order by library_card_no ";
            OdbcDataReader dr = new OdbcCommand(sql, con).ExecuteReader();
        while(dr.Read())
        {
                this.DropDownList2.Items.Add(dr.GetValue(0).ToString());
               
            }
            con.Close();
  
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.DropDownList2.Text = "";
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
            con.Open();
         string sql = "select student_id,student_name,library_card_no from student where student_id='" + this.DropDownList1.Text + "'";
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
        this.DropDownList1.Text = "";
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
        con.Open();
        string sql = "select student_id,student_name,library_card_no from student where library_card_no='" + this.DropDownList2.Text + "'";
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
    protected void Button5_Click(object sender, EventArgs e)
    {
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
        con.Open();
        string sql = "insert into library values('" + this.TextBox3.Text + "','" + this.TextBox5.Text + "','" + this.TextBox6.Text + "','" + this.TextBox7.Text + "','" + this.TextBox8.Text + "','" + this.TextBox9.Text + "')";
        com = new OdbcCommand(sql, con);
        com.ExecuteNonQuery();
        con.Close();
        this.TextBox6.Text = "";
        this.TextBox7.Text = "";
        this.TextBox8.Text = "";
        this.TextBox9.Text = "";
    }
}