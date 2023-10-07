Imports System.Data.SqlClient
Public Class Details
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\DELL\OneDrive - Saegis Campus\Documents\EmployeeVbDb.mdf";Integrated Security=True;Connect Timeout=30")
    Private Sub FetchEmployeeData()
        If EmpId.Text = "" Then
            MsgBox("Enter the Employee Id")
        Else
            Con.Open()
            Dim Query = "select * from EmployeeTbl where EmpId=" & EmpId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpNamelbl.Text = dr(1).ToString()
                EmpAdd.Text = dr(2).ToString()
                EmpPoslbl.Text = dr(3).ToString()
                EmpDOBlbl.Text = dr(4).ToString()
                EmpPhone.Text = dr(5).ToString()
                EmpEdulbl.Text = dr(6).ToString()
                EmpGender.Text = dr(7).ToString()

                EmpNamelbl.Visible = True
                EmpAdd.Visible = True
                EmpPoslbl.Visible = True
                EmpDOBlbl.Visible = True
                EmpPhone.Visible = True
                EmpEdulbl.Visible = True
                EmpGender.Visible = True

            Next
            Con.Close()
        End If
    End Sub
    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub
End Class