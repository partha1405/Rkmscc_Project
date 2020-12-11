Imports System.Data
Imports System.Data.OleDb
Public Class Form5
    Dim con As OleDbConnection
    Dim adpt As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        adpt = New OleDbDataAdapter("Select * from login where e_name='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con)
        ds = New DataSet
        adpt.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            MsgBox("Login successfully")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Enter valid username or password")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=employeedatabase.mdb")
        con.Open()
    End Sub
End Class