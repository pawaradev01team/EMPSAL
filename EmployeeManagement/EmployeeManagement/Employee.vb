Public Class Employee
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\DELL\OneDrive - Saegis Campus\Documents\EmployeeVbDb.mdf";Integrated Security=True;Connect Timeout=30")
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDGV.CellContentClick
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommand
        builder = New SqlCommand(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDGV.DataSource = ds.Tables(0)
        Con.Close()
        Populate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into EmployeeTb1('" & EmpName.Text & "','" & EmpAdd.Text & "', '" & GendCb.SelectedItem.ToString() & "','" & EmpDOB.Value & "','" & EmpPhoneTb.Text & "', '" & EmpEdCb.SelectedItem.ToString() & "' , '" & EmpPos.SelectedItem.ToString() & "' )"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Employee Added")
        Con.Close()
    End Sub
    Dim key = 0
    Private Sub Clear()
        EmpName.Clear()
        EmpPos.Text = ""
        GendCb.Text = ""
        EmpAdd.Text = ""
        key = 0
        EmpEdCb.Text = ""
        EmpPhoneTb.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MsgBox("Employee is Deleted")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from EmployeeTbl where EmpId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Delete Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        EmpName.Text = row.Cells(1).Value.ToString()
        EmpAdd.Text = row.Cells(2).Value.ToString()
        EmpPos.Text = row.Cells(3).Value.ToString()
        EmpDOB.Value = row.Cells(4).Value.ToString
        EmpPhoneTb.Text = row.Cells(5).Value.ToString()
        EmpEdCb.Text = row.Cells(6).Value.ToString()
        GendCb.Text = row.Cells(7).Value.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If EmpName.Text = "" Or EmpPhoneTb.Text = "" Or EmpAdd.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update EmployeeTbl set EmpName = '" & EmpName.Text & "', EmpAdd = '" & EmpAdd.Text & "', EmpPos='" & EmpPos.SelectedItem.ToString() & "', EmpDob= '" & EmpDOB.Value & "', EmpPhone='" & EmpPhoneTb.Text & "', EmpEdu='" & EmpEdCb.SelectedItem.ToString() & "' EmpGend='" & GendCb.SelectedItem.ToString() & "' where EmpId=" & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Update")
            Con.Close()
            Populate()
            Clear()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub
End Class