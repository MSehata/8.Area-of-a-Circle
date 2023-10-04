Public Class Form1
    Private Sub txtArea_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim A As Double
        Dim r As Double
        Dim pi As Double

        pi = 3.142
        r = Val(txtRadius.Text)
        A = pi * r * r

        txtAnswer.Text = A
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
