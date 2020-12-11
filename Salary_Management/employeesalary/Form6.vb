Imports System.Data
Imports System.Data.OleDb
Public Class Form6
    Dim con As OleDbConnection
    Dim adpt As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        adpt = New OleDbDataAdapter("Select * from employeedetail where e_id='" & TextBox1.Text & "'", con)
        ds = New DataSet
        adpt.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TextBox2.Text = ds.Tables(0).Rows(0).Item("e_name").ToString()
            TextBox3.Text = ds.Tables(0).Rows(0).Item("e_dob").ToString()
            ComboBox1.Text = ds.Tables(0).Rows(0).Item("e_gender").ToString()
            TextBox4.Text = ds.Tables(0).Rows(0).Item("e_address").ToString()
            TextBox5.Text = ds.Tables(0).Rows(0).Item("e_city").ToString()
            ComboBox2.Text = ds.Tables(0).Rows(0).Item("e_state").ToString()
            TextBox6.Text = ds.Tables(0).Rows(0).Item("e_pin").ToString()
            TextBox7.Text = ds.Tables(0).Rows(0).Item("e_fm_name").ToString()
            TextBox8.Text = ds.Tables(0).Rows(0).Item("e_phone").ToString()
            TextBox9.Text = ds.Tables(0).Rows(0).Item("e_email").ToString()
        Else
            MsgBox("Record not found")
        End If
    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=employeedatabase.mdb")
        con.Open()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim sql As String
        sql = "Update employeedetail set e_name='" & TextBox2.Text & "',e_dob='" & TextBox3.Text & "',e_gender='" & ComboBox1.Text & "',e_address='" & TextBox4.Text & "',e_city='" & TextBox5.Text & "',e_state='" & ComboBox2.Text & "',e_pin='" & TextBox6.Text & "',e_fm_name='" & TextBox7.Text & "',e_phone='" & TextBox8.Text & "',e_email='" & TextBox9.Text & "' where e_id='" & TextBox1.Text & "'"
        cmd = New OleDbCommand(sql, con)  
        cmd.ExecuteNonQuery()
        MsgBox("updated")
    End Sub
   
    Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim sql As String
        sql = "Delete  * From employeedetail where e_id='" & TextBox1.Text & "'"
        cmd = New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted!!!")
    End Sub
End Class