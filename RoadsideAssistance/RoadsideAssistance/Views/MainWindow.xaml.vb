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

    End Sub
End Class
