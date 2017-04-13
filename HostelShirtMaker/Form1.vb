Public Class ShirtMakerForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim dirName As String = ".\newDir"
        'My.Computer.FileSystem.CreateDirectory(dirName)

        Dim dd = addAZero(DateTimePicker1.Value.Day)
        Dim mm = addAZero(DateTimePicker1.Value.Month)
        Dim yyyy = CStr(DateTimePicker1.Value.Year)

        Dim strDate As String = yyyy + mm + dd
        MsgBox(strDate)

    End Sub


    Private Function addAZero(i As Int32) As String
        If (i <= 9) Then
            addAZero = "0" + CStr(i)
        Else
            addAZero = CStr(i)
        End If
    End Function
End Class
