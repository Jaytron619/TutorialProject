Public Class DateTimePicker
    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click
        Dim cDay = DateTimePicker1.Value.ToString("dd")
        txtDay.Text = cDay

        Dim cMonth = DateTimePicker1.Value.ToString("MMMM")
        txtMonth.Text = cMonth

        Dim cYear = DateTimePicker1.Value.ToString("yyyy")
        txtYear.Text = cYear
    End Sub


End Class