Public Class Form1
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
            xLabel.Text = NumericUpDown1.Value
            yLabel.Text = NumericUpDown2.Value
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
            xLabel.Text = NumericUpDown1.Value
            yLabel.Text = NumericUpDown2.Value
            PictureBox1.Image = My.Resources.Resource1.ResourceManager.GetObject("square")
        Else
            PictureBox1.Image = Nothing
            xLabel.Text = "N/A"
            yLabel.Text = "N/A"
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub purchaseButton_Click(sender As Object, e As EventArgs) Handles purchaseButton.Click
        If xValue AndAlso yValue > 0 Then
            ListBox1.Items.Add(NumericUpDown1.Value.ToString & "sqft")
            ListBox1.Items.Add("*")
            ListBox1.Items.Add(NumericUpDown2.Value.ToString & "sqft")
            ListBox1.Items.Add("=")
            ListBox1.Items.Add(NumericUpDown1.Value * NumericUpDown2.Value.ToString & "sqft total")
            ListBox1.Items.Add("----------------------------------")
            ListBox1.Items.Add(ComboBox1.Items(ComboBox1.SelectedIndex).ToString)
            ListBox1.Items.Add(" ")
            Select Case ComboBox1.Text
                Case "California (+30%)"
                    ListBox1.Items.Add("Total" & " " & "$" & Total * 1.3.ToString)
                Case "Nevada (+20%)"
                    ListBox1.Items.Add("Total" & " " & "$" & Total * 1.2.ToString)
                Case "New Mexico (Unaffected)"
                    ListBox1.Items.Add("Total" & " " & "$" & Total.ToString)
                Case "Utah (-20%)"
                    ListBox1.Items.Add("Total" & " " & "$" & Total * 0.8.ToString)
                Case "Arizona (Unaffected)"
                    ListBox1.Items.Add("Total" & " " & "$" & Total.ToString)
                Case "Texas (+5%)"
                    ListBox1.Items.Add("Total" & " " & "$" & Total * 1.05.ToString)
            End Select
        Else
                MsgBox("Square footage and/or specified location is blank", vbExclamation, "Error")
        End If
    End Sub

End Class
