Imports System.Reflection
Imports Ssystem.Data.SqlClient
Public Class Salary
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
                EmpPoslbl.Text = dr(3).ToString()
                EmpNamelbl.Visible = True
                EmpPoslbl.Visible = True

            Next
            Con.Close()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()
    End Sub

    Dim DailyPay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpPoslbl.Text = "" Then
            MsgBox("Select an Employee")
        ElseIf WorkingTb.Text = "" Or Convert.ToInt32(WorkingTb.Text) > 28 Then
            MsgBox("Enter a Valid Number of Days")
        Else
            If EmpPoslbl.Text = "Manager" Then
                DailyPay = 1200
            ElseIf EmpPoslbl.Text = "Accountant" Then
                DailyPay = 1200
            ElseIf EmpPoslbl.Text = "Security Officer" Then
                DailyPay = 300
            ElseIf EmpPoslbl.Text = "Intern" Then
                DailyPay = 350
            Else
                DailyPay = 500
            End If
            Dim total = DailyPay * Convert.ToInt32(WorkingTb.Text)
            SalaryTb.Text = "Employee Id:    " + EmpId.Text + vdCrlf() + "Employee Name:   " + EmpNamelbl.Text + vdCrlf() + "Employee Position:    " + EmpPoslbl.Text + vdCrlf() + "Days Worked:    " + WorkingTb.Text + vdCrlf() + "Daily Salary Rs: " + Convert.ToString(DailyPay) + vdCrlf() + "Total Amount Rs:    " + Convert.ToString(total)

        End If
    End Sub

    Private Function vdCrlf() As String
        Throw New NotImplementedException()
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()

    End Sub
End Class