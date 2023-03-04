Public Class Navigator
    Private Sub btnDatetimePicker_Click(sender As Object, e As EventArgs) Handles btnDatetimePicker.Click
        DateTimePicker.Show()
        Me.Hide()
    End Sub

    Private Sub btnWageCalculator_Click(sender As Object, e As EventArgs) Handles btnWageCalculator.Click
        WageCalculator.Show()
        Me.Hide()
    End Sub
End Class
