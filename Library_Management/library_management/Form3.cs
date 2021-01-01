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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbCommand com1;
        OleDbDataAdapter da;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select * from book where book_id='" +this.textBox1.Text+ "'", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                this.textBox6.Text = ds.Tables[0].Rows[0][0].ToString();
                this.textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                this.textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                this.textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                this.textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                this.textBox7.Text = ds.Tables[0].Rows[0][5].ToString();
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                con.Open();
                com = new OleDbCommand("select * from book where book_id='" + this.textBox1.Text + "'", con);
                da = new OleDbDataAdapter(com);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                    this.textBox6.Text = ds.Tables[0].Rows[0][0].ToString();
                    this.textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                    this.textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                    this.textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                    this.textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                    this.textBox7.Text = ds.Tables[0].Rows[0][5].ToString();
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult dialog = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo);
             if (dialog == DialogResult.Yes)
             {
                 con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                 con.Open();
                 string sql;
                 sql = "update book set book_name='" + this.textBox2.Text + "',book_author='" + this.textBox3.Text + "',isbm='" + this.textBox4.Text + "',amount=" + this.textBox5.Text + ", book_piece=" + this.textBox7.Text + " where book_id='" + this.textBox6.Text + "'";
                 com = new OleDbCommand(sql, con);
                 com.ExecuteNonQuery();
                 MessageBox.Show("Record updated successfully");
                 com1 = new OleDbCommand("select * from book where book_id='" + this.textBox6.Text + "'", con);
                 da = new OleDbDataAdapter(com1);
                 ds = new DataSet();
                 da.Fill(ds);
                 if (ds.Tables[0].Rows.Count > 0)
                 {
                     this.textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                     this.textBox6.Text = ds.Tables[0].Rows[0][0].ToString();
                     this.textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                     this.textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                     this.textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                     this.textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                     this.textBox7.Text = ds.Tables[0].Rows[0][5].ToString();
                     this.dataGridView1.DataSource = ds.Tables[0];
                 }
                 con.Close();
             }
             else if (dialog == DialogResult.No)
             {
             }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            string sql;
            sql = "delete * from book where book_id='" + this.textBox6.Text + "'";
            com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
            this.textBox1.Text = "";
            this.textBox6.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox7.Text = "";
            this.dataGridView1.DataSource = "";
            con.Close();
        }
    }
}
