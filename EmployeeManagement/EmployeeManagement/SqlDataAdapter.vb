Friend Class SqlDataAdapter
    Private sql As String
    Private con As SqlConnection
    Private cmd As SqlCommand

    Public Sub New(cmd As SqlCommand)
        Me.cmd = cmd
    End Sub

    Public Sub New(sql As String, con As SqlConnection)
        Me.sql = sql
        Me.con = con
    End Sub

    Friend Sub Fill(ds As DataSet)
        Throw New NotImplementedException()
    End Sub

    Public Shared Widening Operator CType(v As SqlDataAdapter) As SqlDataAdapter
        Throw New NotImplementedException()
    End Operator
End Class
