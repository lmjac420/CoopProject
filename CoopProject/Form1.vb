﻿Public Class Form1
    Dim Total As Integer
    Dim xValue As Integer
    Dim yValue As Integer
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value AndAlso NumericUpDown2.Value > 0 Then
            Total = NumericUpDown1.Value * NumericUpDown2.Value * 147
            totalTextBox.Text = "$" & Total.ToString
        End If
        xValue = NumericUpDown1.Value * 147
        If xValue = yValue Then
            xLabel.Text = xValue
            yLabel.Text = yValue
            PictureBox1.Image = My.Resources.Resource1.ResourceManager.GetObject("square")
        Else
            PictureBox1.Image = Nothing
            xLabel.Text = "N/A"
            yLabel.Text = "N/A"
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown1.Value AndAlso NumericUpDown2.Value > 0 Then
            Total = NumericUpDown1.Value * NumericUpDown2.Value * 147
            totalTextBox.Text = "$" & Total.ToString
        End If
        yValue = NumericUpDown2.Value * 147
        If xValue = yValue Then
            xLabel.Text = xValue
            yLabel.Text = yValue
            PictureBox1.Image = My.Resources.Resource1.ResourceManager.GetObject("square")
        Else
            PictureBox1.Image = Nothing
            xLabel.Text = "N/A"
            yLabel.Text = "N/A"
        End If
    End Sub
End Class
