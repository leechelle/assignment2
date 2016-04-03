Imports System.IO

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.ManagementDataSet.Events)
        Form1.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EventsBindingSource1.AddNew()

        'SAVE DATA TO FILE
        Dim path As String = "Details.txt "
        If System.IO.File.Exists(path) = True Then
            Dim text As New FileStream(path, FileMode.Create, FileAccess.Write)
            text.Close()


            ''write in the file
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("Details.txt ", True)

            file.WriteLine(txtEvent.Text & ",")
            file.WriteLine(txtLocation.Text & ",")
            file.WriteLine(txtRegfee.Text & ",")
            file.WriteLine(DateTimePicker1.Text & ",")
            file.WriteLine(txtTitle.Text & ",")
            file.Close()
            MessageBox.Show("saved file")
        Else
            MessageBox.Show("did not create")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        EventsBindingSource1.EndEdit()
        EventsTableAdapter.Update(ManagementDataSet.Events)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        EventsBindingSource1.RemoveCurrent()
        MessageBox.Show("you have deleted the informatiom")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class