using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;

public partial class _Default : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection();
    OdbcCommand com;
    OdbcDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {

        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
            con.Open();
            try
            {
                string sql = "select max(student_id), max(roll_no), max(library_card_no) from student";
                da = new OdbcDataAdapter(sql, con);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    string stringtoint = ds.Tables[0].Rows[0][0].ToString().Substring(2);
                    string stringtoint2 = ds.Tables[0].Rows[0][1].ToString().Substring(1);
                    string stringtoint3 = ds.Tables[0].Rows[0][2].ToString().Substring(5);
                    int num = Convert.ToInt16(stringtoint) + 1;
                    int num2 = Convert.ToInt16(stringtoint2) + 1;
                    int num3 = Convert.ToInt16(stringtoint3) + 1;
                    string inttostring = "PR" + num.ToString();
                    string inttostring2 = "R" + num2.ToString();
                    string inttostring3 = "PRLIB" + num3.ToString();
                    TextBox1.Text = inttostring.ToString();
                    TextBox3.Text = inttostring2.ToString();
                    TextBox6.Text = inttostring3.ToString();
                }
            }
            catch
            {
                TextBox1.Text = "PR101";
                TextBox3.Text = "R101";
                TextBox6.Text = "PRLIB101";
            }
        finally
        {
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=E:\CHEMISTRY\MY COMPUTER\my_project\RKMSCC_PROJECT\ParthaRoy\school.mdb");
        con.Open();
       string sql = "insert into student values('" + this.TextBox1.Text + "','" + this.TextBox2.Text + "','" + this.TextBox3.Text + "','" + this.TextBox4.Text + "','" + this.TextBox5.Text + "','" + this.TextBox6.Text + "','" + this.TextBox7.Text + "','" + this.TextBox8.Text + "','" + this.TextBox10.Text + "','" + this.TextBox11.Text + "','" + this.TextBox12.Text + "')";
       com = new OdbcCommand(sql, con);
       com.ExecuteNonQuery();
       try
       {
           string sqlx = "select max(student_id), max(roll_no), max(library_card_no) from student";
           da = new OdbcDataAdapter(sqlx, con);
           ds = new DataSet();
           da.Fill(ds);
           if (ds.Tables[0].Rows.Count > 0)
           {

               string stringtoint = ds.Tables[0].Rows[0][0].ToString().Substring(2);
               string stringtoint2 = ds.Tables[0].Rows[0][1].ToString().Substring(1);
               string stringtoint3 = ds.Tables[0].Rows[0][2].ToString().Substring(5);
               int num = Convert.ToInt16(stringtoint) + 1;
               int num2 = Convert.ToInt16(stringtoint2) + 1;
               int num3 = Convert.ToInt16(stringtoint3) + 1;
               string inttostring = "PR" + num.ToString();
               string inttostring2 = "R" + num2.ToString();
               string inttostring3 = "PRLIB" + num3.ToString();
               TextBox1.Text = inttostring.ToString();
               TextBox3.Text = inttostring2.ToString();
               TextBox6.Text = inttostring3.ToString();
           }
       }
       catch
       {
           TextBox1.Text = "PR101";
           TextBox3.Text = "R101";
           TextBox6.Text = "PRLIB101";
       }
       finally
       {
           con.Close();
       }
       clear();
    }
    public void clear()
    {
        this.TextBox2.Text = "";
        this.TextBox4.Text = "";
        this.TextBox5.Text = "";
        this.TextBox7.Text = "";
        this.TextBox8.Text = "";
        this.TextBox10.Text = "";
        this.TextBox11.Text = "";
        this.TextBox12.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        clear();
    }
}

