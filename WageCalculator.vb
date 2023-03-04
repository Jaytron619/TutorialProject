Public Class WageCalculator
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()

        lblOvertime.Text = String.Empty
        lblOvertimeWage.Text = String.Empty
        lblWeeklySalary.Text = String.Empty
        lblTotalWeeklySalary.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim weeklySalary As Decimal
        Dim overtimeWage As Decimal
        Dim totalSalary As Decimal
        Dim overtime As Decimal

        If txtHoursWorked.Text <= 40 Then

            lblWeeklySalary.Text = txtHourlyWage.Text * txtHoursWorked.Text
            lblTotalWeeklySalary.Text = lblWeeklySalary.Text

        Else
            overtime = CDec(txtHoursWorked.Text) - 40
            weeklySalary = CDec(txtHourlyWage.Text) * 40
            overtimeWage = CDec(txtHourlyWage.Text) * overtime * 1.5
            totalSalary = overtimeWage + weeklySalary
            lblWeeklySalary.Text = weeklySalary
            lblOvertime.Text = overtime
            lblOvertimeWage.Text = overtimeWage
            lblTotalWeeklySalary.Text = totalSalary
        End If
    End Sub
End Class