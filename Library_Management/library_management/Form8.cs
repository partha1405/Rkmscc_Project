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
    public partial class Form8 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbCommand com1;
        OleDbCommand com2;
        OleDbCommand com3;
        OleDbCommand com4;
        OleDbCommand com5;
        OleDbCommand com6;
        OleDbDataAdapter da;
        OleDbDataAdapter da1;
        OleDbDataAdapter da2;
        OleDbDataAdapter da3;
        OleDbDataAdapter da4;
        OleDbDataAdapter da5;
        DataSet ds;
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            
            string sqlx;
                 sqlx = "update logdata set issue_status='" + this.comboBox2.Text + "' where user_id='" + this.textBox1.Text + "'";
            com2 = new OleDbCommand(sqlx, con);
            com2.ExecuteNonQuery();
            MessageBox.Show("Book received");
            con.Close();
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                con.Open();
                com = new OleDbCommand("select user_name from issue where user_id='" + this.textBox1.Text + "'", con);
                da = new OleDbDataAdapter(com);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.textBox4.Text = ds.Tables[0].Rows[0][0].ToString();
                   
                }
                com1 = new OleDbCommand("select issue_status from logdata where user_id='" + this.textBox1.Text + "'", con);
                da1 = new OleDbDataAdapter(com1);
                ds = new DataSet();
                da1.Fill(ds, "noyes");
                if (ds.Tables["noyes"].Rows.Count > 0)
                {
                    this.comboBox2.Text = ds.Tables["noyes"].Rows[0][0].ToString();
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select book_id,date_submit from issue where user_id='" + this.textBox1.Text + "' and book_name='" +this.comboBox1.Text+ "'", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.textBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                this.dateTimePicker1.Text = ds.Tables[0].Rows[0][1].ToString();

            }
            else
            {
                MessageBox.Show("This book is not issue against this user_id");
            }
            con.Close();
        }
    }
}
