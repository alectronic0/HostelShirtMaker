Public Class frmShirtMakerForm

    Dim dirName As String = ".\"


    Private Sub ShirtMakerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MsgBox("welcome")
        loadFrm()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim frmValid As Boolean = True
        Dim badList As List(Of String) = New List(Of String)

        Dim strName As String = txtName.Text
        Dim strRoom As String = "#" + txtRoom.Text

        Dim strShirtType As String = cmbShirtType.Text
        Dim strShirtSize As String = cmbShirtSize.Text

        Dim dd As String = addAZero(dtpPartyDate.Value.Day)
        Dim mm As String = addAZero(dtpPartyDate.Value.Month)
        Dim yyyy As String = CStr(dtpPartyDate.Value.Year)

        Dim strDate As String = yyyy + mm + dd


        If (strName.Equals("")) Then
            frmValid = False
            badList.Add("Name is Empty")
        End If

        If (strRoom.Equals("#")) Then
            frmValid = False
            badList.Add("Room is Empty")
        End If

        If (strShirtType.Equals("") Or Not validCmbValue(strShirtType, cmbShirtType)) Then
            frmValid = False
            badList.Add("Shirt Type is Empty or Invalid")
        End If

        If (strShirtSize.Equals("") Or Not validCmbValue(strShirtSize, cmbShirtSize)) Then
            frmValid = False
            badList.Add("Shirt Size is Empty or Invalid")
        End If



        If (frmValid) Then
            Dim fldName = strDate + "_" + strName + "_" + strRoom + "_" + strShirtType + "_" + strShirtSize

            'MsgBox(fldName + " Created")
            resetValues()
            My.Computer.FileSystem.CreateDirectory(dirName + fldName)
        Else
            Dim errorToString As String = ""
            For Each bad In badList
                errorToString = errorToString + Environment.NewLine + "- " + bad
            Next
            MsgBox("Somthing was Invalid!:" + errorToString)
        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetValues()
    End Sub


    Private Sub loadFrm()

        With btnReset
            .TabIndex = 0
        End With

        With txtName
            .Text = ""
            .TabIndex = 1
        End With

        With txtRoom
            .Text = ""
            .TabIndex = 2
        End With

        With cmbShirtType

            With .Items
                .Add("Singlet")
                .Add("T-shirt")
            End With
            .TabIndex = 4
        End With

        With cmbShirtSize

            With .Items
                .Add("XXS")
                .Add("XS")
                .Add("S")
                .Add("M")
                .Add("L")
                .Add("XL")
                .Add("XXL")
            End With
            .TabIndex = 5
        End With

        With dtpPartyDate
            .ResetText()
            .TabIndex = 5
        End With

        With btnSubmit
            .TabIndex = 999
        End With

    End Sub

    Private Sub resetValues()
        txtName.ResetText()
        txtRoom.ResetText()
        cmbShirtType.ResetText()
        cmbShirtSize.ResetText()
        dtpPartyDate.ResetText()
    End Sub

    Private Function addAZero(i As Int32) As String
        Dim str As String
        If (i <= 9) Then
            str = "0" + CStr(i)
        Else
            str = CStr(i)
        End If

        Return str
    End Function

    Private Function validCmbValue(s As String, cmb As ComboBox) As Boolean
        Dim valid As Boolean = False
        For i = 0 To cmb.Items.Count - 1
            Dim val As String = Convert.ToString(cmb.Items(i))
            Console.WriteLine(val)
            valid = valid Or s.Equals(val)
        Next i
        Return valid
    End Function

End Class
