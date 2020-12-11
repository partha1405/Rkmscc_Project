Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As OleDbCommand
    Dim ds As DataSet
   

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Add("Male")
        Me.ComboBox1.Items.Add("Female")
        Me.ComboBox2.Items.Add("West Bengal")
        Me.ComboBox2.Items.Add("Assam")
        Me.ComboBox2.Items.Add("Bihar")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Please fill the info")
        Else
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=employeedatabase.mdb"
            Dim sql As String
            sql = "Insert into employeedetail values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox2.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
            con.Open()
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Sign In successfully")
            Me.Hide()
            Form4.Show()
            Form4.TextBox2.Text = Me.TextBox1.Text
            Form4.TextBox3.Text = Me.TextBox2.Text
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
           
            con.Close()
        End If
    End Sub
End Class