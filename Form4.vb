Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.ManagementDataSet.Events)
        'TODO: This line of code loads data into the 'ManagementDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.ManagementDataSet.Members)

    End Sub
End Class