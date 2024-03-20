Imports System.Drawing
Public Class VerticalLabel
    Inherits Label

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.TranslateTransform(0, Me.Height)
        g.RotateTransform(-90)
        g.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), New PointF(0, 0))

    End Sub
End Class