Imports System.IO
Public Class Form3
    Dim gender As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.ManagementDataSet.Members)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click







    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MembersBindingSource.AddNew()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MembersBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtOutFee.Text = ""
        txtRace.Text = ""
        txtRaceTime.Text = ""
        txtRace.Text = ""
        txtMembership.Text = ""
        txtFemale.Text = ""
        txtMale.Text = ""
    End Sub

    Private Sub btnBefore_Click(sender As Object, e As EventArgs) Handles btnBefore1.Click
        MembersBindingSource.EndEdit()
        MembersTableAdapter.Update(ManagementDataSet.Members)

        ''random 
        Dim a As New Random()
        Dim number = a.Next(0, 999)
        txtMembership.Text = number

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyymmdd"





        Dim nber As Integer = 10
        Dim output As Integer = DateTimePicker1.Format + DateTimePicker2.Format + number
        Dim DNumber As Integer = output Mod nber
        'check digit
        Dim cDigit As Integer
        If DNumber = 0 Then
            cDigit = 0
        Else
            cDigit = number - DNumber
        End If
        btnBefore1.Text = btnBefore1.Text
        'numbers will be displayed as a string, not a sum
        txtBeforeSave.Text = DateTimePicker1.Text + DateTimePicker2.Text + txtMembership.Text

        Dim path As String = "MEMBER.txt "
        If System.IO.File.Exists(path) = True Then
            Dim text As New FileStream(path, FileMode.Create, FileAccess.Write)

            text.Close()



            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("MEMBER.txt ", True)

            file.WriteLine("Membership Number = " + txtMembership.Text & ",")
            file.WriteLine("First name = " + txtFirstName.Text & ",")
            file.WriteLine("Surname = " + txtSurname.Text & ",")
            file.WriteLine("Date of Birth = " + DateTimePicker1.Text & ",")
            file.WriteLine("Date Joined = " + DateTimePicker2.Text & ",")
            file.WriteLine("Oustanding fee = " + txtOutFee.Text & ",")
            file.WriteLine("Race In = " + txtRace.Text & ",")
            file.WriteLine("Race time Completed = " + txtRaceTime.Text & ",")



            file.Close()

            MessageBox.Show("file saved")
        Else
            MessageBox.Show("File didnt save")
        End If

        If Not IsNumeric(txtMembership.Text) Then
            MessageBox.Show("please enter a Membership Number")

        End If

        If Not IsNumeric(txtRace.Text) Then
            MessageBox.Show("please enter kilometers")

        End If

        If Not IsNumeric(txtRaceTime.Text) Then
            MessageBox.Show("please enter time completed in ")
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Form4.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
    End Sub

    Private Sub txtMale_CheckedChanged(sender As Object, e As EventArgs) Handles txtMale.CheckedChanged

    End Sub

    Private Sub txtFemale_CheckedChanged(sender As Object, e As EventArgs) Handles txtFemale.CheckedChanged

    End Sub
    Private Function GetCheckedItem()
        Dim selected As String = ""
        If txtMale.Checked Then
            selected = "Male"
        ElseIf txtFemale.Checked Then
            selected = "female"
        End If

        Return selected
    End Function
End Class