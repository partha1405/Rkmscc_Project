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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "" && this.textBox1.Text == "" && this.textBox2.Text == "")
            {
                MessageBox.Show("Please fill the info");
            }
            else if (this.comboBox1.Text == "" && this.textBox1.Text == "")
            {
                MessageBox.Show("You must select user type and enter user id");
            }
            else if (this.comboBox1.Text == "" && this.textBox2.Text == "")
            {
                MessageBox.Show("You must select user type and enter password");
            }
            else if (this.textBox1.Text == "" && this.textBox2.Text == "")
            {
                MessageBox.Show("You must enter user id and password");
            }
            else
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                con.Open();
                com = new OleDbCommand("select * from logdata where user_type='" + this.comboBox1.Text + "' and user_id='" + this.textBox1.Text + "' and user_password='" + this.textBox2.Text + "'", con);
                da = new OleDbDataAdapter(com);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "Administrator")
                    {
                        this.Hide();
                        main1 mn1 = new main1();
                        mn1.Show();
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "Guest")
                    {
                        this.Hide();
                        main2 mn2 = new main2();
                        mn2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please select correct user type and enter valid user id and password");
                    this.comboBox1.Text = "";
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                }
                con.Close();

            }
        }
    }
}
