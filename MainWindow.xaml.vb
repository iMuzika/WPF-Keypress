Imports System.Text.RegularExpressions
Class MainWindow
    Private Sub UpperCaseAlphabet(ByVal sender As Object, ByVal e As TextCompositionEventArgs)
        Dim regex As Regex = New Regex("[^A-Z]+")
        e.Handled = regex.IsMatch(e.Text)
    End Sub
    Private Sub LowerCaseAlphabet(ByVal sender As Object, ByVal e As TextCompositionEventArgs)
        Dim regex As Regex = New Regex("[^a-z]+")
        e.Handled = regex.IsMatch(e.Text)
    End Sub
    Private Sub NumberHypenPlus(ByVal sender As Object, ByVal e As TextCompositionEventArgs)
        Dim regex As Regex = New Regex("[^0-9-+]+")
        e.Handled = regex.IsMatch(e.Text)
    End Sub
End Class
