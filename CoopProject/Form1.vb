Public Class Form1
    Dim xTotal As Integer
    Dim yTotal As Integer
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value AndAlso NumericUpDown2.Value > 0 Then
            xTotal = NumericUpDown1.Value * 147
            totalTextBox.Text = "$" & xTotal + yTotal.ToString
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown1.Value AndAlso NumericUpDown2.Value > 0 Then
            yTotal = NumericUpDown2.Value * 147
            totalTextBox.Text = "$" & xTotal + yTotal.ToString
        End If
    End Sub

End Class
