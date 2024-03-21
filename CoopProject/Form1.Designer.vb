<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.xLabel = New System.Windows.Forms.Label()
        Me.yLabel = New CoopProject.VerticalLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.purchaseButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(57, 17)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown1.TabIndex = 0
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(57, 46)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.ReadOnly = True
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X (sqft)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Y (sqft)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:"
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(221, 32)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(118, 23)
        Me.totalTextBox.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.totalTextBox)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 83)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'xLabel
        '
        Me.xLabel.Location = New System.Drawing.Point(18, 337)
        Me.xLabel.Name = "xLabel"
        Me.xLabel.Size = New System.Drawing.Size(300, 15)
        Me.xLabel.TabIndex = 8
        Me.xLabel.Text = "N/A"
        Me.xLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'yLabel
        '
        Me.yLabel.Location = New System.Drawing.Point(324, 34)
        Me.yLabel.Name = "yLabel"
        Me.yLabel.Size = New System.Drawing.Size(15, 175)
        Me.yLabel.TabIndex = 9
        Me.yLabel.Text = "N/A"
        Me.yLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(520, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(181, 439)
        Me.ListBox1.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.xLabel)
        Me.GroupBox2.Controls.Add(Me.yLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 362)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visualization (must be 1:1)"
        '
        'purchaseButton
        '
        Me.purchaseButton.Location = New System.Drawing.Point(367, 56)
        Me.purchaseButton.Name = "purchaseButton"
        Me.purchaseButton.Size = New System.Drawing.Size(147, 30)
        Me.purchaseButton.TabIndex = 12
        Me.purchaseButton.Text = "Calculate Total"
        Me.purchaseButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(367, 92)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(147, 30)
        Me.clearButton.TabIndex = 13
        Me.clearButton.Text = "Reset"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"California (+30%)", "Nevada (+20%)", "New Mexico (Unaffected)", "Utah (-20%)", "Arizona (Unaffected)", "Texas (+5%)", "test"})
        Me.ComboBox1.Location = New System.Drawing.Point(367, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 23)
        Me.ComboBox1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Location"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 471)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.purchaseButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Room Price Calculator"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents xLabel As Label
    Friend WithEvents yLabel As VerticalLabel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents purchaseButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
