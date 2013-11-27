Public Class MainWindow

    Public _appControl As ApplicationController

    Public Sub New()
        _appControl = New ApplicationController()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = _appControl
    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Save button.")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As RoutedEventArgs) Handles btnPrevious.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As RoutedEventArgs) Handles btnNext.Click
        If txtFirstName Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf txtLastName Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf txtAddress Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf txtCity Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf txtState Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf txtZip Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf txtDescription Is Nothing Then
            MessageBox.Show("Please enter a description of the event", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf cmbxEquipment Is Nothing Then
            MessageBox.Show("Please enter the equipment", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        ElseIf cmbxIssue Is Nothing Then
            MessageBox.Show("Please enter the Issue", "Error", MessageBoxButton.OK, MessageBoxImage.Warning)
        End If

    End Sub
End Class
