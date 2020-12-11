'Imports System.Data
'Imports System.Data.OleDb
'Public Class Form7
'    Dim con As OleDbConnection
'    Dim adpt As OleDbDataAdapter
'    Dim ds As DataSet
'    Sub ShowData()
'        adpt = New OleDbDataAdapter("select * from salarydetail", con)
'        ds = New DataSet
'        adpt.Fill(ds)
'    End Sub
'    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
'        Dim sql As String
'        sql = "Insert into salarydetail values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
'    End Sub

'    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
'        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=employeedetail.mdb")
'        con.Open()
'        ShowData()
'    End Sub
'End Class