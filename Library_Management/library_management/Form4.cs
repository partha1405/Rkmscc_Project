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
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult dialog = MessageBox.Show("Do you want to issue?", "Issue", MessageBoxButtons.YesNo);
             if (dialog == DialogResult.Yes)
             {

                 con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                 con.Open();
                 com5 = new OleDbCommand("select issue_status from logdata where user_id='" + this.comboBox2.Text + "'", con);
                 da4 = new OleDbDataAdapter(com5);
                 ds = new DataSet();
                 da4.Fill(ds, "yesno");
                 if (ds.Tables["yesno"].Rows.Count > 0)
                 {
                     string yesno = ds.Tables["yesno"].Rows[0][0].ToString();
                     if (yesno == "Yes")
                     {
                         MessageBox.Show("A book is already issue against this userid");
                     }

                   /*  com4 = new OleDbCommand("select book_piece from book where book_name='" + this.comboBox1.Text + "'", con);
                     da2 = new OleDbDataAdapter(com4);
                     ds = new DataSet();
                     da2.Fill(ds, "2"); */

                     else
                     {
                         string sql;
                         sql = "insert into issue values('" + this.textBox2.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.textBox4.Text + "','" + this.dateTimePicker1.Value + "')";
                         com = new OleDbCommand(sql, con);
                         com.ExecuteNonQuery();
                         com1 = new OleDbCommand("select * from issue where user_id='" + this.comboBox2.Text + "' order by date_submit", con);
                         da = new OleDbDataAdapter(com1);
                         ds = new DataSet();
                         da.Fill(ds);
                         if (ds.Tables[0].Rows.Count > 0)
                         {
                             this.dataGridView1.DataSource = ds.Tables[0];
                         }
                         string sqlx;
                         sqlx = "update book set book_piece=book_piece-1  where book_id='" + this.textBox2.Text + "'";
                         com2 = new OleDbCommand(sqlx, con);
                         com2.ExecuteNonQuery();
                         com3 = new OleDbCommand("select * from book where book_id='" + this.textBox2.Text + "'", con);
                         da1 = new OleDbDataAdapter(com3);
                         ds = new DataSet();
                         da1.Fill(ds, "1");
                         if (ds.Tables[0].Rows.Count > 0)
                         {
                             this.dataGridView2.DataSource = ds.Tables[0];
                         }
                        
                         string sqlp = "update logdata set issue_status='Yes' where user_id='" + this.comboBox2.Text + "'";
                         com6 = new OleDbCommand(sqlp, con);
                         com6.ExecuteNonQuery();
                         this.comboBox1.Text = "";
                         this.textBox2.Text = "";
                         this.comboBox2.Text = "";
                         this.textBox4.Text = "";
                     }
                 }
                 con.Close();
             }
             else if (dialog == DialogResult.No)
             {
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = "";
            this.textBox2.Text = "";
            this.comboBox2.Text = "";
            this.textBox4.Text = "";
            this.Hide();
            main1 mn1 = new main1();
            mn1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select book_id from book where book_name='" + this.comboBox1.Text + "'", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
              
                this.textBox2.Text = ds.Tables[0].Rows[0][0].ToString();
               
            }
            com1 = new OleDbCommand("select * from book where book_name='" + this.comboBox1.Text + "'", con);
            da1 = new OleDbDataAdapter(com1);
            ds = new DataSet();
            da1.Fill(ds,"1");
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.dataGridView2.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select user_name from logdata where user_id='" + this.comboBox2.Text + "'", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                this.textBox4.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            con.Close();
        }
    }
}
