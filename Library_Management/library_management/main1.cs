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
    public partial class main1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbCommand com1;
        OleDbDataAdapter da;
        OleDbDataAdapter da1;
        DataSet ds;
        DataSet ds1;

        private int childFormNumber = 0;

        public main1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
        }

        private void OpenFile(object sender, EventArgs e)
        {
           
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newBookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
                con.Open();
                com1 = new OleDbCommand("select max(book_id) from book", con);
                da1 = new OleDbDataAdapter(com1);
                ds = new DataSet();
                da1.Fill(ds, "book");
                if (ds.Tables["book"].Rows.Count > 0)
                {
                    string stringtoint = ds.Tables["book"].Rows[0][0].ToString().Substring(3);
                    int num = Convert.ToInt16(stringtoint) + 1;
                    string inttostring = "BPR" + num.ToString();
                    frm2.textBox1.Text = inttostring.ToString();
                }
                com = new OleDbCommand("select * from book order by book_id", con);
                da = new OleDbDataAdapter(com);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    frm2.dataGridView1.DataSource = ds.Tables[0];
                }
                con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void newBookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select * from issue", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                frm4.dataGridView1.DataSource = ds.Tables[0];
            }
            com1 = new OleDbCommand("select * from book", con);
            da1 = new OleDbDataAdapter(com1);
            ds = new DataSet();
            da1.Fill(ds,"1");
            if (ds.Tables[0].Rows.Count > 0)
            {
                frm4.dataGridView2.DataSource = ds.Tables[0];
            }
            OleDbDataReader dr=new OleDbCommand("select book_name from book order by book_name",con).ExecuteReader();
            while(dr.Read())
            {
                frm4.comboBox1.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            
            OleDbDataReader dr1=new OleDbCommand("select user_id from logdata order by user_id",con).ExecuteReader();
            while(dr1.Read())
            {
                frm4.comboBox2.Items.Add(dr1.GetValue(0).ToString());
            }
            dr1.Close();
            con.Close();
        
        }

        private void searchIssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.MdiParent = this;
            frm6.Show();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select * from issue", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                frm6.dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void displayStoreRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.MdiParent = this;
            frm5.Show();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
            com = new OleDbCommand("select * from book", con);
            da = new OleDbDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                frm5.dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void printBookRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form7 frm7 = new Form7();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void searchIssueBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form8 frm8 = new Form8();
            frm8.MdiParent = this;
            frm8.Show();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=library.mdb";
            con.Open();
           
            OleDbDataReader dr = new OleDbCommand("select book_name from book order by book_name", con).ExecuteReader();
            while (dr.Read())
            {
                frm8.comboBox1.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
