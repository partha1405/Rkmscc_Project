using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace library_management
{
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbCommand com1;
        OleDbCommand com2;
        OleDbDataAdapter da;
        OleDbDataAdapter da1;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to add?", "Add", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                con.Open();
                string sql;
                sql = "insert into book values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "'," + this.textBox5.Text + "," + this.textBox7.Text + ")";
                com = new OleDbCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("New book added in the record");
                com1 = new OleDbCommand("select * from book order by book_id", con);
                da = new OleDbDataAdapter(com1);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.dataGridView1.DataSource = ds.Tables[0];
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.textBox7.Text = "";
                }
                com2 = new OleDbCommand("select max(book_id) from book", con);
                da1 = new OleDbDataAdapter(com2);
                ds = new DataSet();
                da1.Fill(ds, "note");
                if (ds.Tables["note"].Rows.Count > 0)
                {
                    string stringtoint = ds.Tables["note"].Rows[0][0].ToString().Substring(3);
                    int num = Convert.ToInt16(stringtoint) + 1;
                    string inttostring = "BPR" + num.ToString();
                    this.textBox1.Text = inttostring.ToString();
                }
                con.Close();
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox7.Text = "";
            this.Hide();
            main1 mn1=new main1();
            mn1.Show();
        }
    }
}
