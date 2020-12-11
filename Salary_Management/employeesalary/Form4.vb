Imports System.Data
Imports System.Data.OleDb
Public Class Form4
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As OleDbCommand
    Dim ds As DataSet
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please fill the info")
        Else
            If TextBox4.Text = TextBox5.Text Then
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=employeedatabase.mdb"
                Dim sql As String
                sql = "Insert into login values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Sign In successfully")
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                Me.Hide()
                Form2.Show()
                con.Close()
            Else
                MsgBox("Confirm password is not same")
            End If
        End If
    End Sub
End Class