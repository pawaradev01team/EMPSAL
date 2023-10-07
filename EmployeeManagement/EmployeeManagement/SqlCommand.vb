Friend Class SqlCommand
    Private query As String
    Private con As SqlConnection
    Private adapter As SqlDataAdapter

    Public Sub New(adapter As SqlDataAdapter)
        Me.adapter = adapter
    End Sub

    Public Sub New(query As String, con As SqlConnection)
        Me.query = query
        Me.con = con
    End Sub

    Friend Sub ExecuteNonQuery()
        Throw New NotImplementedException()
    End Sub
End Class
