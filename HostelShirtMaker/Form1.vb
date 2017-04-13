Public Class ShirtMakerForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dirName As String = ".\newDir"
        My.Computer.FileSystem.CreateDirectory(dirName)
    End Sub
End Class
